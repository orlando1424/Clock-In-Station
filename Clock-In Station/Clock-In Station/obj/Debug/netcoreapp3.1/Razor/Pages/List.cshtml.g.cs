#pragma checksum "D:\Repos\Clock-In Station\Clock-In Station\Clock-In Station\Clock-In Station\Pages\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee015ec64587a86fe576259f00aa7b6faf8d854d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Clock_In_Station.Pages.Pages_List), @"mvc.1.0.razor-page", @"/Pages/List.cshtml")]
namespace Clock_In_Station.Pages
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
#line 1 "D:\Repos\Clock-In Station\Clock-In Station\Clock-In Station\Clock-In Station\Pages\_ViewImports.cshtml"
using Clock_In_Station;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee015ec64587a86fe576259f00aa7b6faf8d854d", @"/Pages/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb33de08939d6d9da0533fe0b2c4240079032441", @"/Pages/_ViewImports.cshtml")]
    public class Pages_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h1>List of Employee Clock-ins</h1>\r\n\r\n<table class=\"table\">\r\n   \r\n\r\n        <tr>\r\n            <td>ID: 1</td>\r\n            <td>Tommy John</td>\r\n            <td>");
#nullable restore
#line 15 "D:\Repos\Clock-In Station\Clock-In Station\Clock-In Station\Clock-In Station\Pages\List.cshtml"
           Write(Model.CurrentDateTime());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    \r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Clock_In_Station.Pages.listModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Clock_In_Station.Pages.listModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Clock_In_Station.Pages.listModel>)PageContext?.ViewData;
        public Clock_In_Station.Pages.listModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
