#pragma checksum "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Identity\Pages\Account\ResetPasswordConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3768f112ae96adf10f8715dcd65e9c110be1a06c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_ResetPasswordConfirmation), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/ResetPasswordConfirmation.cshtml")]
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
#line 1 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Identity\Pages\_ViewImports.cshtml"
using ARINLAB.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Identity\Pages\_ViewImports.cshtml"
using ARINLAB.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using ARINLAB.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Identity\Pages\Account\ResetPasswordConfirmation.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Identity\Pages\Account\ResetPasswordConfirmation.cshtml"
using ARINLAB;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3768f112ae96adf10f8715dcd65e9c110be1a06c", @"/Areas/Identity/Pages/Account/ResetPasswordConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d309d858ec12de9a1464b196c3f27966448b856", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be63444f39710f638f5e5d5485e30fadd3353b38", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_ResetPasswordConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 7 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Identity\Pages\Account\ResetPasswordConfirmation.cshtml"
  
    ViewData["Title"] = SharedLocalizer["Reset password confirmation"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"wrapper bg-gray-100 w-screen h-screen flex items-center justify-center flex-col\" style=\"height: 60vh \">\r\n    <div class=\"p-10 bg-white shadow-md rounded\">\r\n        <h1 class=\"text-success text-3xl\">");
#nullable restore
#line 13 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Identity\Pages\Account\ResetPasswordConfirmation.cshtml"
                                     Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <p class=\"text-info text-2xl\">\r\n            ");
#nullable restore
#line 15 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Identity\Pages\Account\ResetPasswordConfirmation.cshtml"
       Write(SharedLocalizer["Your password has been reset."]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n        <p class=\"text-info text-2xl\">\r\n            ");
#nullable restore
#line 18 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Identity\Pages\Account\ResetPasswordConfirmation.cshtml"
       Write(SharedLocalizer["Please"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3768f112ae96adf10f8715dcd65e9c110be1a06c5948", async() => {
                WriteLiteral(" ");
#nullable restore
#line 18 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Identity\Pages\Account\ResetPasswordConfirmation.cshtml"
                                                         Write(SharedLocalizer["click here to log in"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(".\r\n        </p>\r\n        <p style=\"margin-top:10px;\">\r\n            <a class=\"btn btn-danger\" style=\"color:green\" href=\"#\">");
#nullable restore
#line 21 "D:\Work\ARINLAB\ARINLAB\ARINLAB\Areas\Identity\Pages\Account\ResetPasswordConfirmation.cshtml"
                                                              Write(SharedLocalizer["Go to Main page"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </p>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResetPasswordConfirmationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ResetPasswordConfirmationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ResetPasswordConfirmationModel>)PageContext?.ViewData;
        public ResetPasswordConfirmationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
