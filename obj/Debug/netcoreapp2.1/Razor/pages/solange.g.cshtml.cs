#pragma checksum "C:\Users\frc7\source\repos\mywebapp\pages\solange.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56254d285be81e836adde5bceb04d68ca10cb242"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.pages_solange), @"mvc.1.0.razor-page", @"/pages/solange.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/pages/solange.cshtml", typeof(AspNetCore.pages_solange), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56254d285be81e836adde5bceb04d68ca10cb242", @"/pages/solange.cshtml")]
    public class pages_solange : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(7, 59, true);
            WriteLiteral("\r\n<h1>Hello Solange</h1>\r\n<p>This page is at /solange</p>\r\n");
            EndContext();
#line 5 "C:\Users\frc7\source\repos\mywebapp\pages\solange.cshtml"
  
    var i = 2+2;

#line default
#line hidden
            BeginContext(91, 56, true);
            WriteLiteral("<h2> This is second header</h2>\r\n<b>The concert is at : ");
            EndContext();
            BeginContext(148, 12, false);
#line 9 "C:\Users\frc7\source\repos\mywebapp\pages\solange.cshtml"
                  Write(DateTime.Now);

#line default
#line hidden
            EndContext();
            BeginContext(160, 7, true);
            WriteLiteral(" or at ");
            EndContext();
            BeginContext(168, 1, false);
#line 9 "C:\Users\frc7\source\repos\mywebapp\pages\solange.cshtml"
                                      Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(169, 8, true);
            WriteLiteral(" apm</b>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<pages_solange> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<pages_solange> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<pages_solange>)PageContext?.ViewData;
        public pages_solange Model => ViewData.Model;
    }
}
#pragma warning restore 1591
