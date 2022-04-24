﻿using ARINLAB.Services.ImageService;
using ARINLAB.Services.SessionService;
using AutoMapper;
using DAL.Data;
using DAL.Models;
using DAL.Models.Dto;
using DAL.Models.ResponceModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARINLAB.Services
{
    public class WordServices : IWordServices
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IImageService _fileService;
        private readonly UserDictionary _userDict;
        private readonly ILogger<WordServices> _logger;
        private readonly IDictionaryService _dictionaryService;
        private readonly UserManager<DAL.Models.ApplicationUser> _userManager;
        public WordServices(ApplicationDbContext applicationDbContext, IMapper mapper, IImageService imageService
                            , UserDictionary u, ILogger<WordServices> logger, IDictionaryService dictionaryService,
                            UserManager<DAL.Models.ApplicationUser> userManager
            )
        {
            _dbContext = applicationDbContext;
            _mapper = mapper;
            _fileService = imageService;
            _userDict = u;
            _logger = logger;
            _dictionaryService = dictionaryService;
            _userManager = userManager;
        }
        public async Task<Responce> addWordAsync(CreateWordDto word)
        {
            Responce result = new Responce();
            try
            {
                var _word = _mapper.Map<Word>(word);
                _word.ArabWord = _word.ArabWord.Trim();
                _word.OtherWord = _word.OtherWord.Trim();
                var gotAlready = new List<Word>(_dbContext.Words.Where(p => p.OtherWord.CompareTo(_word.OtherWord) == 0 && p.ArabWord.CompareTo(_word.ArabWord) == 0).AsNoTracking());
                if(gotAlready != null && gotAlready.Count() > 0)
                {
                    return ResponceGenerator.GetResponceModel(false, "This word is already in the Dictionary", _word);
                }
                if (word.ArabVoiceForm != null)
                    _word.ArabVoice = await _fileService.UploadImage(word.ArabVoiceForm, SD.wordFilePath);
                if (word.OtherVoiceForm != null)
                    _word.OtherVoice = await _fileService.UploadImage(word.OtherVoiceForm, SD.wordFilePath);

                _word.AddedDate = DateTime.Now;
                var data = _dbContext.Words.AddAsync(_word).Result;
                await _dbContext.SaveChangesAsync();
                if (data.IsKeySet)
                {
                    return ResponceGenerator.GetResponceModel(true, "", data.Entity);
                }
                else
                {
                    return ResponceGenerator.GetResponceModel(false, $"Could Not add Word. {data.State}", data);
                }
            }catch(Exception e) {
                _logger.LogError(e.Message);
                return ResponceGenerator.GetResponceModel(false, e.Message, null);
            }
        }

        public async Task<Responce> CreateWordSentenceAsync(CreateWordSentencesDto createWordModel)
        {
            try
            {
                if (createWordModel != null)
                {
                    var newSentences = _mapper.Map<WordSentences>(createWordModel);
                    newSentences.ArabSentence = newSentences.ArabSentence;
                    newSentences.OtherSentence = newSentences.OtherSentence;
                    if (createWordModel.ArabVoiceForm != null)
                        newSentences.ArabVoice = await _fileService.UploadImage(createWordModel.ArabVoiceForm, SD.wordFilePath);
                    if (createWordModel.OtherVoiceForm != null)
                        newSentences.OtherVoice = await _fileService.UploadImage(createWordModel.OtherVoiceForm, SD.wordFilePath);

                    newSentences.AddedDate = DateTime.Now;
                    var data = await _dbContext.WordSentences.AddAsync(newSentences);
                    await _dbContext.SaveChangesAsync();
                    return ResponceGenerator.GetResponceModel(true, "", data);
                }
                return ResponceGenerator.GetResponceModel(false, "", createWordModel);
            }catch(Exception e)
            {
                _logger.LogError(e.Message);
                return ResponceGenerator.GetResponceModel(false, e.Message, createWordModel);
            }
        }

        public async Task<Responce> Delete(int id)
        {
            var res = await _dbContext.Words.FindAsync(id);
            try
            {
                if (res != null)
                {                                     
                   _fileService.DeleteImage(res.ArabVoice);
                   _fileService.DeleteImage(res.OtherVoice);                     
                }
                    _dbContext.Words.Remove(res);
                    await _dbContext.SaveChangesAsync();
                    return ResponceGenerator.GetResponceModel(true, "", res);                              
            }catch(Exception e)
            {
                _logger.LogError(e.Message);
                return ResponceGenerator.GetResponceModel(false, "Some Error Accured", null);
            }
        }

        public async Task<Responce> DeleteSentence(int id)
        {            
            var res = await _dbContext.WordSentences.FindAsync(id);
            if (res != null)
            {
                _fileService.DeleteImage(res.ArabVoice);
                _fileService.DeleteImage(res.OtherVoice);     
                
                _dbContext.WordSentences.Remove(res);
                await _dbContext.SaveChangesAsync();
                return ResponceGenerator.GetResponceModel(true, "", res);
            }
            return ResponceGenerator.GetResponceModel(false, "", null);
        }

        public async Task<Responce> EditWordApproveByIdAsync(int id, bool approve)
        {
            var res = await _dbContext.Words.FindAsync(id);
            if(res != null)
            {
                res.IsApproved = approve;
                res = _dbContext.Words.Update(res).Entity;
                await _dbContext.SaveChangesAsync();
                return ResponceGenerator.GetResponceModel(true, "Success", res);
            }
            return ResponceGenerator.GetResponceModel(false, "Error", res);
        }

       
        public async Task<Responce> editWordAsync(EditWordDto editWordDto)
        {
            if (editWordDto == null)
                return ResponceGenerator.GetResponceModel(false, "Data is being modifyed is null", null);
            var _word = await _dbContext.Words.FindAsync(editWordDto.Id);

            _word.ArabWord = editWordDto.ArabWord;
            _word.DictionaryId = editWordDto.DictionaryId;
            _word.IsApproved = editWordDto.IsApproved;
            _word.UserId = editWordDto.UserId;
            _word.OtherWord = editWordDto.OtherWord;
            _word.ImageForShare = editWordDto.ImageForShare;
            _word.ArabVoice = editWordDto.ArabVoice;
            _word.OtherVoice = editWordDto.OtherVoice;
            _word.AddedDate = DateTime.Now;
            
            if (editWordDto.ArabVoiceForm != null)
            {
                if (string.IsNullOrEmpty(_word.ArabVoice))
                {                    
                    _word.ArabVoice = await _fileService.UploadImage(editWordDto.ArabVoiceForm, SD.wordFilePath);
                }else if (string.IsNullOrEmpty(_word.ArabVoice1))
                {                    
                    _word.ArabVoice1 = await _fileService.UploadImage(editWordDto.ArabVoiceForm, SD.wordFilePath);
                }
                else if(string.IsNullOrEmpty(_word.ArabVoice2))
                {
                    _word.ArabVoice2 = await _fileService.UploadImage(editWordDto.ArabVoiceForm, SD.wordFilePath);
                }else if (string.IsNullOrEmpty(_word.ArabVoice3))
                {
                    _word.ArabVoice3 = await _fileService.UploadImage(editWordDto.ArabVoiceForm, SD.wordFilePath);
                }else if (string.IsNullOrEmpty(_word.ArabVoice4))
                {
                    _word.ArabVoice4 = await _fileService.UploadImage(editWordDto.ArabVoiceForm, SD.wordFilePath);
                }
            }

            if (editWordDto.OtherVoiceForm != null)
            {
                if (string.IsNullOrEmpty(_word.OtherVoice))
                    _word.OtherVoice = await _fileService.UploadImage(editWordDto.OtherVoiceForm, SD.wordFilePath);
                else if (string.IsNullOrEmpty(_word.OtherVoice1))
                    _word.OtherVoice1 = await _fileService.UploadImage(editWordDto.OtherVoiceForm, SD.wordFilePath);
                else if (string.IsNullOrEmpty(_word.OtherVoice2))
                    _word.OtherVoice2 = await _fileService.UploadImage(editWordDto.OtherVoiceForm, SD.wordFilePath);
                else if (string.IsNullOrEmpty(_word.OtherVoice3))
                    _word.OtherVoice3 = await _fileService.UploadImage(editWordDto.OtherVoiceForm, SD.wordFilePath);
                else if (string.IsNullOrEmpty(_word.OtherVoice4))
                    _word.OtherVoice4 = await _fileService.UploadImage(editWordDto.OtherVoiceForm, SD.wordFilePath);                
            }
            
            Responce result = new Responce();
            try
            {                
                var data = _dbContext.Words.Update(_word);
                await _dbContext.SaveChangesAsync();
               
                return ResponceGenerator.GetResponceModel(true, "", data.Entity);    
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return ResponceGenerator.GetResponceModel(false, e.Message, null);
            }
        }

        public async Task<Responce> EditWordSentenceApproveByIdAsync(int id, bool approve)
        {
            var res = await _dbContext.WordSentences.FindAsync(id);
            if (res != null)
            {
                res.IsApproved = approve;
                res = _dbContext.WordSentences.Update(res).Entity;
                await _dbContext.SaveChangesAsync();
                return ResponceGenerator.GetResponceModel(true, "Success", res);
            }
            return ResponceGenerator.GetResponceModel(false, "Error", res);
        }

        public async Task<Responce> EditWordSentenceAsync(WordSentencesDto editWordSentence)
        {
            try
            {
                if (editWordSentence != null)
                {

                    var editWord = _mapper.Map<WordSentences>(editWordSentence);

                    if (editWordSentence.ArabVoiceForm != null)
                    {
                        _fileService.DeleteImage(editWord.ArabVoice);
                        editWord.ArabVoice = await _fileService.UploadImage(editWordSentence.ArabVoiceForm, SD.wordFilePath);
                    }

                    if (editWordSentence.OtherVoiceForm != null)
                    {
                        _fileService.DeleteImage(editWord.OtherVoice);
                        editWord.OtherVoice = await _fileService.UploadImage(editWordSentence.OtherVoiceForm, SD.wordFilePath);
                    }

                    editWord.ArabSentence = editWord.ArabSentence;
                    editWord.OtherSentence = editWord.OtherSentence;
                    editWord.AddedDate = DateTime.Now;
                    var data = _dbContext.WordSentences.Update(editWord).Entity;
                    _ = await _dbContext.SaveChangesAsync();
                    return ResponceGenerator.GetResponceModel(true, "", data);
                }
                return ResponceGenerator.GetResponceModel(false, "", editWordSentence);
            }
            catch(Exception e)
            {
                _logger.LogError(e.Message);
                return ResponceGenerator.GetResponceModel(false, e.Message, editWordSentence);
            }
        }

        public async Task<List<WordDto>> GetAllWordsAsync()
        {
            try
            {
                var result = _mapper.Map<List<WordDto>>(_dbContext.Words.AsNoTracking());
               
                foreach (var item in result)
                {
                    try
                    {
                        item.Dictionary = _dbContext.Dictionaries.Find(item.DictionaryId)?.Language;
                        item.UserEmail = (await _userManager.FindByIdAsync(item.UserId))?.Email;
                    }catch(Exception e)
                    {

                    }
                }
                return result;
            }
            catch(Exception e)
            {
                _logger.LogError(e.Message);
                return new List<WordDto>();
            }            
        }

        public List<WordDto> GetAllWords(string userId, int pageNumber, int count)
        {
            try
            {
                var result = _mapper.Map<List<WordDto>>(_dbContext.Words.Where(p => p.UserId == userId).Skip((pageNumber - 1) * count).Take(count).AsNoTracking());
                int n = 1 + (pageNumber - 1) * count;
                foreach (var item in result)
                {
                    item.Dictionary = _dbContext.Dictionaries.Find(item.DictionaryId).Language;
                    item.Number = n;
                    ++n;
                }
                return result;
            }
            catch (Exception e)
            {
                return new List<WordDto>();
            }

        }

        public List<WordDto> GetAllWordsByUserId(string userId)
        {
            var result = _mapper.Map<List<WordDto>>(_dbContext.Words.Where(p => p.UserId == userId).Include(p => p.WordSentences).AsNoTracking());
            foreach(var item in result)
            {
                item.Dictionary = _dbContext.Dictionaries.Find(item.DictionaryId).Language;
            }
            return result;
        }

        public List<WordSentencesDto> GetAllWordSentences()
        {
            throw new NotImplementedException();
        }

        public List<WordSentencesDto> GetAllWordSentencesByWordId(int wordId)
        {
            try
            {
                var res = _dbContext.WordSentences.Where(p => p.WordId == wordId);
                return _mapper.Map<List<WordSentencesDto>>(res);
            }catch(Exception e)
            {
                _logger.LogError(e.Message);
                return new List<WordSentencesDto>();
            }
        }

        public async Task<WordDto> GetWordByIdAsync(int id)
        {
            try
            {
                var r = _mapper.Map<WordDto>(await _dbContext.Words.FindAsync(id));
                r.Dictionary = (await _dbContext.Dictionaries.FindAsync(r.DictionaryId))?.Language;
                return r;
            }catch(Exception e)
            {
                _logger.LogError(e.Message);
                return null;
            }
        }

        public async Task<WordSentencesDto> GetWordSentencesById(int id)
        {
            try
            {
                var res = await _dbContext.WordSentences.FindAsync(id);
                if (res != null)
                    return _mapper.Map<WordSentencesDto>(res);
                return null;
            }catch(Exception e)
            {
                _logger.LogError(e.Message);
                return null;
            }
        }

        public List<WordDto> GetWordsWithApproval(bool isApproved)
        {
            var res = _mapper.Map<List<WordDto>>(_dbContext.Words.Where(p => p.IsApproved == true).Include(p => p.WordSentences));
            foreach(var r in res)
            {
                r.Dictionary = _dbContext.Dictionaries.Find(r.DictionaryId)?.Language;
            }
            return res;
        }

        public List<WordDto> GetRandom_N_Words(int n)
        {
            try
            {
                var dictId = _userDict.GetDictionaryId();                
                var res = _dbContext.Words.Where(p => p.DictionaryId == dictId && p.IsApproved == true).ToList();
                _dictionaryService.Shuffle(res);
                res = res.Take(n).ToList();
                if (res != null)
                {
                    foreach(var w in res)
                    {
                        string t = $"{w.ArabVoice};{w.ArabVoice1};{w.ArabVoice2};{w.ArabVoice3};{w.ArabVoice4}";
                        string[] m = t.Trim().Split(";");
                        string p = null;
                        foreach (var s in m)
                            if (!string.IsNullOrEmpty(s))
                                p = p == null ? $"{s}" : $"{p};{s}";
                        w.ArabVoice = p;

                        string t1 = $"{w.OtherVoice};{w.OtherVoice1};{w.OtherVoice2};{w.OtherVoice3};{w.OtherVoice4}";
                        string[] m1 = t1.Trim().Split(";");
                        string p1 = null;
                        foreach (var s in m1)
                            if (!string.IsNullOrEmpty(s))
                                p1 = p1 == null ? $"{s}" : $"{p1};{s}";
                        w.OtherVoice = p1;
                    }
                    return _mapper.Map<List<WordDto>>(res);
                }
                    return new List<WordDto>();                
               
            }catch(Exception e)
            {
                _logger.LogError(e.Message);
                return null;
            }
        }

        public List<WordDto> GetAllWordsWithDictId(int id)
        {
            try
            {
                var res1 = _dbContext.Words.Where(p => p.DictionaryId == id && p.IsApproved == true);
                var res = _mapper.Map<List<WordDto>>(res1);
                string dd = _dbContext.Dictionaries.Find(id)?.Language;
                foreach (var w in res)
                {
                    w.Dictionary = string.IsNullOrEmpty(dd) ? "" : dd;
                    string t = $"{w.ArabVoice};{w.ArabVoice1};{w.ArabVoice2};{w.ArabVoice3};{w.ArabVoice4}";
                    string[] m = t.Trim().Split(";");
                    string p = null;
                    foreach (var s in m)
                        if (!string.IsNullOrEmpty(s))
                            p = p == null ? $"{s}" : $"{p};{s}";
                    w.ArabVoice = p;

                    string t1 = $"{w.OtherVoice};{w.OtherVoice1};{w.OtherVoice2};{w.OtherVoice3};{w.OtherVoice4}";
                    string[] m1 = t1.Trim().Split(";");
                    string p1 = null;
                    foreach (var s in m1)
                        if (!string.IsNullOrEmpty(s))
                            p1 = p1 == null ? $"{s}" : $"{p1};{s}";
                    w.OtherVoice = p1;
                }
                return res;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new List<WordDto>();
            }
        }

        public async Task<WordDto> IncreaseViewed(int wordId)
        {
            var word = await _dbContext.Words.FindAsync(wordId);
            int dictId = _userDict.GetDictionaryId();
            if(word.DictionaryId != dictId)
                return null;
            if (word!= null)
            {
                if (word.Viewed == null)
                    word.Viewed = 0;
                word.Viewed += 1;
                _dbContext.Words.Update(word);
                await _dbContext.SaveChangesAsync();

                var res = _mapper.Map<WordDto>(word);
                res.Dictionary = (await _dbContext.Dictionaries.FindAsync(res.DictionaryId))?.Language;
                return res;
            }
            return null;
        }

        public async Task<bool> DeleteVoice(int id, int vnum)
        {
            var res = await _dbContext.Words.FindAsync(id);
            if (res == null)
                return false;

            switch (vnum)
            {
                case 0:
                    _fileService.DeleteImage(res.ArabVoice);
                    res.ArabVoice = null;
                    _fileService.DeleteImage(res.OtherVoice);
                    res.OtherVoice = null;                    
                    break;
                case 1:
                    _fileService.DeleteImage(res.ArabVoice1);
                    res.ArabVoice1 = null;
                    _fileService.DeleteImage(res.OtherVoice1);
                    res.OtherVoice1 = null;
                    break;
                case 2:
                    _fileService.DeleteImage(res.ArabVoice2);
                    res.ArabVoice2 = null;
                    _fileService.DeleteImage(res.OtherVoice2);
                    res.OtherVoice2 = null;
                    break;
                case 3:
                    _fileService.DeleteImage(res.ArabVoice3);
                    res.ArabVoice3 = null;
                    _fileService.DeleteImage(res.OtherVoice3);
                    res.OtherVoice3 = null;
                    break;
                case 4:
                    _fileService.DeleteImage(res.ArabVoice4);
                    res.ArabVoice4 = null;
                    _fileService.DeleteImage(res.OtherVoice4);
                    res.OtherVoice4 = null;
                    break;
            }

            
            _dbContext.Words.Update(res);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
