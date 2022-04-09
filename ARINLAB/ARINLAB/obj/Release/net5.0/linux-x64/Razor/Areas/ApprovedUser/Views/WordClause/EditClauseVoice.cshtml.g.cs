#pragma checksum "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82e5bb2d2958a1f53f0e66b956d6e24bccd0f41c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ApprovedUser_Views_WordClause_EditClauseVoice), @"mvc.1.0.view", @"/Areas/ApprovedUser/Views/WordClause/EditClauseVoice.cshtml")]
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
#line 1 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\_ViewImports.cshtml"
using ARINLAB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
using ARINLAB.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
using DAL.Models.Dto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82e5bb2d2958a1f53f0e66b956d6e24bccd0f41c", @"/Areas/ApprovedUser/Views/WordClause/EditClauseVoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5944270c8b5d9816cf52d026e4a62ac0184f904f", @"/Areas/ApprovedUser/Views/_ViewImports.cshtml")]
    public class Areas_ApprovedUser_Views_WordClause_EditClauseVoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AudioFileForClauseDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "ApprovedUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "WordClause", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateVoice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("audio/mpeg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
  
    ViewData["Title"] = "Index";
    string dictName = "";

    EditWordClauseDto m = null;

    if (ViewBag.Model != null)
    {
        m = ((EditWordClauseDto)ViewBag.Model);
    }
    try
    {
        if (ViewBag.Dictionaries != null)
        {
            var getdictName = ((List<DAL.Models.Dictionary>)ViewBag.Dictionaries).SingleOrDefault(p => p.Id == m.DictionaryId);
            dictName = getdictName.Language;
        }
    }catch(Exception e)
            {
                
            }


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>Manage Word Sentences and Audio File (Voice)</h1>\r\n<hr />\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-2\"></div>\r\n        <div class=\"col-4 items-center\">\r\n            <label style=\"font-size:24px; font-weight:600\">");
#nullable restore
#line 35 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
                                                      Write(SharedLocalizer["Arab Clause"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : </label>\r\n            <label class=\"text-success\" style=\"font-size:30px; font-weight:600\">");
#nullable restore
#line 36 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
                                                                           Write(m.ArabClause);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        </div>\r\n        <div class=\" col-4\">\r\n            <label style=\"font-size:24px; font-weight:600\">");
