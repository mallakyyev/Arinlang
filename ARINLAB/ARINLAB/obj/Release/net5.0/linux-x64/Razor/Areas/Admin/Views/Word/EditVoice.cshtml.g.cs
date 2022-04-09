#pragma checksum "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditVoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72dc60b8b85d7ce5159b2d2353afd690730a3165"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Word_EditVoice), @"mvc.1.0.view", @"/Areas/Admin/Views/Word/EditVoice.cshtml")]
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
#line 1 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\_ViewImports.cshtml"
using ARINLAB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditVoice.cshtml"
using ARINLAB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72dc60b8b85d7ce5159b2d2353afd690730a3165", @"/Areas/Admin/Views/Word/EditVoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5944270c8b5d9816cf52d026e4a62ac0184f904f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Word_EditVoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WordSentencesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Word", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddWordVoice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditVoice.cshtml"
  
    ViewData["Title"] = "Index";



#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditVoice.cshtml"
  
    string dictName = "Error";
    try
    {
        dictName = (new List<DAL.Models.Dictionary>(ViewBag.dict)).Find(p => p.Id == Model.Word.DictionaryId).Language;
    }
    catch (Exception e)
    {
        dictName = "Error";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Manage Word Sentences and Audio File (Voice)</h1>\r\n<hr />\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-2\"></div>\r\n        <div class=\"col-4 items-center\">\r\n            <label style=\"font-size:24px; font-weight:600\">");
#nullable restore
#line 26 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditVoice.cshtml"
                                                      Write(SharedLocalizer["Arab Word"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : </label>\r\n            <label class=\"text-success\" style=\"font-size:30px; font-weight:600\">");
#nullable restore
#line 27 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditVoice.cshtml"
                                                                           Write(Model.Word.ArabWord);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        </div>\r\n        <div class=\" col-4\">\r\n            <label style=\"font-size:24px; font-weight:600\">");
