#pragma checksum "C:\Users\49826159859\Documents\Sprint4\SenaiMVC\Views\Cadastro\Sala.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5daef8a494c9603ecd478f1a05e36496a6dc2e8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cadastro_Sala), @"mvc.1.0.view", @"/Views/Cadastro/Sala.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cadastro/Sala.cshtml", typeof(AspNetCore.Views_Cadastro_Sala))]
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
#line 1 "C:\Users\49826159859\Documents\Sprint4\SenaiMVC\Views\_ViewImports.cshtml"
using SenaiMVC;

#line default
#line hidden
#line 2 "C:\Users\49826159859\Documents\Sprint4\SenaiMVC\Views\_ViewImports.cshtml"
using SenaiMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5daef8a494c9603ecd478f1a05e36496a6dc2e8f", @"/Views/Cadastro/Sala.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03d08c7d88117629d215b58a12d0fd588a7e8665", @"/Views/_ViewImports.cshtml")]
    public class Views_Cadastro_Sala : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 33, true);
            WriteLiteral("<!-- <form method=\"POST\" action=\'");
            EndContext();
            BeginContext(34, 26, false);
#line 1 "C:\Users\49826159859\Documents\Sprint4\SenaiMVC\Views\Cadastro\Sala.cshtml"
                            Write(Url.Action("", "Cadastro"));

#line default
#line hidden
            EndContext();
            BeginContext(60, 373, true);
            WriteLiteral(@"'>  -->

    <div class = ""recolher"">
        <label for =""sala"">Numero da sala</label>
        <br />
        <input id=""numero"" type=""numero"" maxlength=""2"" minlength=""1"" name=""sala"" />

        <label for =""capacidade"">Capacidade da sala</label>
        <br />
        <input id=""numero"" type=""numero"" maxlength=""2"" minlength=""1"" name=""capacidade"" />
    </div>");
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
