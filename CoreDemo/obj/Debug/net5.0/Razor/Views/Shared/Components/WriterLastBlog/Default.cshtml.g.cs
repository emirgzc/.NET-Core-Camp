#pragma checksum "C:\Users\hatic\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterLastBlog\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b500460a96b8553a782974bc18ab5296370d80d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterLastBlog_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterLastBlog/Default.cshtml")]
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
#line 1 "C:\Users\hatic\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hatic\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b500460a96b8553a782974bc18ab5296370d80d", @"/Views/Shared/Components/WriterLastBlog/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_WriterLastBlog_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"tech-btm\">\r\n    <h4>Yazarın Diğer Yazıları</h4>\r\n\r\n");
#nullable restore
#line 7 "C:\Users\hatic\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterLastBlog\Default.cshtml"
     foreach (var item in Model.Take(2))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"blog-grids row mb-3\">\r\n            <div class=\"col-md-5 blog-grid-left\">\r\n                <a href=\"single.html\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 320, "\"", 341, 1);
#nullable restore
#line 12 "C:\Users\hatic\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterLastBlog\Default.cshtml"
WriteAttributeValue("", 326, item.BlogImage, 326, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 360, "\"", 366, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </a>\r\n            </div>\r\n            <div class=\"col-md-7 blog-grid-right\">\r\n\r\n                <h5>\r\n                    <a href=\"single.html\">");
#nullable restore
#line 18 "C:\Users\hatic\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterLastBlog\Default.cshtml"
                                     Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                </h5>\r\n                <div class=\"sub-meta\">\r\n                    <span>\r\n                        <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 22 "C:\Users\hatic\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterLastBlog\Default.cshtml"
                                                 Write(((DateTime)item.BlogCreateDate).ToString("dd-MMMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 28 "C:\Users\hatic\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterLastBlog\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591