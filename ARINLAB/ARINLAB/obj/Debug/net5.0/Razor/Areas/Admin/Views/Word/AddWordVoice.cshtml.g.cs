#pragma checksum "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\AddWordVoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c076068ded55795d5f4c1562ac53a5633bbec72f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Word_AddWordVoice), @"mvc.1.0.view", @"/Areas/Admin/Views/Word/AddWordVoice.cshtml")]
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
#line 5 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\AddWordVoice.cshtml"
using ARINLAB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c076068ded55795d5f4c1562ac53a5633bbec72f", @"/Areas/Admin/Views/Word/AddWordVoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5944270c8b5d9816cf52d026e4a62ac0184f904f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Word_AddWordVoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimpleWordVoiceModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "file", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Word", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddWordVoice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\AddWordVoice.cshtml"
  
    ViewData["Title"] = "Index";


#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\AddWordVoice.cshtml"
  
    SimpleWordVoiceModel mod = (SimpleWordVoiceModel)ViewBag.model;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Add  Voice </h1>\r\n<hr />\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-2\"></div>\r\n        <div class=\"col-4 items-center\">\r\n\r\n            <label class=\"text-success\" style=\"font-size:30px; font-weight:600\">");
#nullable restore
#line 17 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\AddWordVoice.cshtml"
                                                                           Write(mod.ArabWord);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        </div>\r\n        <div class=\" col-4\">\r\n\r\n            <h2 class=\"text-success\" style=\"font-size:30px; font-weight:600\">");
#nullable restore
#line 21 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\AddWordVoice.cshtml"
                                                                        Write(mod.OtherWord);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        </div>\r\n        <div class=\"col-2\"></div>\r\n    </div>\r\n    <hr />\r\n    <div class=\"col-12 mb-30\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c076068ded55795d5f4c1562ac53a5633bbec72f7787", async() => {
                WriteLiteral("\r\n            <div class=\"box\">\r\n                <div class=\"box-head\">\r\n                    <h3 class=\"title\">");
#nullable restore
#line 30 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\AddWordVoice.cshtml"
                                 Write(SharedLocalizer["Add Word Voices"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                </div>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c076068ded55795d5f4c1562ac53a5633bbec72f8478", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 32 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\AddWordVoice.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\AddWordVoice.cshtml"
                                             WriteLiteral(mod.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <div class=\"box-body\">\r\n                    <div class=\"row mbn-20\">\r\n\r\n                        <!--Form Field-->\r\n                        <div class=\"col-lg-6 col-12 mb-20\">\r\n\r\n                            <h6 class=\"mb-15\">");
#nullable restore
#line 39 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\AddWordVoice.cshtml"
                                         Write(SharedLocalizer["Arab"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n\r\n                            <div class=\"row mbn-15\">\r\n                                <label class=\"label\">");
#nullable restore
#line 42 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\AddWordVoice.cshtml"
                                                Write(SharedLocalizer["Upload Voice file"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c076068ded55795d5f4c1562ac53a5633bbec72f11810", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 43 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\AddWordVoice.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ArabVoice);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </div>

                        </div>
                        <!--Form Field-->
                        <!--Readonly Field-->
                        <div class=""col-lg-6 col-12 mb-20"">

                            <h6 class=""mb-15"">");
#nullable restore
#line 51 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\AddWordVoice.cshtml"
                                         Write(mod.DictID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n\r\n                            <div class=\"row mbn-15\">\r\n                                <label class=\"label\">");
#nullable restore
#line 54 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\AddWordVoice.cshtml"
                                                Write(SharedLocalizer["Upload Voice file"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c076068ded55795d5f4c1562ac53a5633bbec72f14561", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 55 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\AddWordVoice.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.OtherVoice);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n                </div>\r\n                <div class=\"box-foot items-end\">\r\n                    <input type=\"submit\" class=\"btn btn-success\"");
                BeginWriteAttribute("value", " value=\"", 2353, "\"", 2384, 1);
#nullable restore
#line 62 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\AddWordVoice.cshtml"
WriteAttributeValue("", 2361, SharedLocalizer["Add"], 2361, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></input>\r\n                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 68 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\AddWordVoice.cshtml"
  
    string text = ViewBag.Error;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<button class=\"sweetalert sweetalert-error button button-danger\" id=\"AlertButton\" hidden></button>\r\n");
#nullable restore
#line 73 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\AddWordVoice.cshtml"
 if (!string.IsNullOrEmpty(text))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script type=\"text/javascript\">\r\n        window.onload = function () {\r\n            document.getElementById(\"AlertButton\").click();\r\n        }\r\n    </script>\r\n");
#nullable restore
#line 80 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Word\AddWordVoice.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimpleWordVoiceModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