#nullable restore
#line 30 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditVoice.cshtml"
                                                      Write(dictName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 30 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditVoice.cshtml"
                                                                Write(SharedLocalizer["Word"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : </label>\r\n            <h2 class=\"text-success\" style=\"font-size:30px; font-weight:600\">");
#nullable restore
#line 31 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditVoice.cshtml"
                                                                        Write(Model.Word.OtherWord);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        </div>\r\n        <div class=\"col-2\"></div>\r\n    </div>\r\n    <hr />\r\n    <div class=\"row\">\r\n        <div class=\"col-8\">\r\n            <h2>");
#nullable restore
#line 38 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditVoice.cshtml"
           Write(SharedLocalizer["Voices Related to the Word"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        </div>\r\n        <div class=\"col-4\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72dc60b8b85d7ce5159b2d2353afd690730a31657910", async() => {
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
#line 41 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditVoice.cshtml"
                                                                                  WriteLiteral(Model.Word.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditVoice.cshtml"
                                                                                                                      WriteLiteral(Model.Word.ArabWord);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["arabWord"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-arabWord", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["arabWord"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditVoice.cshtml"
                                                                                                                                                                 WriteLiteral(Model.Word.OtherWord);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["otherWord"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-otherWord", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["otherWord"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditVoice.cshtml"
                                                                                                                                                                                                          WriteLiteral(dictName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["dictId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-dictId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["dictId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-12\">\r\n            <table class=\"table table-bordered\">\r\n                <thead>\r\n                    <tr>\r\n                        <th scope=\"col\">");
#nullable restore
#line 50 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditVoice.cshtml"
                                   Write(SharedLocalizer["#"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 51 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditVoice.cshtml"
                                   Write(SharedLocalizer["Arab Voice"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 52 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditVoice.cshtml"
                                   Write(dictName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 52 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditVoice.cshtml"
                                             Write(SharedLocalizer["Voice"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">Actions</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 57 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditVoice.cshtml"
                     if (Model != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 60 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditVoice.cshtml"
                                       Write(Model.Word.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>\r\n                                <audio");
            BeginWriteAttribute("id", " id=\"", 2321, "\"", 2350, 2);
            WriteAttributeValue("", 2326, "myAudio", 2326, 7, true);
#nullable restore
#line 62 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditVoice.cshtml"
WriteAttributeValue("", 2333, @Model.Word.Id, 2333, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("source", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "72dc60b8b85d7ce5159b2d2353afd690730a316515653", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2403, "~/", 2403, 2, true);
#nullable restore
#line 63 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditVoice.cshtml"
AddHtmlAttributeValue("", 2405, Model.Word.ArabVoice, 2405, 21, false);

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
            WriteLiteral("\r\n                                </audio>\r\n                                <button");
            BeginWriteAttribute("onclick", " onclick=\"", 2529, "\"", 2575, 3);
            WriteAttributeValue("", 2539, "playAudio(\'myAudio", 2539, 18, true);
#nullable restore
#line 65 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditVoice.cshtml"
WriteAttributeValue("", 2557, Model.Word.Id, 2557, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2573, "\')", 2573, 2, true);
            EndWriteAttribute();
            WriteLiteral(">PLAY</button>\r\n                                <button");
            BeginWriteAttribute("onclick", " onclick=\"", 2631, "\"", 2678, 3);
            WriteAttributeValue("", 2641, "pauseAudio(\'myAudio", 2641, 19, true);
#nullable restore
#line 66 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditVoice.cshtml"
WriteAttributeValue("", 2660, Model.Word.Id, 2660, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2676, "\')", 2676, 2, true);
            EndWriteAttribute();
            WriteLiteral(">STOP</button>\r\n                            </td>\r\n                            <td>\r\n                                <audio");
            BeginWriteAttribute("id", " id=\"", 2802, "\"", 2832, 3);
            WriteAttributeValue("", 2807, "myAudio", 2807, 7, true);
#nullable restore
#line 69 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditVoice.cshtml"
WriteAttributeValue("", 2814, Model.Word.Id, 2814, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2830, "_o", 2830, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("source", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "72dc60b8b85d7ce5159b2d2353afd690730a316519018", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2885, "~/", 2885, 2, true);
#nullable restore
#line 70 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditVoice.cshtml"
AddHtmlAttributeValue("", 2887, Model.Word.OtherVoice, 2887, 22, false);

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
            WriteLiteral("\r\n                                </audio>\r\n                                <button");
            BeginWriteAttribute("onclick", " onclick=\"", 3012, "\"", 3060, 3);
            WriteAttributeValue("", 3022, "playAudio(\'myAudio", 3022, 18, true);
#nullable restore
#line 72 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditVoice.cshtml"
WriteAttributeValue("", 3040, Model.Word.Id, 3040, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3056, "_o\')", 3056, 4, true);
            EndWriteAttribute();
            WriteLiteral(">PLAY</button>\r\n                                <button");
            BeginWriteAttribute("onclick", " onclick=\"", 3116, "\"", 3165, 3);
            WriteAttributeValue("", 3126, "pauseAudio(\'myAudio", 3126, 19, true);
#nullable restore
#line 73 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditVoice.cshtml"
WriteAttributeValue("", 3145, Model.Word.Id, 3145, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3161, "_o\')", 3161, 4, true);
            EndWriteAttribute();
            WriteLiteral(">STOP</button>\r\n                            </td>\r\n\r\n                            <td>\r\n                                <button type=\"button\"");
            BeginWriteAttribute("id", " id=\"", 3306, "\"", 3327, 1);
#nullable restore
#line 77 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditVoice.cshtml"
WriteAttributeValue("", 3311, Model.Word.Id, 3311, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 3328, "\"", 3351, 1);
#nullable restore
#line 77 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditVoice.cshtml"
WriteAttributeValue("", 3335, Model.Word.Id, 3335, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sweetalert delete-voice1 btn button-danger\"><i class=\"fa fa-trash\"></i></button>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 80 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditVoice.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 89 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditVoice.cshtml"
  
    string text1 = ViewBag.successs;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<button class=\"sweetalert sweetalert-success button button-success\" id=\"AlertButton1\" hidden></button>\r\n");
#nullable restore
#line 94 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditVoice.cshtml"
 if(!string.IsNullOrEmpty(text1))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script type=\"text/javascript\">\r\n        window.onload = function () {\r\n            document.getElementById(\"AlertButton1\").click();\r\n        }\r\n    </script>\r\n");
#nullable restore
#line 101 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditVoice.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script>\r\n  \r\n    function playAudio(id) {\r\n       \r\n        var x = document.getElementById(id);\r\n        x.play();\r\n    }\r\n\r\n    function pauseAudio(id) {\r\n       \r\n        var x = document.getElementById(id);\r\n        x.pause();\r\n}\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WordSentencesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
