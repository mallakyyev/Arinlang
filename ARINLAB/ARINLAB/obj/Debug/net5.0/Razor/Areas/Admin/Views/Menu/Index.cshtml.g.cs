#pragma checksum "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Menu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a293db5f39ef1dbb89a22030b43ebdd5c5da3b7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Menu_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Menu/Index.cshtml")]
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
#line 2 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Menu\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Menu\Index.cshtml"
using ARINLAB.Areas.Admin.Utils;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a293db5f39ef1dbb89a22030b43ebdd5c5da3b7d", @"/Areas/Admin/Views/Menu/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5944270c8b5d9816cf52d026e4a62ac0184f904f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Menu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Menu\Index.cshtml"
  
    ViewData["Title"] = SharedLocalizer["Menu"];


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n            <h1 class=\"page-header\">\r\n                ");
#nullable restore
#line 16 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Menu\Index.cshtml"
           Write(SharedLocalizer["Menu"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h1>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div id=\"gridContainer\">\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(function () {\r\n            let url = `");
#nullable restore
#line 30 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Menu\Index.cshtml"
                  Write(API.GetAllMenu);

#line default
#line hidden
#nullable disable
                WriteLiteral("`;\r\n            var returnUrl = \'");
#nullable restore
#line 31 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Menu\Index.cshtml"
                        Write(Context.Request.Path);

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Menu\Index.cshtml"
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
#line 44 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Menu\Index.cshtml"
                          Write(Url.Action("Create", "Menu", new { Area = "Admin" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"`;
                    window.location = url;
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
                    allowAdding: true
                },
                headerFilter: {
                    visible: true
                },
                wordWrapEnabled: true,
                showColumnLines: true,
                showRowLines: true,
           ");
                WriteLiteral(@"     rowAlternationEnabled: true,
                showBorders: true,
                searchPanel: {
                    visible: true
                },
                stateStoring: {
                    enabled: true,
                    type: ""localStorage"",
                    storageKey: ""menuAdmin""
                },
                columns: [
                    {
                        caption: '");
#nullable restore
#line 86 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Menu\Index.cshtml"
                             Write(SharedLocalizer["Name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                        dataField: \"name\",\r\n                        allowHeaderFiltering: false\r\n                    },\r\n                    {\r\n                        caption: \'");
#nullable restore
#line 91 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Menu\Index.cshtml"
                             Write(SharedLocalizer["Parent menu"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                        dataField: \"parentIdName\",\r\n                        allowHeaderFiltering: false\r\n                    },\r\n                    {\r\n                        caption: \'");
#nullable restore
#line 96 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Menu\Index.cshtml"
                             Write(SharedLocalizer["Link"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                        dataField: \"link\",\r\n                        width: \"230\",\r\n                        allowHeaderFiltering: false\r\n                    },\r\n                    {\r\n                        caption: \'");
#nullable restore
#line 102 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Menu\Index.cshtml"
                             Write(SharedLocalizer["Order"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                        dataField: \"order\",\r\n                        width: \"130\",\r\n                        allowHeaderFiltering: false\r\n                    },\r\n                    {\r\n                        caption: \'");
#nullable restore
#line 108 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Menu\Index.cshtml"
                             Write(SharedLocalizer["Active"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                        dataField: ""isPublish"",
                        width: ""130"",
                        allowHeaderFiltering: false
                    },
                    {
                        type: ""buttons"",
                        width: 110,
                        buttons: [
                            {
                                hint: '");
#nullable restore
#line 118 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Menu\Index.cshtml"
                                  Write(SharedLocalizer["Edit"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                                icon: \"edit\",\r\n                                onClick: function (e) {\r\n                                    var idString = e.row.data.id;\r\n                                    var url = `");
#nullable restore
#line 122 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\Admin\Views\Menu\Index.cshtml"
                                          Write(Url.Action("Edit", "Menu", new { Area = "Admin" }));

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
