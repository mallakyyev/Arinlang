#pragma checksum "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\News\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a221a7e9c837c9f0f7e886e6c58cfbe2ac67793"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_News_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/News/Create.cshtml")]
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
#line 3 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\News\Create.cshtml"
using TSTB.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\News\Create.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\News\Create.cshtml"
using DAL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a221a7e9c837c9f0f7e886e6c58cfbe2ac67793", @"/Areas/Admin/Views/News/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5944270c8b5d9816cf52d026e4a62ac0184f904f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_News_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DAL.Models.Dto.NewsModelDTO.CreateNewsDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/custom.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/tinymce/tinymce/js/tinymce/tinymce.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/CustomStore.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 9 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\News\Create.cshtml"
  
    ViewData["Title"] = SharedLocalizer["Create news"];


    int lngIndex = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n            <h1 class=\"page-header\">\r\n                ");
#nullable restore
#line 20 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\News\Create.cshtml"
           Write(SharedLocalizer["Create news"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h1>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a221a7e9c837c9f0f7e886e6c58cfbe2ac677937320", async() => {
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
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a221a7e9c837c9f0f7e886e6c58cfbe2ac677938367", async() => {
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
            WriteLiteral("\r\n        <div id=\"gridContainer\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a221a7e9c837c9f0f7e886e6c58cfbe2ac677939456", async() => {
                WriteLiteral("\r\n                <div class=\"col-md-12\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a221a7e9c837c9f0f7e886e6c58cfbe2ac677939779", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 31 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\News\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                    <div class=\"form-row\">\r\n                        <div class=\"col-md-12\">\r\n");
#nullable restore
#line 35 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\News\Create.cshtml"
                             foreach (LanguageDto languageDTO in ViewBag.Languages)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <h3>");
#nullable restore
#line 37 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\News\Create.cshtml"
                               Write(languageDTO.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                                <hr />\r\n                                <input type=\"hidden\" class=\"form-control\"");
                BeginWriteAttribute("name", " name=\"", 1314, "\"", 1362, 3);
                WriteAttributeValue("", 1321, "NewsTranslates[", 1321, 15, true);
#nullable restore
#line 39 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\News\Create.cshtml"
WriteAttributeValue("", 1336, lngIndex, 1336, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1345, "].LanguageCulture", 1345, 17, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1363, "\"", 1391, 1);
#nullable restore
#line 39 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\News\Create.cshtml"
WriteAttributeValue("", 1371, languageDTO.Culture, 1371, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <div class=\"form-group\">\r\n                                    <label>");
#nullable restore
#line 41 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\News\Create.cshtml"
                                      Write(SharedLocalizer["Name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" *</label>\r\n                                    <div");
                BeginWriteAttribute("id", " id=\"", 1574, "\"", 1598, 2);
                WriteAttributeValue("", 1579, "news-name-", 1579, 10, true);
#nullable restore
#line 42 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\News\Create.cshtml"
WriteAttributeValue("", 1589, lngIndex, 1589, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></div>\r\n");
                WriteLiteral("                                </div>\r\n");
                WriteLiteral("                                <div class=\"form-group\">\r\n                                    <label>");
#nullable restore
#line 47 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\News\Create.cshtml"
                                      Write(SharedLocalizer["Description"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" *</label>\r\n                                    <textarea");
                BeginWriteAttribute("class", " class=\"", 1980, "\"", 2004, 2);
                WriteAttributeValue("", 1988, "editor-", 1988, 7, true);
#nullable restore
#line 48 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\News\Create.cshtml"
WriteAttributeValue("", 1995, lngIndex, 1995, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2005, "\"", 2049, 3);
                WriteAttributeValue("", 2012, "NewsTranslates[", 2012, 15, true);
#nullable restore
#line 48 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\News\Create.cshtml"
WriteAttributeValue("", 2027, lngIndex, 2027, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2036, "].Description", 2036, 13, true);
                EndWriteAttribute();
                WriteLiteral(" rows=\"3\"></textarea>\r\n");
                WriteLiteral("                                </div>\r\n");
                WriteLiteral("                                <script>\r\n\r\n\r\n                                    $(function () {\r\n                                        $(\"#news-name-");
#nullable restore
#line 56 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\News\Create.cshtml"
                                                 Write(lngIndex);

#line default
#line hidden
#nullable disable
                WriteLiteral("\").dxTextBox({\r\n                                            name: \"NewsTranslates[");
#nullable restore
#line 57 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\News\Create.cshtml"
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
#line 61 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\News\Create.cshtml"
                                                     Write(SharedLocalizer["Enter name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n                                            }]\r\n                                        });\r\n\r\n                                        InitTinyMce(\'textarea.editor-");
#nullable restore
#line 65 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\News\Create.cshtml"
                                                                Write(lngIndex);

#line default
#line hidden
#nullable disable
                WriteLiteral("\', \'/api/images\')\r\n\r\n\r\n");
                WriteLiteral("                                    });\r\n                                </script>\r\n");
#nullable restore
#line 100 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\News\Create.cshtml"


                                lngIndex++;
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-12\">\r\n                            <h2>");
#nullable restore
#line 107 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\News\Create.cshtml"
                           Write(SharedLocalizer["Data"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                            <hr />\r\n                            <div class=\"form-group\">\r\n                                <label>");
#nullable restore
#line 110 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\News\Create.cshtml"
                                  Write(SharedLocalizer["Select news category"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" *</label>\r\n                                <div id=\"newsSelection\"></div>\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label>");
#nullable restore
#line 114 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\News\Create.cshtml"
                                  Write(SharedLocalizer["Picture"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" *</label>\r\n                                <div id=\"files\"></div>\r\n                            </div>\r\n\r\n                            <div class=\"form-group\">\r\n                                <label>");
#nullable restore
#line 119 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\News\Create.cshtml"
                                  Write(SharedLocalizer["Date publish"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" *</label>
                                <div id=""datePublished""></div>
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a221a7e9c837c9f0f7e886e6c58cfbe2ac6779321451", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        var getNewsCategories = new DevExpress.data.AspNet.createStore({
            key: ""id"",
            loadUrl: ""/api/NewsAPI/GetAllNewsCategories"",
            onBeforeSend: function (method, ajaxOptions) {
                ajaxOptions.xhrFields = { withCredentials: true };
            }
        });

        $(function () {
            $(""#newsSelection"").dxSelectBox({
                dataSource: getNewsCategories,
                displayExpr: ""name"",
                valueExpr: ""id"",
                name: 'NewsCategoryID',
                searchEnabled: true
            }).dxValidator({
                validationRules: [{
                    type: ""required"",
                    message: '");
#nullable restore
#line 163 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\News\Create.cshtml"
                         Write(SharedLocalizer["Select news category"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n                }]\r\n            });\r\n\r\n            $(\"#files\").dxFileUploader({\r\n                selectButtonText: \'");
#nullable restore
#line 168 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\News\Create.cshtml"
                              Write(SharedLocalizer["Choose a picture"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                name: \"FormFile\",\r\n                labelText: \'");
#nullable restore
#line 170 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\News\Create.cshtml"
                       Write(SharedLocalizer["or drag picture"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                accept: \"image/*\",\r\n                uploadMode: \"or drag\",\r\n                multiple: false,\r\n            }).dxValidator({\r\n                validationRules: [{\r\n                    type: \"required\",\r\n                    message: \'");
#nullable restore
#line 177 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\News\Create.cshtml"
                         Write(SharedLocalizer["Upload picture"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n                }]\r\n            });\r\n\r\n            $(\"#published\").dxCheckBox({\r\n                text: \'");
#nullable restore
#line 182 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\News\Create.cshtml"
                  Write(SharedLocalizer["Active"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                name: \'IsPublish\',\r\n                value: true\r\n            });\r\n\r\n            $(\"#datePublished\").dxDateBox({\r\n                type: \"date\",\r\n                name: \"DatePublished\",\r\n                placeholder: \'");
#nullable restore
#line 190 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\News\Create.cshtml"
                         Write(SharedLocalizer["Date publish"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                width: 150,\r\n                //displayFormat: \"dd.MM.yyyy\",\r\n                //value: \"");
#nullable restore
#line 193 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\News\Create.cshtml"
                     Write(DateTime.Now.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral("\"\r\n            }).dxValidator({\r\n                 validationRules: [{\r\n                 type: \"required\",\r\n                    message: \'");
#nullable restore
#line 197 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\News\Create.cshtml"
                         Write(SharedLocalizer["Please select publish date"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n                }]\r\n            });\r\n\r\n            $(\"#button\").dxButton({\r\n                text: \'");
#nullable restore
#line 202 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\News\Create.cshtml"
                  Write(SharedLocalizer["Add"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                type: \"success\",\r\n                useSubmitBehavior: true,\r\n            });\r\n            $(\"#summary\").dxValidationSummary({});\r\n        });\r\n\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DAL.Models.Dto.NewsModelDTO.CreateNewsDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
