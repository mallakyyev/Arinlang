#pragma checksum "C:\Users\User\Arinlang\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d20d90d20eeccfa1c3e7cc0165c7c248faf5729"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WordClauses_Details), @"mvc.1.0.view", @"/Views/WordClauses/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\User\Arinlang\ARINLAB\ARINLAB\Views\_ViewImports.cshtml"
using ARINLAB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\User\Arinlang\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Arinlang\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
using ARINLAB.Areas.Admin.Utils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Arinlang\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
using DAL.Models.Dto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Arinlang\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Arinlang\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
using ARINLAB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d20d90d20eeccfa1c3e7cc0165c7c248faf5729", @"/Views/WordClauses/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e119a08238c3c4a5c8eaf5a5256788f2de43111b", @"/Views/_ViewImports.cshtml")]
    public class Views_WordClauses_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DAL.Models.Dto.AudioFileForClauseDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Icons/Bug.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Icons/Print.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Icons/Copy_link.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Icons/Share_black.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Icons/Eye.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding-right: 10px; margin-left: 40px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Icons/Voice_L.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding-left: 10px; padding-right: 40px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Icons/Voice_R.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 10 "C:\Users\User\Arinlang\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
  
    string dictName = "";
    ViewData["Title"] = "Index";
    EditWordClauseDto m = null;
    bool ress = false;
    if (ViewBag.RatingResult != null)
        ress = (bool)(ViewBag.RatingResult);
    if (ViewBag.Model != null)
    {
        m = ((EditWordClauseDto)ViewBag.Model);
    }
    try
    {
        if (ViewBag.Dictionaries != null)
        {
            var getdictName = ((List<DAL.Models.Dictionary>)ViewBag.Dictionaries).SingleOrDefault(p => p.Id == m.DictionaryId);
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            if (culture == "ar")
                dictName = getdictName.ArabTranslate;
            else
                dictName = getdictName.Language;
        }
    }
    catch (Exception e)
    {

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\User\Arinlang\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
Write(await Component.InvokeAsync("OtherMenu"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 41 "C:\Users\User\Arinlang\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
 if (CultureInfo.CurrentCulture.Name.StartsWith("ar"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div  class=\"container flex flex-row justify-between\" style=\" padding-left: 25px; padding-right: 25px; width: 700px; margin-top: 70px;\">\r\n    <div class=\"flex justify-between\" style=\"width: 140px;\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 1453, "\"", 1460, 0);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d20d90d20eeccfa1c3e7cc0165c7c248faf57298940", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 1512, "\"", 1519, 0);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d20d90d20eeccfa1c3e7cc0165c7c248faf572910126", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 1573, "\"", 1580, 0);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d20d90d20eeccfa1c3e7cc0165c7c248faf572911313", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 1638, "\"", 1645, 0);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d20d90d20eeccfa1c3e7cc0165c7c248faf572912500", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>           \r\n    </div>\r\n    <div class=\"flex justify-between align-center\" style=\"width: 220px;\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 1803, "\"", 1810, 0);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d20d90d20eeccfa1c3e7cc0165c7c248faf572913793", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
        <small style=""margin-right: 15px;"">16879</small>
        <div>
            <img style=""width: 22px; height: 24px;"" src=""https://img.icons8.com/color/48/000000/filled-star--v1.png""/>
            <img style=""width: 22px; height: 24px;"" src=""https://img.icons8.com/color/48/000000/filled-star--v1.png""/>
            <img style=""width: 22px; height: 24px;"" src=""https://img.icons8.com/color/48/000000/filled-star--v1.png""/>
            <img style=""width: 22px; height: 24px;"" src=""https://img.icons8.com/color/48/000000/filled-star--v1.png""/>
            <img style=""width: 22px; height: 24px;"" src=""https://img.icons8.com/color/48/000000/filled-star--v1.png""/>
        </div>
    </div>