#nullable restore
#line 39 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
                                                      Write(SharedLocalizer["Reads in"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 39 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
                                                                                   Write(dictName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : </label>\r\n            <h2 class=\"text-success\" style=\"font-size:30px; font-weight:600\">");
#nullable restore
#line 40 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
                                                                        Write(m.OtherReader);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        </div>\r\n        <div class=\"col-2\"></div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-2\"></div>\r\n        <div class=\"col-4 items-center\">\r\n            <label style=\"font-size:24px; font-weight:600\">");
#nullable restore
#line 47 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
                                                      Write(dictName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 47 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
                                                                Write(SharedLocalizer["Clause"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : </label>\r\n            <label class=\"text-success\" style=\"font-size:30px; font-weight:600\">");
#nullable restore
#line 48 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
                                                                           Write(m.OtherClause);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        </div>\r\n        <div class=\" col-4\">\r\n            <label style=\"font-size:24px; font-weight:600\">");
#nullable restore
#line 51 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
                                                      Write(SharedLocalizer["Reads in Arab"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : </label>\r\n            <h2 class=\"text-success\" style=\"font-size:30px; font-weight:600\">");
#nullable restore
#line 52 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
                                                                        Write(m.ArabReader);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        </div>\r\n        <div class=\"col-2\"></div>\r\n    </div>\r\n    <hr />\r\n    <div class=\"row\">\r\n        <div class=\"col-8\">\r\n            <h2>");
#nullable restore
#line 59 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
           Write(SharedLocalizer["Voices"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        </div>\r\n        <div class=\"col-4\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82e5bb2d2958a1f53f0e66b956d6e24bccd0f41c10502", async() => {
                WriteLiteral("<button class=\"btn btn-success\"><i class=\"fa fa-plus\"></i></button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
                                                                                              WriteLiteral(m.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
                                                                                                                           WriteLiteral(m.ArabClause);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["arabClause"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-arabClause", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["arabClause"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
                                                                                                                                                                 WriteLiteral(m.OtherClause);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["otherClause"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-otherClause", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["otherClause"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
                                                                                                                                                                                                     WriteLiteral(dictName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["dictName"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-dictName", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["dictName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-12\">\r\n            <table class=\"table table-bordered\">\r\n                <thead>\r\n                    <tr>\r\n                        <th scope=\"col\">");
#nullable restore
#line 71 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
                                   Write(SharedLocalizer["#"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 72 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
                                   Write(SharedLocalizer["Voice in Arab"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 73 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
                                   Write(dictName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 73 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
                                             Write(SharedLocalizer["Voice in "]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 73 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
                                                                           Write(dictName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 74 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
                                   Write(SharedLocalizer["Approved"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">Actions</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 79 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
                     if (Model != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th scope=\"row\">");
#nullable restore
#line 84 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
                                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <td>\r\n                                    <audio");
            BeginWriteAttribute("id", " id=\"", 3359, "\"", 3381, 2);
            WriteAttributeValue("", 3364, "myAudio", 3364, 7, true);
#nullable restore
#line 86 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
WriteAttributeValue("", 3371, item.Id, 3371, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("source", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "82e5bb2d2958a1f53f0e66b956d6e24bccd0f41c19367", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3438, "~/", 3438, 2, true);
#nullable restore
#line 87 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
AddHtmlAttributeValue("", 3440, item.ArabVoice, 3440, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </audio>\r\n                                    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 3566, "\"", 3606, 3);
            WriteAttributeValue("", 3576, "playAudio(\'myAudio", 3576, 18, true);
#nullable restore
#line 89 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
WriteAttributeValue("", 3594, item.Id, 3594, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3604, "\')", 3604, 2, true);
            EndWriteAttribute();
            WriteLiteral(">PLAY</button>\r\n                                    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 3666, "\"", 3707, 3);
            WriteAttributeValue("", 3676, "pauseAudio(\'myAudio", 3676, 19, true);
#nullable restore
#line 90 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
WriteAttributeValue("", 3695, item.Id, 3695, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3705, "\')", 3705, 2, true);
            EndWriteAttribute();
            WriteLiteral(">STOP</button>\r\n                                </td>\r\n                                <td>\r\n                                    <audio");
            BeginWriteAttribute("id", " id=\"", 3843, "\"", 3867, 3);
            WriteAttributeValue("", 3848, "myAudio", 3848, 7, true);
#nullable restore
#line 93 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
WriteAttributeValue("", 3855, item.Id, 3855, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3865, "_o", 3865, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("source", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "82e5bb2d2958a1f53f0e66b956d6e24bccd0f41c22812", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3924, "~/", 3924, 2, true);
#nullable restore
#line 94 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
AddHtmlAttributeValue("", 3926, item.OtherVoice, 3926, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </audio>\r\n                                    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 4053, "\"", 4095, 3);
            WriteAttributeValue("", 4063, "playAudio(\'myAudio", 4063, 18, true);
#nullable restore
#line 96 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
WriteAttributeValue("", 4081, item.Id, 4081, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4091, "_o\')", 4091, 4, true);
            EndWriteAttribute();
            WriteLiteral(">PLAY</button>\r\n                                    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 4155, "\"", 4198, 3);
            WriteAttributeValue("", 4165, "pauseAudio(\'myAudio", 4165, 19, true);
#nullable restore
#line 97 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
WriteAttributeValue("", 4184, item.Id, 4184, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4194, "_o\')", 4194, 4, true);
            EndWriteAttribute();
            WriteLiteral(@">STOP</button>
                                </td>
                                <td>
                                    <div class=""adomx-checkbox-radio-group inline"">
                                        <label class=""adomx-switch success"">
                                            <input");
            BeginWriteAttribute("id", " id=\"", 4505, "\"", 4527, 2);
            WriteAttributeValue("", 4510, "approve", 4510, 7, true);
#nullable restore
#line 102 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
WriteAttributeValue("", 4517, item.Id, 4517, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"checkbox\" ");
#nullable restore
#line 102 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
                                                                                      Write(item.IsApproved ? "checked" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@">

                                            <i class=""lever""></i>
                                        </label>
                                    </div>
                                </td>
                                <td>
                                    <button type=""button""");
            BeginWriteAttribute("id", " id=\"", 4880, "\"", 4895, 1);
#nullable restore
#line 109 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
WriteAttributeValue("", 4885, item.Id, 4885, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 4896, "\"", 4910, 1);
#nullable restore
#line 109 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
WriteAttributeValue("", 4903, m.Id, 4903, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sweetalert sweetalert-clausevoice1 btn button-danger\"><i class=\"fa fa-trash\"></i></button>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 112 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"

                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 113 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 122 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
  
    string text1 = ViewBag.successs;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<button class=\"sweetalert sweetalert-success button button-success\" id=\"AlertButton1\" hidden></button>\r\n");
#nullable restore
#line 127 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
 if (!string.IsNullOrEmpty(text1))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script type=\"text/javascript\">\r\n        window.onload = function () {\r\n            document.getElementById(\"AlertButton1\").click();\r\n        }\r\n    </script>\r\n");
#nullable restore
#line 134 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 136 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
 if (Model != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 138 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            const checkbox");
#nullable restore
#line 141 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
                      Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" = document.getElementById(\'approve");
#nullable restore
#line 141 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
                                                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\')\r\n            checkbox");
#nullable restore
#line 142 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
                Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(".addEventListener(\'change\', (event) => {\r\n                if (event.currentTarget.checked) {\r\n                    window.location.href = \"/ApprovedUser/WordClause/Approve/");
#nullable restore
#line 144 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
                                                                        Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("/true/");
#nullable restore
#line 144 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
                                                                                      Write(m.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n                } else {\r\n                    window.location.href = \"/ApprovedUser/WordClause/Approve/");
#nullable restore
#line 146 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
                                                                        Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("/false/");
#nullable restore
#line 146 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
                                                                                       Write(m.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n                }\r\n            })\r\n        </script>\r\n");
#nullable restore
#line 150 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 150 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\WordClause\EditClauseVoice.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script>\r\n\r\n    function playAudio(id) {\r\n\r\n        var x = document.getElementById(id);\r\n        x.play();\r\n    }\r\n\r\n    function pauseAudio(id) {\r\n\r\n        var x = document.getElementById(id);\r\n        x.pause();\r\n    }\r\n\r\n</script>");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AudioFileForClauseDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
