#pragma checksum "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Montador\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "001fcab3831fe28a168313314e7262046e0f677a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Montador_Listar), @"mvc.1.0.view", @"/Views/Montador/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Montador/Listar.cshtml", typeof(AspNetCore.Views_Montador_Listar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"001fcab3831fe28a168313314e7262046e0f677a", @"/Views/Montador/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e93620759f5f896d8da91477b395d6f9283de4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Montador_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Montadora_Arlisson_Menacho.Models.Montador>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Novo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Montador\Listar.cshtml"
  
    ViewData["Title"] = "Listar";

#line default
#line hidden
            BeginContext(108, 43, true);
            WriteLiteral("\r\n<h2>Lista de Montadores</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(151, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "997c7faf78df491fabd53212ca4ac957", async() => {
                BeginContext(172, 18, true);
                WriteLiteral("Cadastrar Montador");
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
            BeginContext(194, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(287, 43, false);
#line 16 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Montador\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.Salario));

#line default
#line hidden
            EndContext();
            BeginContext(330, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(386, 39, false);
#line 19 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Montador\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.Cpf));

#line default
#line hidden
            EndContext();
            BeginContext(425, 66, true);
            WriteLiteral("\r\n            </th>           \r\n            <th>\r\n                ");
            EndContext();
            BeginContext(492, 40, false);
#line 22 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Montador\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(532, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Montador\Listar.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(650, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(699, 42, false);
#line 31 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Montador\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.Salario));

#line default
#line hidden
            EndContext();
            BeginContext(741, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(797, 38, false);
#line 34 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Montador\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cpf));

#line default
#line hidden
            EndContext();
            BeginContext(835, 67, true);
            WriteLiteral("\r\n            </td>            \r\n            <td>\r\n                ");
            EndContext();
            BeginContext(903, 39, false);
#line 37 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Montador\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(942, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(998, 65, false);
#line 40 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Montador\Listar.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1063, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1084, 71, false);
#line 41 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Montador\Listar.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1155, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1176, 69, false);
#line 42 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Montador\Listar.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1245, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 45 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Montador\Listar.cshtml"
}

#line default
#line hidden
            BeginContext(1284, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Montadora_Arlisson_Menacho.Models.Montador>> Html { get; private set; }
    }
}
#pragma warning restore 1591
