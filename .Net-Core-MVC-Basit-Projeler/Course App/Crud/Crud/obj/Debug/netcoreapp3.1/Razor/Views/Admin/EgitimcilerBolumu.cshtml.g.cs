#pragma checksum "E:\Tüm Projeler\.Net-Core-MVC-Basit-Projeler\Course App\Crud\Crud\Views\Admin\EgitimcilerBolumu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa887297256d596dcb5f281e89e19df03d7ddaf4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EgitimcilerBolumu), @"mvc.1.0.view", @"/Views/Admin/EgitimcilerBolumu.cshtml")]
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
#line 1 "E:\Tüm Projeler\.Net-Core-MVC-Basit-Projeler\Course App\Crud\Crud\Views\_ViewImports.cshtml"
using Crud;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Tüm Projeler\.Net-Core-MVC-Basit-Projeler\Course App\Crud\Crud\Views\_ViewImports.cshtml"
using Crud.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa887297256d596dcb5f281e89e19df03d7ddaf4", @"/Views/Admin/EgitimcilerBolumu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c402e0156657abbd65c5377838b3b7bfb231cd50", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_EgitimcilerBolumu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Egitmen>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Tüm Projeler\.Net-Core-MVC-Basit-Projeler\Course App\Crud\Crud\Views\Admin\EgitimcilerBolumu.cshtml"
  
    ViewData["Title"] = "EgitimcilerBolumu";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<h1 class=""m-4"" style=""text-align:center"">Egitimciler Bolumu</h1>

<table class=""table table-dark m-4"">
    <thead>
        <tr>

            <th scope=""col"">İd</th>
            <th scope=""col"">İsim</th>
            <th scope=""col"">Soyisim</th>
            <th scope=""col"">Telefon</th>
            <th scope=""col"">e-mail</th>
            <th scope=""col"">Açıklama</th>
            <th scope=""col"">Fotograf</th>
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 25 "E:\Tüm Projeler\.Net-Core-MVC-Basit-Projeler\Course App\Crud\Crud\Views\Admin\EgitimcilerBolumu.cshtml"
         foreach (var i in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 28 "E:\Tüm Projeler\.Net-Core-MVC-Basit-Projeler\Course App\Crud\Crud\Views\Admin\EgitimcilerBolumu.cshtml"
           Write(i.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "E:\Tüm Projeler\.Net-Core-MVC-Basit-Projeler\Course App\Crud\Crud\Views\Admin\EgitimcilerBolumu.cshtml"
           Write(i.isim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "E:\Tüm Projeler\.Net-Core-MVC-Basit-Projeler\Course App\Crud\Crud\Views\Admin\EgitimcilerBolumu.cshtml"
           Write(i.soyisim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "E:\Tüm Projeler\.Net-Core-MVC-Basit-Projeler\Course App\Crud\Crud\Views\Admin\EgitimcilerBolumu.cshtml"
           Write(i.Telefon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "E:\Tüm Projeler\.Net-Core-MVC-Basit-Projeler\Course App\Crud\Crud\Views\Admin\EgitimcilerBolumu.cshtml"
           Write(i.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "E:\Tüm Projeler\.Net-Core-MVC-Basit-Projeler\Course App\Crud\Crud\Views\Admin\EgitimcilerBolumu.cshtml"
           Write(i.açiklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "E:\Tüm Projeler\.Net-Core-MVC-Basit-Projeler\Course App\Crud\Crud\Views\Admin\EgitimcilerBolumu.cshtml"
           Write(i.Fotograf);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 37 "E:\Tüm Projeler\.Net-Core-MVC-Basit-Projeler\Course App\Crud\Crud\Views\Admin\EgitimcilerBolumu.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("       \r\n\r\n        </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Egitmen>> Html { get; private set; }
    }
}
#pragma warning restore 1591
