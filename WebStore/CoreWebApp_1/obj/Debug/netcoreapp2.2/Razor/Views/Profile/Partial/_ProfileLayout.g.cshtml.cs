#pragma checksum "E:\fallingsappy\Data\Programming\portfolio\WebStore\CoreWebApp_1\Views\Profile\Partial\_ProfileLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef921721928571847023a1bcce13041499ef0d0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Partial__ProfileLayout), @"mvc.1.0.view", @"/Views/Profile/Partial/_ProfileLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Profile/Partial/_ProfileLayout.cshtml", typeof(AspNetCore.Views_Profile_Partial__ProfileLayout))]
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
#line 1 "E:\fallingsappy\Data\Programming\portfolio\WebStore\CoreWebApp_1\Views\_ViewImports.cshtml"
using WebStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef921721928571847023a1bcce13041499ef0d0c", @"/Views/Profile/Partial/_ProfileLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67066408fc6b1bdc8b40a1cbe0d084334331fdab", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Partial__ProfileLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\fallingsappy\Data\Programming\portfolio\WebStore\CoreWebApp_1\Views\Profile\Partial\_ProfileLayout.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(32, 45, true);
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-3\">");
            EndContext();
            BeginContext(78, 47, false);
#line 5 "E:\fallingsappy\Data\Programming\portfolio\WebStore\CoreWebApp_1\Views\Profile\Partial\_ProfileLayout.cshtml"
                     Write(await Html.PartialAsync("Partial/_ProfileMenu"));

#line default
#line hidden
            EndContext();
            BeginContext(125, 34, true);
            WriteLiteral("</div>\r\n    <div class=\"col-md-9\">");
            EndContext();
            BeginContext(160, 12, false);
#line 6 "E:\fallingsappy\Data\Programming\portfolio\WebStore\CoreWebApp_1\Views\Profile\Partial\_ProfileLayout.cshtml"
                     Write(RenderBody());

#line default
#line hidden
            EndContext();
            BeginContext(172, 14, true);
            WriteLiteral("</div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591