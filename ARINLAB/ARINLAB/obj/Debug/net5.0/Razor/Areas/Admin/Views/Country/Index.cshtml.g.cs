#pragma checksum "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Country\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24a954f206ba5765e64f8c48f4dc3d313d8496a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Country_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Country/Index.cshtml")]
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
#line 1 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Country\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Country\Index.cshtml"
using ARINLAB.Areas.Admin.Utils;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24a954f206ba5765e64f8c48f4dc3d313d8496a2", @"/Areas/Admin/Views/Country/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5944270c8b5d9816cf52d026e4a62ac0184f904f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Country_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Country\Index.cshtml"
  
    ViewData["Title"] = SharedLocalizer["Countries"];


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n            <h1 class=\"page-header\">\r\n                ");
#nullable restore
#line 14 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Country\Index.cshtml"
           Write(SharedLocalizer["Countries"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h1>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div id=\"gridContainer\">\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(function () {\r\n            let url = `");
#nullable restore
#line 30 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Country\Index.cshtml"
                  Write(API.Countries);

#line default
#line hidden
#nullable disable
                WriteLiteral("`;\r\n            var returnUrl = \'");
#nullable restore
#line 31 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Country\Index.cshtml"
                        Write(Context.Request.Path);

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Country\Index.cshtml"
                                             Write(Context.Request.QueryString);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
            $(""#gridContainer"").dxDataGrid({
                dataSource: DevExpress.data.AspNet.createStore({
                    key: ""id"",
                    loadUrl: url,
                    insertUrl: url,
                    updateUrl: url,
                    deleteUrl: url,
                    onBeforeSend: function (method, ajaxOptions) {
                        ajaxOptions.xhrFields = { withCredentials: true };
                    }
                }),
                onInitNewRow: function(e) {
                    var url = `");
#nullable restore
#line 44 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Country\Index.cshtml"
                          Write(Url.Action("Create", "Country", new { Area = "Admin" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"`;
                    window.location = url;
                },
                selection: {
                    mode: ""multiple""
                },
                ""export"": {
                    enabled: true,
                    fileName: ""Documents"",
                    allowExportSelectedData: true
                },
                filterPanel: {
                    visible: false
                },
                filterRow: { visible: false },
                remoteOperations: true,
                onRowUpdating: function (e) {
                    e.newData = Object.assign(e.oldData, e.newData)
                },
                scrolling: {
                    mode: ""virtual"",
                    rowRenderingMode: ""virtual""
                },
                paging: {
                    pageSize: 100
                },
                editing: {
                    useIcons: true,
                    allowUpdating: true,
                    allowDeleting: true,
       ");
                WriteLiteral(@"             allowAdding: true
                },
                headerFilter: {
                    visible: false
                },
                wordWrapEnabled: true,
                showColumnLines: true,
                showRowLines: true,
                rowAlternationEnabled: true,
                showBorders: true,
                searchPanel: {
                    visible: true
                },

                allowColumnReordering: false,
                columns: [
                    {
                        caption: '");
#nullable restore
#line 91 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Country\Index.cshtml"
                             Write(SharedLocalizer["Arab Name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                        dataField: \"name_ar\",\r\n                        allowHeaderFiltering: true\r\n                    },\r\n                    {\r\n                        caption: \'");
#nullable restore
#line 96 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Country\Index.cshtml"
                             Write(SharedLocalizer["Name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                        dataField: \"name\",\r\n                        allowHeaderFiltering: true\r\n                    },\r\n                    {\r\n                        caption: \'");
#nullable restore
#line 101 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Country\Index.cshtml"
                             Write(SharedLocalizer["Code"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                        dataField: ""countryCode"",
                        allowHeaderFiltering: false
                    },
                   
                    {
                        type: ""buttons"",
                        width: 110,
                        buttons: [
                            {
                                hint: '");
#nullable restore
#line 111 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Country\Index.cshtml"
                                  Write(SharedLocalizer["Edit"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                                icon: \"edit\",\r\n                                onClick: function (e) {\r\n                                    var idString = e.row.data.id;\r\n                                    var url = `");
#nullable restore
#line 115 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Country\Index.cshtml"
                                          Write(Url.Action("Edit", "Country", new { Area = "Admin" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"`;
                                    window.location = url + '?id=' + idString;
                                }
                            },
                            ""delete""
                        ]
                    }
                ]
            });
        });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
