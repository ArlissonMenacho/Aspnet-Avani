#pragma checksum "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Cliente\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4f18ed0f7bf8faa4a6229054818b88341e0438b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Listar), @"mvc.1.0.view", @"/Views/Cliente/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Listar.cshtml", typeof(AspNetCore.Views_Cliente_Listar))]
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
#line 1 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\_ViewImports.cshtml"
using Montadora_Arlisson_Menacho;

#line default
#line hidden
#line 2 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\_ViewImports.cshtml"
using Montadora_Arlisson_Menacho.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4f18ed0f7bf8faa4a6229054818b88341e0438b", @"/Views/Cliente/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e93620759f5f896d8da91477b395d6f9283de4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Montadora_Arlisson_Menacho.Models.Cliente>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Cliente\Listar.cshtml"
  
    ViewData["Title"] = "Listar";

#line default
#line hidden
            BeginContext(107, 30, true);
            WriteLiteral("\r\n<h2>Listar</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(137, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8c9ddfa3be44830995e613b774a0f75", async() => {
                BeginContext(160, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(174, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(267, 50, false);
#line 16 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.DataNascimento));

#line default
#line hidden
            EndContext();
            BeginContext(317, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(373, 44, false);
#line 19 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.Endereco));

#line default
#line hidden
            EndContext();
            BeginContext(417, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(473, 42, false);
#line 22 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(515, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(571, 50, false);
#line 25 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.Orgaoexpedidor));

#line default
#line hidden
            EndContext();
            BeginContext(621, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(677, 38, false);
#line 28 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.Rg));

#line default
#line hidden
            EndContext();
            BeginContext(715, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(771, 39, false);
#line 31 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.Cpf));

#line default
#line hidden
            EndContext();
            BeginContext(810, 65, true);
            WriteLiteral("\r\n            </th>          \r\n            <th>\r\n                ");
            EndContext();
            BeginContext(876, 40, false);
#line 34 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(916, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 40 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Cliente\Listar.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1034, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1083, 49, false);
#line 43 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.DataNascimento));

#line default
#line hidden
            EndContext();
            BeginContext(1132, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1188, 43, false);
#line 46 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.Endereco));

#line default
#line hidden
            EndContext();
            BeginContext(1231, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1287, 41, false);
#line 49 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(1328, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1384, 49, false);
#line 52 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.Orgaoexpedidor));

#line default
#line hidden
            EndContext();
            BeginContext(1433, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1489, 37, false);
#line 55 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.Rg));

#line default
#line hidden
            EndContext();
            BeginContext(1526, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1582, 38, false);
#line 58 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cpf));

#line default
#line hidden
            EndContext();
            BeginContext(1620, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1676, 37, false);
#line 61 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1713, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1769, 39, false);
#line 64 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1808, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1864, 65, false);
#line 67 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Cliente\Listar.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1929, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1950, 71, false);
#line 68 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Cliente\Listar.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2021, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2042, 69, false);
#line 69 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Cliente\Listar.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2111, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 72 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Cliente\Listar.cshtml"
}

#line default
#line hidden
            BeginContext(2150, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Montadora_Arlisson_Menacho.Models.Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
