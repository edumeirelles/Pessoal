#pragma checksum "D:\OneDrive\Blue\Repositórios\Teste_EMix\Views\Cep\WebSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f49003e6a949a057c4884dad3250868af5b24212"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cep_WebSearch), @"mvc.1.0.view", @"/Views/Cep/WebSearch.cshtml")]
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
#line 1 "D:\OneDrive\Blue\Repositórios\Teste_EMix\Views\_ViewImports.cshtml"
using Teste_EMix;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\OneDrive\Blue\Repositórios\Teste_EMix\Views\_ViewImports.cshtml"
using Teste_EMix.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f49003e6a949a057c4884dad3250868af5b24212", @"/Views/Cep/WebSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87dd3004e6910bf8ef70e230ed200a33f49bdc6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Cep_WebSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CEP>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">

    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">CEP</th>
                <th scope=""col"">Logradouro</th>
                <th scope=""col"">Complemento</th>
                <th scope=""col"">Bairro</th>
                <th scope=""col"">Localidade</th>
                <th scope=""col"">UF</th>
                
            </tr>
        </thead>
        <tbody>
            <tr>
                

                <td>");
#nullable restore
#line 21 "D:\OneDrive\Blue\Repositórios\Teste_EMix\Views\Cep\WebSearch.cshtml"
               Write(Model.cep);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "D:\OneDrive\Blue\Repositórios\Teste_EMix\Views\Cep\WebSearch.cshtml"
               Write(Model.logradouro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "D:\OneDrive\Blue\Repositórios\Teste_EMix\Views\Cep\WebSearch.cshtml"
               Write(Model.complemento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "D:\OneDrive\Blue\Repositórios\Teste_EMix\Views\Cep\WebSearch.cshtml"
               Write(Model.bairro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "D:\OneDrive\Blue\Repositórios\Teste_EMix\Views\Cep\WebSearch.cshtml"
               Write(Model.localidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "D:\OneDrive\Blue\Repositórios\Teste_EMix\Views\Cep\WebSearch.cshtml"
               Write(Model.uf);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                \r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CEP> Html { get; private set; }
    }
}
#pragma warning restore 1591