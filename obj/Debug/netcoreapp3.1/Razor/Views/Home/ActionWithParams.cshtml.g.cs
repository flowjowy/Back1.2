#pragma checksum "C:\Users\PornHub\Downloads\Yield_CustomAttributes_IValidatableObject\WebApplication1\Views\Home\ActionWithParams.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1db1afac86e5fc5797a69a049a35b98e705d5605"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ActionWithParams), @"mvc.1.0.view", @"/Views/Home/ActionWithParams.cshtml")]
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
#line 1 "C:\Users\PornHub\Downloads\Yield_CustomAttributes_IValidatableObject\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PornHub\Downloads\Yield_CustomAttributes_IValidatableObject\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1db1afac86e5fc5797a69a049a35b98e705d5605", @"/Views/Home/ActionWithParams.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ActionWithParams : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\PornHub\Downloads\Yield_CustomAttributes_IValidatableObject\WebApplication1\Views\Home\ActionWithParams.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "ActionWithParams";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>Data extracted from GET request</p>\r\n<p>\r\n    String parameter - ");
#nullable restore
#line 8 "C:\Users\PornHub\Downloads\Yield_CustomAttributes_IValidatableObject\WebApplication1\Views\Home\ActionWithParams.cshtml"
                  Write(ViewBag.StrParam);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n    Integer parameter - ");
#nullable restore
#line 9 "C:\Users\PornHub\Downloads\Yield_CustomAttributes_IValidatableObject\WebApplication1\Views\Home\ActionWithParams.cshtml"
                   Write(ViewBag.IntParam);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n    Date parameter - ");
#nullable restore
#line 10 "C:\Users\PornHub\Downloads\Yield_CustomAttributes_IValidatableObject\WebApplication1\Views\Home\ActionWithParams.cshtml"
                Write(ViewBag.DateParam);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n");
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