</div>
<div class=""container"" style=""width: 700px; padding-top: 20px; padding-bottom: 30px; margin-top: 20px; margin-bottom: 50px; border: 1px solid silver; border-radius: 9px; font-size: 18px;"">
    <div class=""wrapper"">
        <div class=""justify-between flex flex-row px-5 bg-gray-100"" style=""padding-top: 10px");
            WriteLiteral(@"; padding-bottom: 10px; padding-left: 40px; padding-right: 40px;"">
            <h3 style=""font-weight: bold;"">Word in Turkmen:</h3>
            <h3 style=""font-weight: bold;"">Word in Arabic:</h3>
        </div>
        <div class=""justify-between flex flex-row px-5"" style=""margin-top: 20px;"">
            <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d20d90d20eeccfa1c3e7cc0165c7c248faf572916232", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" Mugallym</p>\r\n            <p>Moallem ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d20d90d20eeccfa1c3e7cc0165c7c248faf572917383", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</p>
        </div>
        <div class=""justify-between flex flex-row px-5 bg-gray-100""style=""margin-top: 20px; padding-left: 40px; padding-right: 40px;"">
            <h3 style=""font-weight: bold;"">Sentence in Turkmen:</h3>
            <h3 style=""font-weight: bold;"">Sentence in Arabic:</h3>
        </div>
        <div class=""justify-between flex flex-row px-5"" style=""margin-top: 20px;"">
            <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d20d90d20eeccfa1c3e7cc0165c7c248faf572918919", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("Mugallym cagalara owredyar</p>\r\n            <p>Muallim yualimu aletfale");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d20d90d20eeccfa1c3e7cc0165c7c248faf572920103", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</p>
        </div>
        <div class=""justify-between flex flex-row px-5"" style=""margin-top: 20px; padding-left: 40px; padding-right: 40px;"">
            <h3 style=""font-weight: bold;"">Transcription in Arabic:</h3>
            <h3 style=""font-weight: bold;"">Transcription in Turkmen:</h3>
        </div>
        <div class=""justify-between flex flex-row px-2"" style=""margin-top: 20px; margin-left: 40px; margin-right: 40px; border-bottom: 1px solid silver; padding-bottom: 10px; paddding-left: 40px; padding-right: 40px;"">
            <p>Mugallym cagalary okadyar</p>
            <p>Muallim yualimu aletfale</p>
        </div>
    </div>
</div>
");
#nullable restore
#line 167 "C:\Users\User\Arinlang\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
             
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div  class=\"container flex flex-row justify-between\" style=\" padding-left: 25px; padding-right: 25px; width: 700px; margin-top: 70px;\">\r\n    <div class=\"flex justify-between\" style=\"width: 140px;\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 9689, "\"", 9696, 0);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d20d90d20eeccfa1c3e7cc0165c7c248faf572922465", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 9748, "\"", 9755, 0);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d20d90d20eeccfa1c3e7cc0165c7c248faf572923652", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 9809, "\"", 9816, 0);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d20d90d20eeccfa1c3e7cc0165c7c248faf572924839", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 9874, "\"", 9881, 0);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d20d90d20eeccfa1c3e7cc0165c7c248faf572926026", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>           \r\n    </div>\r\n    <div class=\"flex justify-between align-center\" style=\"width: 220px;\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 10039, "\"", 10046, 0);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d20d90d20eeccfa1c3e7cc0165c7c248faf572927321", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
        <small style=""margin-right: 15px;"">16879</small>
        <div>
            <img style=""width: 22px; height: 24px;"" src=""https://img.icons8.com/color/48/000000/filled-star--v1.png""/>
            <img style=""width: 22px; height: 24px;"" src=""https://img.icons8.com/color/48/000000/filled-star--v1.png""/>
            <img style=""width: 22px; height: 24px;"" src=""https://img.icons8.com/color/48/000000/filled-star--v1.png""/>
            <img style=""width: 22px; height: 24px;"" src=""https://img.icons8.com/color/48/000000/filled-star--v1.png""/>
            <img style=""width: 22px; height: 24px;"" src=""https://img.icons8.com/color/48/000000/filled-star--v1.png""/>
        </div>
    </div>
