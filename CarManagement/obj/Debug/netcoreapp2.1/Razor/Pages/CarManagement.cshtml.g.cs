#pragma checksum "Y:\dev_work\CarManagement\CarManagement\Pages\CarManagement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f47549d0ff5ec1d4b11270931b142a697961598"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CarManagement.Pages.Pages_CarManagement), @"mvc.1.0.razor-page", @"/Pages/CarManagement.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/CarManagement.cshtml", typeof(CarManagement.Pages.Pages_CarManagement), null)]
namespace CarManagement.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "Y:\dev_work\CarManagement\CarManagement\Pages\_ViewImports.cshtml"
using CarManagement;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f47549d0ff5ec1d4b11270931b142a697961598", @"/Pages/CarManagement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42bba13f538f0ffe1f9e556872bcffa7ee6b7fca", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CarManagement : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "Y:\dev_work\CarManagement\CarManagement\Pages\CarManagement.cshtml"
  
    ViewData["Title"] = "CarManagement";

#line default
#line hidden
            BeginContext(97, 63, true);
            WriteLiteral("\r\n<h2>CarManagement</h2>\r\n\r\n<p>Below is the management page</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarManagement.CarManagementModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CarManagement.CarManagementModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CarManagement.CarManagementModel>)PageContext?.ViewData;
        public CarManagement.CarManagementModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
