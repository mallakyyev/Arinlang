#pragma checksum "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Pages\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e1fbd1dccd708db08ad5b00bd479959e646d7e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Pages_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/Pages/Create.cshtml")]
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
#line 2 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\_ViewImports.cshtml"
using ARINLAB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Pages\Create.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Pages\Create.cshtml"
using DAL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e1fbd1dccd708db08ad5b00bd479959e646d7e3", @"/Areas/Admin/Views/Pages/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5944270c8b5d9816cf52d026e4a62ac0184f904f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Pages_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DAL.Models.Dto.MenuModelDTO.CreatePagesDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/CustomStore.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Pages\Create.cshtml"
  
    ViewData["Title"] = SharedLocalizer["Create page"];
    int lngIndex = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n            <h1 class=\"page-header\">\r\n                ");
#nullable restore
#line 16 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Pages\Create.cshtml"
           Write(SharedLocalizer["Create page"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h1>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div id=\"gridContainer\">\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e1fbd1dccd708db08ad5b00bd479959e646d7e36475", async() => {
                WriteLiteral("\r\n                <div class=\"col-md-12\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e1fbd1dccd708db08ad5b00bd479959e646d7e36798", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 26 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Pages\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                    <div class=\"form-row\">\r\n                        <div class=\"col-md-12\">\r\n");
#nullable restore
#line 30 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Pages\Create.cshtml"
                             foreach (LanguageDto languageDTO in ViewBag.Languages)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <h3>");
#nullable restore
#line 32 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Pages\Create.cshtml"
                               Write(languageDTO.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                                <hr />\r\n                                <input type=\"hidden\" class=\"form-control\"");
                BeginWriteAttribute("name", " name=\"", 1166, "\"", 1215, 3);
                WriteAttributeValue("", 1173, "PagesTranslates[", 1173, 16, true);
#nullable restore
#line 34 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Pages\Create.cshtml"
WriteAttributeValue("", 1189, lngIndex, 1189, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1198, "].LanguageCulture", 1198, 17, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1216, "\"", 1244, 1);
#nullable restore
#line 34 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Pages\Create.cshtml"
WriteAttributeValue("", 1224, languageDTO.Culture, 1224, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <div class=\"form-group\">\r\n                                    <label>");
#nullable restore
#line 36 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Pages\Create.cshtml"
                                      Write(SharedLocalizer["Name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" *</label>\r\n                                    <div");
                BeginWriteAttribute("id", " id=\"", 1427, "\"", 1454, 2);
                WriteAttributeValue("", 1432, "product-name-", 1432, 13, true);
#nullable restore
#line 37 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Pages\Create.cshtml"
WriteAttributeValue("", 1445, lngIndex, 1445, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></div>\r\n");
                WriteLiteral("                                </div>\r\n                                <div class=\"form-group\">\r\n                                    <label>");
#nullable restore
#line 41 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Pages\Create.cshtml"
                                      Write(SharedLocalizer["Description"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" *</label>\r\n");
                WriteLiteral("                                    <div");
                BeginWriteAttribute("id", " id=\"", 1983, "\"", 2016, 2);
                WriteAttributeValue("", 1988, "description-editor-", 1988, 19, true);
#nullable restore
#line 43 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Pages\Create.cshtml"
WriteAttributeValue("", 2007, lngIndex, 2007, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></div>\r\n                                </div>\r\n                                <script>\r\n                                    $(function () {\r\n                                        $(\"#product-name-");
#nullable restore
#line 47 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Pages\Create.cshtml"
                                                    Write(lngIndex);

#line default
#line hidden
#nullable disable
                WriteLiteral("\").dxTextBox({\r\n                                            name: \"PagesTranslates[");
#nullable restore
#line 48 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Pages\Create.cshtml"
                                                              Write(lngIndex);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"].Name""
                                        }).dxValidator({
                                            validationRules: [{
                                                type: ""required"",
                                                message: '");
#nullable restore
#line 52 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Pages\Create.cshtml"
                                                     Write(SharedLocalizer["Enter name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n                                            }]\r\n                                        });\r\n\r\n                                        $(\"#description-editor-");
#nullable restore
#line 56 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Pages\Create.cshtml"
                                                          Write(lngIndex);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""").dxHtmlEditor({
                                            height: 250,
                                            toolbar: {
                                                items: [
                                                    ""undo"", ""redo"", ""separator"",
                                                    {
                                                        formatName: ""header"",
                                                        formatValues: [false, 1, 2, 3, 4, 5]
                                                    },
                                                    {
                                                        formatName: ""size"",
                                                        formatValues: [""8pt"", ""10pt"", ""12pt"", ""14pt"", ""18pt"", ""24pt"", ""36pt""]
                                                    },
                                                        ""bold"", ""italic"", ""strike"", ""underline"", ""separator"",
                                         ");
                WriteLiteral(@"                    ""alignLeft"", ""alignCenter"", ""alignRight"", ""alignJustify"", ""separator"",
                                                              ""orderedList"", ""bulletList"", ""separator"",
                                                              ""color"", ""background"", ""separator"",
                                                               ""link"", ""image"", ""separator"",
                                                               ""clear"", ""codeBlock"", ""blockquote"",
                                                    {
                                                        widget: ""dxButton"",
                                                        options: {
                                                            text: ""Show markup"",
                                                            stylingMode: ""text"",
                                                            onClick: function () {
                                                                popupInstance.show();");
                WriteLiteral(@"
                                                            }
                                                        }
                                                    }
                                                ]
                                            },
                                            name: `PagesTranslates[");
#nullable restore
#line 87 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Pages\Create.cshtml"
                                                              Write(lngIndex);

#line default
#line hidden
#nullable disable
                WriteLiteral("].Description`,\r\n                                        }).dxHtmlEditor(\"instance\");\r\n                                    });\r\n                                </script>\r\n");
#nullable restore
#line 91 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Pages\Create.cshtml"


                                lngIndex++;
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-12\">\r\n                            <h2>");
#nullable restore
#line 98 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Pages\Create.cshtml"
                           Write(SharedLocalizer["Data"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                            <hr />\r\n                            <div class=\"form-group\">\r\n                                <label>");
#nullable restore
#line 101 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Pages\Create.cshtml"
                                  Write(SharedLocalizer["Menu to assign"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                <div id=\"menuSelection\"></div>\r\n                                <p class=\"alert-danger\">");
#nullable restore
#line 103 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Pages\Create.cshtml"
                                                   Write(ViewBag.ErrorMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>   
                            </div>

                            <div class=""form-group"">
                                <div id=""published""></div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""dx-fieldset"">
                    <br />
                    <div id=""summary""></div>
                    <br />
                    <div id=""button""></div>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e1fbd1dccd708db08ad5b00bd479959e646d7e320216", async() => {
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
                WriteLiteral(@"
    <script>
        var getMenus = new DevExpress.data.AspNet.createStore({
            key: ""id"",
            loadUrl: ""/api/MenuAPI/GetMenuWithOutPage"",
            onBeforeSend: function (method, ajaxOptions) {
                ajaxOptions.xhrFields = { withCredentials: true };
            }
        });

        $(function () {
            $(""#menuSelection"").dxSelectBox({
                dataSource: getMenus,
                displayExpr: ""name"",
                valueExpr: ""id"",
                name: 'MenuId',
                searchEnabled: true
            });

            $(""#published"").dxCheckBox({
                text: '");
#nullable restore
#line 146 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Pages\Create.cshtml"
                  Write(SharedLocalizer["Active"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                name: \'IsPublish\',\r\n                value: true\r\n            });\r\n\r\n            $(\"#button\").dxButton({\r\n                text: \'");
#nullable restore
#line 152 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Pages\Create.cshtml"
                  Write(SharedLocalizer["Add"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                type: \"success\",\r\n                useSubmitBehavior: true,\r\n            });\r\n\r\n            $(\"#summary\").dxValidationSummary({});\r\n        });\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DAL.Models.Dto.MenuModelDTO.CreatePagesDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