</div>
<div class=""container"" style=""width: 700px; padding-top: 20px; padding-bottom: 30px; margin-top: 20px; margin-bottom: 50px; border: 1px solid silver; border-radius: 9px; font-size: 18px;"">
    <div class=""wrapper"">
        <div class=""justify-between flex flex-row px-5 bg-gray-100"" style=""padding-top: 10px");
            WriteLiteral(@"; padding-bottom: 10px; padding-left: 40px; padding-right: 40px;"">
            <h3 style=""font-weight: bold;"">Word in Turkmen:</h3>
            <h3 style=""font-weight: bold;"">Word in Arabic:</h3>
        </div>
        <div class=""justify-between flex flex-row px-5"" style=""margin-top: 20px;"">
            <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d20d90d20eeccfa1c3e7cc0165c7c248faf572929760", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" Mugallym</p>\r\n            <p>Moallem ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d20d90d20eeccfa1c3e7cc0165c7c248faf572930911", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</p>
        </div>
        <div class=""justify-between flex flex-row px-5 bg-gray-100""style=""margin-top: 20px; padding-left: 40px; padding-right: 40px;"">
            <h3 style=""font-weight: bold;"">Sentence in Turkmen:</h3>
            <h3 style=""font-weight: bold;"">Sentence in Arabic:</h3>
        </div>
        <div class=""justify-between flex flex-row px-5"" style=""margin-top: 20px;"">
            <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d20d90d20eeccfa1c3e7cc0165c7c248faf572932447", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("Mugallym cagalara owredyar</p>\r\n            <p>Muallim yualimu aletfale");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d20d90d20eeccfa1c3e7cc0165c7c248faf572933631", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</p>
        </div>
        <div class=""justify-between flex flex-row px-5"" style=""margin-top: 20px; padding-left: 40px; padding-right: 40px;"">
            <h3 style=""font-weight: bold;"">Transcription in Arabic:</h3>
            <h3 style=""font-weight: bold;"">Transcription in Turkmen:</h3>
        </div>
        <div class=""justify-between flex flex-row px-2"" style=""margin-top: 20px; margin-left: 40px; margin-right: 40px; border-bottom: 1px solid silver; padding-bottom: 10px; paddding-left: 40px; padding-right: 40px;"">
            <p>Mugallym cagalary okadyar</p>
            <p>Muallim yualimu aletfale</p>
        </div>
    </div>
</div>
");
#nullable restore
#line 297 "C:\Users\User\Arinlang\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
             

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<button id=\"btn\" hidden></button>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <!-- <script src=""https://cdn.jsdelivr.net/npm/simple-notify@0.5.4/dist/simple-notify.min.js""></script> -->
    <script async defer src=""https://buttons.github.io/buttons.js""></script>
    <!-- <script src=""https://cdn.jsdelivr.net/npm/simple-notify@0.5.4/dist/simple-notify.min.js""></script> -->
    <script src=""/dist/simple-notify.min.js""></script>
    <script src=""/assets/js/prism.js""></script>
    <script src=""/assets/js/OverlayScrollbars.min.js""></script>
    <script src=""/assets/js/main.js""></script>
    <script>
         const btn = document.querySelector('#btn')

        btn.addEventListener('click', () => {
            new Notify({
                status: 'success',
                title: '");
#nullable restore
#line 316 "C:\Users\User\Arinlang\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
                   Write(SharedLocalizer["Thank you"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                text: \'");
#nullable restore
#line 317 "C:\Users\User\Arinlang\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
                  Write(SharedLocalizer["Your rating have been successfully recorded"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                effect: 'fade',
                speed: 300,
                customClass: '',
                customIcon: '',
                showIcon: true,
                showCloseButton: true,
                autoclose: false,
                autotimeout: 3000,
                gap: 60,
                distance: 20,
                type: 1,
                position: 'right top',
                customWrapper: '',
            })
        });

    function playAudio(id) {

        var x = document.getElementById(id);
        x.play();
    }

    function pauseAudio(id) {

        var x = document.getElementById(id);
        x.pause();
    }
    </script>
");
#nullable restore
#line 346 "C:\Users\User\Arinlang\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
     if (ress)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script>\r\n            document.getElementById(\"btn\").click();\r\n        </script>\r\n");
#nullable restore
#line 351 "C:\Users\User\Arinlang\ARINLAB\ARINLAB\Views\WordClauses\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHtmlLocalizer<SharedResource> SharedLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DAL.Models.Dto.AudioFileForClauseDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
