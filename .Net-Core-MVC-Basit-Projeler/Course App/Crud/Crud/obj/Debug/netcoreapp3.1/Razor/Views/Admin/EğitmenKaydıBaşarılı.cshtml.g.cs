#pragma checksum "E:\Tüm Projeler\.Net-Core-MVC-Basit-Projeler\Course App\Crud\Crud\Views\Admin\EğitmenKaydıBaşarılı.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54e03941c400f5e230f1be74fff476c1a656b28e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EğitmenKaydıBaşarılı), @"mvc.1.0.view", @"/Views/Admin/EğitmenKaydıBaşarılı.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54e03941c400f5e230f1be74fff476c1a656b28e", @"/Views/Admin/EğitmenKaydıBaşarılı.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c402e0156657abbd65c5377838b3b7bfb231cd50", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_EğitmenKaydıBaşarılı : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Egitmen>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Tüm Projeler\.Net-Core-MVC-Basit-Projeler\Course App\Crud\Crud\Views\Admin\EğitmenKaydıBaşarılı.cshtml"
  
    ViewData["Title"] = "EğitmenKaydıBaşarılı";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<section class=\"m-4\">\r\n \r\n\r\n    <h1 style=\"text-align:center; \"> Kayıt Edilmiş Eğitmen</h1>\r\n    <h2 style=\"color: green \"> Kayıt Başarı ile tamamlandı </h2>\r\n\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54e03941c400f5e230f1be74fff476c1a656b28e3836", async() => {
                WriteLiteral("\r\n\r\n\r\n        <div class=\"row form-group row\">\r\n            <div class=\"col-2\">  <label class=\"col-form-label\">İd</label> </div>\r\n            <div class=\"col-10\"> <input class=\"form-control\" readonly>");
#nullable restore
#line 22 "E:\Tüm Projeler\.Net-Core-MVC-Basit-Projeler\Course App\Crud\Crud\Views\Admin\EğitmenKaydıBaşarılı.cshtml"
                                                                 Write(Model.id);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </div>\r\n        </div>\r\n\r\n        <div class=\"row form-group row\">\r\n            <div class=\"col-2\">  <label class=\"col-form-label\">İsim</label> </div>\r\n            <div class=\"col-10\"> <input class=\"form-control\" readonly>");
#nullable restore
#line 27 "E:\Tüm Projeler\.Net-Core-MVC-Basit-Projeler\Course App\Crud\Crud\Views\Admin\EğitmenKaydıBaşarılı.cshtml"
                                                                 Write(Model.isim);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </div>\r\n        </div>\r\n\r\n        <div class=\"row form-group row\">\r\n            <div class=\"col-2\">  <label class=\"col-form-label\">Soyisim</label> </div>\r\n            <div class=\"col-10\"> <input class=\"form-control\" readonly>");
#nullable restore
#line 32 "E:\Tüm Projeler\.Net-Core-MVC-Basit-Projeler\Course App\Crud\Crud\Views\Admin\EğitmenKaydıBaşarılı.cshtml"
                                                                 Write(Model.soyisim);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </div>\r\n        </div>\r\n\r\n        <div class=\"row form-group row\">\r\n            <div class=\"col-2\">  <label class=\"col-form-label\">Telefon</label> </div>\r\n            <div class=\"col-10\"> <input class=\"form-control\" readonly> ");
#nullable restore
#line 37 "E:\Tüm Projeler\.Net-Core-MVC-Basit-Projeler\Course App\Crud\Crud\Views\Admin\EğitmenKaydıBaşarılı.cshtml"
                                                                  Write(Model.Telefon);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n        </div>\r\n\r\n        <div class=\"row form-group row\">\r\n            <div class=\"col-2\">  <label class=\"col-form-label\">E-mail</label> </div>\r\n            <div class=\"col-10\"> <input class=\"form-control\" readonly>");
#nullable restore
#line 42 "E:\Tüm Projeler\.Net-Core-MVC-Basit-Projeler\Course App\Crud\Crud\Views\Admin\EğitmenKaydıBaşarılı.cshtml"
                                                                 Write(Model.email);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </div>\r\n        </div>\r\n\r\n        <div class=\"row form-group row\">\r\n            <div class=\"col-2\">  <label class=\"col-form-label\">Açıklama</label> </div>\r\n            <div class=\"col-10\"> <input class=\"form-control\" readonly>");
#nullable restore
#line 47 "E:\Tüm Projeler\.Net-Core-MVC-Basit-Projeler\Course App\Crud\Crud\Views\Admin\EğitmenKaydıBaşarılı.cshtml"
                                                                 Write(Model.açiklama);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </div>\r\n        </div>\r\n\r\n        <div class=\"row form-group row\">\r\n            <div class=\"col-2\">  <label class=\"col-form-label\">Fotograf</label> </div>\r\n            <div class=\"col-10\"> <input class=\"form-control\" readonly>");
#nullable restore
#line 52 "E:\Tüm Projeler\.Net-Core-MVC-Basit-Projeler\Course App\Crud\Crud\Views\Admin\EğitmenKaydıBaşarılı.cshtml"
                                                                 Write(Model.Fotograf);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </div>\r\n        </div>\r\n\r\n\r\n        <div style=\"text-align: center\">\r\n            <button class=\"btn btn-success btn-outline-light\"> Brawwwwwoooooooooo Fiyuuuuu   </button>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Egitmen> Html { get; private set; }
    }
}
#pragma warning restore 1591
