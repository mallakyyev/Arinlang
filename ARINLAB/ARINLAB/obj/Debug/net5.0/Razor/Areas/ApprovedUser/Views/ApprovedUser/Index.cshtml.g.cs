#pragma checksum "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\ApprovedUser\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fffc796276e9b7d03d8d25adfc0677d15354fd7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ApprovedUser_Views_ApprovedUser_Index), @"mvc.1.0.view", @"/Areas/ApprovedUser/Views/ApprovedUser/Index.cshtml")]
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
#line 6 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\ApprovedUser\Index.cshtml"
using ARINLAB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fffc796276e9b7d03d8d25adfc0677d15354fd7b", @"/Areas/ApprovedUser/Views/ApprovedUser/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5944270c8b5d9816cf52d026e4a62ac0184f904f", @"/Areas/ApprovedUser/Views/_ViewImports.cshtml")]
    public class Areas_ApprovedUser_Views_ApprovedUser_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<StatisticCard>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\ApprovedUser\Index.cshtml"
  
    ViewData["Title"] = "Index";


#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 8 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\ApprovedUser\Index.cshtml"
Write(SharedLocalizer["Admin Dashboard"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<div class=""main-wrapper"">
    <div class=""row"">
        <!-- Top Report Start -->
        <div class=""col-xlg-3 col-md-6 col-12 mb-30"">
            <div class=""top-report"">

                <!-- Head -->
                <div class=""head"">
                    <h4>");
#nullable restore
#line 18 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\ApprovedUser\Index.cshtml"
                   Write(SharedLocalizer["Total Words"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <a href=\"#\" class=\"view\"><i class=\"zmdi zmdi-eye\"></i></a>\r\n                </div>\r\n\r\n                <!-- Content -->\r\n                <div class=\"content\">\r\n                    <h5>");
#nullable restore
#line 24 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\ApprovedUser\Index.cshtml"
                   Write(SharedLocalizer["Todays"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h2>");
#nullable restore
#line 25 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\ApprovedUser\Index.cshtml"
                   Write(Model[0].totalCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                </div>

                <!-- Footer -->
                <div class=""footer"">
                    <div class=""progess"">
                        <div class=""progess-bar"" style=""width: 92%;""></div>
                    </div>
                    <p>");
#nullable restore
#line 33 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\ApprovedUser\Index.cshtml"
                  Write(SharedLocalizer["Total"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 33 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\ApprovedUser\Index.cshtml"
                                            Write(Model[0].Editers);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 33 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\ApprovedUser\Index.cshtml"
                                                              Write(SharedLocalizer["Users contributed"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                </div>

            </div>
        </div><!-- Top Report End -->
        <!-- Top Report Start -->
        <!-- Top Report Start -->
        <div class=""col-xlg-3 col-md-6 col-12 mb-30"">
            <div class=""top-report"">

                <!-- Head -->
                <div class=""head"">
                    <h4>");
#nullable restore
#line 45 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\ApprovedUser\Index.cshtml"
                   Write(SharedLocalizer["Total Sentences"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <a href=\"#\" class=\"view\"><i class=\"zmdi zmdi-eye\"></i></a>\r\n                </div>\r\n\r\n                <!-- Content -->\r\n                <div class=\"content\">\r\n                    <h5>");
#nullable restore
#line 51 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\ApprovedUser\Index.cshtml"
                   Write(SharedLocalizer["Todays"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h2>");
#nullable restore
#line 52 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\ApprovedUser\Index.cshtml"
                   Write(Model[1].totalCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                </div>

                <!-- Footer -->
                <div class=""footer"">
                    <div class=""progess"">
                        <div class=""progess-bar"" style=""width: 92%;""></div>
                    </div>
                    <p>");
#nullable restore
#line 60 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\ApprovedUser\Index.cshtml"
                  Write(SharedLocalizer["Total"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 60 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\ApprovedUser\Index.cshtml"
                                            Write(Model[1].Editers);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 60 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\ApprovedUser\Index.cshtml"
                                                              Write(SharedLocalizer["Users contributed"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                </div>

            </div>
        </div><!-- Top Report End -->
        <!-- Top Report Start -->
        <!-- Top Report Start -->
        <div class=""col-xlg-3 col-md-6 col-12 mb-30"">
            <div class=""top-report"">

                <!-- Head -->
                <div class=""head"">
                    <h4>");
#nullable restore
#line 72 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\ApprovedUser\Index.cshtml"
                   Write(SharedLocalizer["Total Clauses"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <a href=\"#\" class=\"view\"><i class=\"zmdi zmdi-eye\"></i></a>\r\n                </div>\r\n\r\n                <!-- Content -->\r\n                <div class=\"content\">\r\n                    <h5>");
#nullable restore
#line 78 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\ApprovedUser\Index.cshtml"
                   Write(SharedLocalizer["Todays"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h2>");
#nullable restore
#line 79 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\ApprovedUser\Index.cshtml"
                   Write(Model[2].totalCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                </div>

                <!-- Footer -->
                <div class=""footer"">
                    <div class=""progess"">
                        <div class=""progess-bar"" style=""width: 92%;""></div>
                    </div>
                    <p>");
#nullable restore
#line 87 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\ApprovedUser\Index.cshtml"
                  Write(SharedLocalizer["Total"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 87 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\ApprovedUser\Index.cshtml"
                                            Write(Model[2].Editers);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 87 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\ApprovedUser\Index.cshtml"
                                                              Write(SharedLocalizer["Users contributed"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                </div>

            </div>
        </div><!-- Top Report End -->
        <!-- Top Report Start -->
        <!-- Top Report Start -->
        <div class=""col-xlg-3 col-md-6 col-12 mb-30"">
            <div class=""top-report"">

                <!-- Head -->
                <div class=""head"">
                    <h4>");
#nullable restore
#line 99 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\ApprovedUser\Index.cshtml"
                   Write(SharedLocalizer["Total Names"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <a href=\"#\" class=\"view\"><i class=\"zmdi zmdi-eye\"></i></a>\r\n                </div>\r\n\r\n                <!-- Content -->\r\n                <div class=\"content\">\r\n                    <h5>");
#nullable restore
#line 105 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\ApprovedUser\Index.cshtml"
                   Write(SharedLocalizer["Todays"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h2>");
#nullable restore
#line 106 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\ApprovedUser\Index.cshtml"
                   Write(Model[3].totalCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                </div>

                <!-- Footer -->
                <div class=""footer"">
                    <div class=""progess"">
                        <div class=""progess-bar"" style=""width: 92%;""></div>
                    </div>
                    <p>");
#nullable restore
#line 114 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\ApprovedUser\Index.cshtml"
                  Write(SharedLocalizer["Total"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 114 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\ApprovedUser\Index.cshtml"
                                            Write(Model[3].Editers);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 114 "D:\ARINLAB\ARINLAB\ARINLAB\Areas\ApprovedUser\Views\ApprovedUser\Index.cshtml"
                                                              Write(SharedLocalizer["Users contributed"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                </div>\r\n\r\n            </div>\r\n        </div><!-- Top Report End -->\r\n        <!-- Top Report Start -->\r\n    </div><!-- Top Report Wrap End -->\r\n\r\n    <!--   \r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<StatisticCard>> Html { get; private set; }
    }
}
#pragma warning restore 1591
