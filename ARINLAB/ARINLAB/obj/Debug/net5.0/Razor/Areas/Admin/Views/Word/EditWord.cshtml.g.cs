#pragma checksum "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15e7fee806cdc47a98f41a6fa0d742dff9134663"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Word_EditWord), @"mvc.1.0.view", @"/Areas/Admin/Views/Word/EditWord.cshtml")]
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
#line 6 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
using ARINLAB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15e7fee806cdc47a98f41a6fa0d742dff9134663", @"/Areas/Admin/Views/Word/EditWord.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5944270c8b5d9816cf52d026e4a62ac0184f904f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Word_EditWord : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WordSentencesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Word", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddWordSentence", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditWordSentence", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
  
    ViewData["Title"] = "Index";



#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
  
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
            WriteLiteral(@"
<h1>Manage Word Sentences and Audio File (Voice)</h1>
<hr />
<div class=""container"">
    <div class=""row"">
        <div class=""col-2""></div>
        <div class=""col-4 items-center"">
            <label style=""font-size:24px; font-weight:600"">Arab Word : </label>
            <label class=""text-success"" style=""font-size:30px; font-weight:600"">");
#nullable restore
#line 27 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
                                                                           Write(Model.Word.ArabWord);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        </div>\r\n        <div class=\" col-4\">\r\n            <label style=\"font-size:24px; font-weight:600\">");
#nullable restore
#line 30 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
                                                      Write(dictName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Word : </label>\r\n            <h2 class=\"text-success\" style=\"font-size:30px; font-weight:600\">");
#nullable restore
#line 31 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
                                                                        Write(Model.Word.OtherWord);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        </div>\r\n        <div class=\"col-2\"></div>\r\n    </div>\r\n    <hr />\r\n    <div class=\"row\">\r\n        <div class=\"col-8\">\r\n            <h2>");
#nullable restore
#line 38 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
           Write(SharedLocalizer["Sentences related to the word"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        </div>\r\n        <div class=\"col-4\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15e7fee806cdc47a98f41a6fa0d742dff91346637159", async() => {
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
#line 41 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
                                                                                     WriteLiteral(Model.Word.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
                                                                                                                         WriteLiteral(Model.Word.ArabWord);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["arabWord"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-arabWord", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["arabWord"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
                                                                                                                                                                    WriteLiteral(Model.Word.OtherWord);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["otherWord"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-otherWord", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["otherWord"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
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
#line 50 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
                                   Write(SharedLocalizer["#"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 51 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
                                   Write(SharedLocalizer["Arab sentence"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 52 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
                                   Write(SharedLocalizer["Transcription"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                        <th scope=\"col\">");
#nullable restore
#line 54 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
                                   Write(dictName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 54 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
                                             Write(SharedLocalizer["sentence"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 55 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
                                   Write(SharedLocalizer["Transcription"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 56 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
                                   Write(SharedLocalizer["Approved"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"col\">Actions</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 61 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
                     if (Model != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
                         foreach (var item in Model.WordSentences)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th scope=\"row\">");
#nullable restore
#line 66 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
                                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <td>");
#nullable restore
#line 67 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
                               Write(item.ArabSentence);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 68 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
                               Write(item.ArabReader);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 69 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
                               Write(item.OtherSentence);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 70 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
                               Write(item.OtherReader);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                <td>
                                    <div class=""adomx-checkbox-radio-group inline"">
                                        <label class=""adomx-switch success"">
                                            <input");
            BeginWriteAttribute("id", " id=\"", 3048, "\"", 3070, 2);
            WriteAttributeValue("", 3053, "approve", 3053, 7, true);
#nullable restore
#line 74 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
WriteAttributeValue("", 3060, item.Id, 3060, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"checkbox\" ");
#nullable restore
#line 74 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
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
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15e7fee806cdc47a98f41a6fa0d742dff913466317995", async() => {
                WriteLiteral("<button type=\"button\" class=\"btn btn-success\"><i class=\"fa fa-edit\"></i></button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
                                                                                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
                                                                                                                                            WriteLiteral(Model.Word.ArabWord);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["arabWord"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-arabWord", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["arabWord"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
                                                                                                                                                                                       WriteLiteral(Model.Word.OtherWord);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["otherWord"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-otherWord", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["otherWord"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
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
            WriteLiteral("\r\n                                    <button type=\"button\"");
            BeginWriteAttribute("id", " id=\"", 3791, "\"", 3806, 1);
#nullable restore
#line 81 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
WriteAttributeValue("", 3796, item.Id, 3796, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sweetalert delete-sentence btn button-danger\"><i class=\"fa fa-trash\"></i></button>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 84 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"

                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 94 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
 if (Model != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
     foreach (var item in Model.WordSentences)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            const checkbox");
#nullable restore
#line 99 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
                      Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" = document.getElementById(\'approve");
#nullable restore
#line 99 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
                                                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\')\r\n            checkbox");
#nullable restore
#line 100 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
                Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(".addEventListener(\'change\', (event) => {\r\n                if (event.currentTarget.checked) {\r\n                    window.location.href = \"/Admin/Word/Sentence/");
#nullable restore
#line 102 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
                                                            Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("/true\";\r\n                } else {\r\n                    window.location.href = \"/Admin/Word/Sentence/");
#nullable restore
#line 104 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
                                                            Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("/false\";\r\n                }\r\n            })\r\n        </script>\r\n");
#nullable restore
#line 108 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 111 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
  
    string text = ViewBag.text;    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<button class=\"sweetalert sweetalert-success button button-success\" id=\"AlertButton\" hidden></button>\r\n");
#nullable restore
#line 116 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
 if(!string.IsNullOrEmpty(text))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script type=\"text/javascript\">\r\n        window.onload = function () {\r\n            document.getElementById(\"AlertButton\").click();\r\n        }\r\n    </script>\r\n");
#nullable restore
#line 123 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\EditWord.cshtml"
}

#line default
#line hidden
#nullable disable
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
