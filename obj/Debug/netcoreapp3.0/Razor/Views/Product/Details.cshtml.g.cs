#pragma checksum "C:\Users\hoss_\Desktop\33333\Create-A-Bageriet2.0-master\Bageriet\Bageriet\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf4c4e88278844083d7222cbff66b10129765dbc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
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
#line 1 "C:\Users\hoss_\Desktop\33333\Create-A-Bageriet2.0-master\Bageriet\Bageriet\Views\_ViewImports.cshtml"
using Bageriet.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hoss_\Desktop\33333\Create-A-Bageriet2.0-master\Bageriet\Bageriet\Views\_ViewImports.cshtml"
using Bageriet.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf4c4e88278844083d7222cbff66b10129765dbc", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa054731253724dd9435297ba7916de5aec2dae4", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n<h2>");
#nullable restore
#line 4 "C:\Users\hoss_\Desktop\33333\Create-A-Bageriet2.0-master\Bageriet\Bageriet\Views\Product\Details.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n\n<div class=\"thumbnail\">\n    <img");
            BeginWriteAttribute("alt", " alt=\"", 71, "\"", 88, 1);
#nullable restore
#line 7 "C:\Users\hoss_\Desktop\33333\Create-A-Bageriet2.0-master\Bageriet\Bageriet\Views\Product\Details.cshtml"
WriteAttributeValue("", 77, Model.Name, 77, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 89, "\"", 110, 1);
#nullable restore
#line 7 "C:\Users\hoss_\Desktop\33333\Create-A-Bageriet2.0-master\Bageriet\Bageriet\Views\Product\Details.cshtml"
WriteAttributeValue("", 95, Model.ImageUrl, 95, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n    <div class=\"caption-full\">\n        <h3>\n            <a href=\"#\">");
#nullable restore
#line 10 "C:\Users\hoss_\Desktop\33333\Create-A-Bageriet2.0-master\Bageriet\Bageriet\Views\Product\Details.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n        </h3>\n        <h4>");
#nullable restore
#line 12 "C:\Users\hoss_\Desktop\33333\Create-A-Bageriet2.0-master\Bageriet\Bageriet\Views\Product\Details.cshtml"
       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
