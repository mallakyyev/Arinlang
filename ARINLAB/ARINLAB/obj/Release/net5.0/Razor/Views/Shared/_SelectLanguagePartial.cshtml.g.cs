#pragma checksum "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Shared\_SelectLanguagePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97ebfc569b4bb0b11fb9d1a1d3b6e42032192f76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SelectLanguagePartial), @"mvc.1.0.view", @"/Views/Shared/_SelectLanguagePartial.cshtml")]
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
#nullable restore
#line 1 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Shared\_SelectLanguagePartial.cshtml"
using Microsoft.AspNetCore.Builder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Shared\_SelectLanguagePartial.cshtml"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Shared\_SelectLanguagePartial.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Shared\_SelectLanguagePartial.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Shared\_SelectLanguagePartial.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97ebfc569b4bb0b11fb9d1a1d3b6e42032192f76", @"/Views/Shared/_SelectLanguagePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fa1d5c591814f7725771882b633ab2ec01fb489", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__SelectLanguagePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 11 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Shared\_SelectLanguagePartial.cshtml"
 if (CultureInfo.CurrentCulture.Name.StartsWith("ar"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""text-white mr-10 select-none select-box relative h-full flex items-center"" id=""select-box""
         style="" padding-right: 150px;"">
        <div class=""pl-3 text-center flex items-center z-10 cursor`-pointer""
             style=""height: 35px; width: 200px; background-color: white; margin: 15px; border-radius: 9px; color: black; text-align: center;"">

            <span class=""flex uppercase"" style=""font-size: 20px;"">
                <img src=""/images/flags/sa.svg""");
            BeginWriteAttribute("class", " class=\"", 901, "\"", 909, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width: 30%; margin-right: 10px;\" />\r\n");
            WriteLiteral(@"                <a data-link=""#"" class=""py-3 pr-2"" style=""display: block;"">
                    AR
                </a>
                <a data-link=""#"" class=""py-3 pr-2"" style=""display: block;"">
                    |
                </a>
                <a data-link=""#"" class=""py-3 pr-2"" style=""display: block;"">
                    ");
#nullable restore
#line 36 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Shared\_SelectLanguagePartial.cshtml"
               Write(_userDict.GetDictionaryName());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n            </span>\r\n\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 42 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Shared\_SelectLanguagePartial.cshtml"
}
else
{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""text-white mr-10 select-none select-box relative h-full flex items-center"" id=""select-box""
         style="" padding-right: 150px;"">
        <div class=""pl-3 text-center flex items-center z-10 cursor`-pointer""
             style=""height: 35px; width: 200px; background-color: white; margin: 15px; border-radius: 9px; color: black; text-align: center;"">
           
            <span class=""flex uppercase"" style=""font-size: 20px;"">
");
#nullable restore
#line 52 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Shared\_SelectLanguagePartial.cshtml"
                 if (CultureInfo.CurrentCulture.Name.StartsWith("en"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img src=\"/images/flags/us.svg\"");
            BeginWriteAttribute("class", " class=\"", 2493, "\"", 2501, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""max-width:30%; margin-right:10px"" />
                    <a data-link=""#"" class=""py-3 pr-2"" style=""display: block;"">
                        EN
                    </a>
                    <a data-link=""#"" class=""py-3 pr-2"" style=""display: block;"">
                        |
                    </a>
                    <a data-link=""#"" class=""py-3 pr-2"" style=""display: block;"">
                        ");
#nullable restore
#line 62 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Shared\_SelectLanguagePartial.cshtml"
                   Write(_userDict.GetDictionaryName());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </a>\r\n");
#nullable restore
#line 64 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Shared\_SelectLanguagePartial.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img src=\"/images/flags/tm.svg\"");
            BeginWriteAttribute("class", " class=\"", 3091, "\"", 3099, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""max-width: 30%; margin-right: 10px"" />
                    <a data-link=""#"" class=""py-3 pr-2"" style=""display: block;"">
                        EN
                    </a>
                    <a data-link=""#"" class=""py-3 pr-2"" style=""display: block;"">
                        |
                    </a>
                    <a data-link=""#"" class=""py-3 pr-2"" style=""display: block;"">
");
#nullable restore
#line 75 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Shared\_SelectLanguagePartial.cshtml"
                           
                            string s = _userDict.GetDictionaryName();
                            s = s.Substring(0, s.Length - 2);
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
#nullable restore
#line 79 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Shared\_SelectLanguagePartial.cshtml"
                   Write(s);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </a>\r\n");
#nullable restore
#line 81 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Shared\_SelectLanguagePartial.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </span>\r\n            \r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 86 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Views\Shared\_SelectLanguagePartial.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ARINLAB.Services.SessionService.UserDictionary _userDict { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<RequestLocalizationOptions> LocOptions { get; private set; }
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
