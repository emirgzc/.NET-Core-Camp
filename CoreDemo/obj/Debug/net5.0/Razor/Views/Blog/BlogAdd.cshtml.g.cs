#pragma checksum "C:\Users\hatic\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b4602ccfc36f2c09c393b06c1795a7cf3e2d871"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogAdd), @"mvc.1.0.view", @"/Views/Blog/BlogAdd.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b4602ccfc36f2c09c393b06c1795a7cf3e2d871", @"/Views/Blog/BlogAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_BlogAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Blog>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\hatic\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
  
    ViewData["Title"] = "BlogAdd";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Yeni Blog Girişi</h1>\r\n\r\n<br />\r\n\r\n");
#nullable restore
#line 12 "C:\Users\hatic\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
 using (Html.BeginForm("BlogAdd", "Blog", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\hatic\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Blog Başlığı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\hatic\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.TextBoxFor(x=>x.BlogTitle, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\hatic\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.ValidationMessageFor(x=>x.BlogTitle,"", new {@class="text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 18 "C:\Users\hatic\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Blog Görsel"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\hatic\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.TextBoxFor(x=>x.BlogImage, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\hatic\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.ValidationMessageFor(x=>x.BlogImage,"", new {@class="text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 22 "C:\Users\hatic\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Blog Küçük Görsel"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\hatic\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.TextBoxFor(x=>x.BlogThumbnailImage, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 25 "C:\Users\hatic\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Kategori"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\hatic\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.DropDownListFor(x=>x.CategoryID, (List<SelectListItem>)ViewBag.cv, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 28 "C:\Users\hatic\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Blog İçerik"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\hatic\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.TextAreaFor(x=>x.BlogContent,15,3, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\hatic\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
Write(Html.ValidationMessageFor(x=>x.BlogContent,"", new {@class="text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-info\">Yazıyı Kaydet</button>\r\n");
#nullable restore
#line 33 "C:\Users\hatic\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogAdd.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Blog> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
