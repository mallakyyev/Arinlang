#pragma checksum "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Page\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78e0670a4f0f2eabec4b3c8643b141451a0a384d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Page_Detail), @"mvc.1.0.view", @"/Views/Page/Detail.cshtml")]
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
#line 1 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\_ViewImports.cshtml"
using ARINLAB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\_ViewImports.cshtml"
using ARINLAB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78e0670a4f0f2eabec4b3c8643b141451a0a384d", @"/Views/Page/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e119a08238c3c4a5c8eaf5a5256788f2de43111b", @"/Views/_ViewImports.cshtml")]
    public class Views_Page_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DAL.Models.Dto.MenuModelDTO.PagesDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Page\Detail.cshtml"
  
    ViewData["Title"] = Model.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"bg-gray-100 h-full py-8\">\r\n    <div class=\"container bg-white sm:pt-12 pt-4 relative\">\r\n        <div class=\"lg:px-24 px-4\">\r\n            <h1 class=\"font-bold text-2xl sm:text-3xl lg:max-w-3xl lg:text-3xl\">\r\n                ");
#nullable restore
#line 10 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Page\Detail.cshtml"
           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h1>\r\n        </div>\r\n        <div class=\"h-1 w-full bg-gray-100 lg:mt-20 sm:mt-10 mt-4\"></div>\r\n\r\n        <div class=\"lg:px-24 px-4 sm:mt-10 mt-4 pb-8\">\r\n            ");
#nullable restore
#line 16 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Page\Detail.cshtml"
       Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DAL.Models.Dto.MenuModelDTO.PagesDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
