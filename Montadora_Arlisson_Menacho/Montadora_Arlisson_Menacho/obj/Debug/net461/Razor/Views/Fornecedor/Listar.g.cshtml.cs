#pragma checksum "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Fornecedor\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68b8aa48dce948b8611427ce6ef85c2d99366790"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fornecedor_Listar), @"mvc.1.0.view", @"/Views/Fornecedor/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Fornecedor/Listar.cshtml", typeof(AspNetCore.Views_Fornecedor_Listar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68b8aa48dce948b8611427ce6ef85c2d99366790", @"/Views/Fornecedor/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e93620759f5f896d8da91477b395d6f9283de4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Fornecedor_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Montadora_Arlisson_Menacho.Models.Fornecedor>>
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
            BeginContext(66, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Fornecedor\Listar.cshtml"
  
    ViewData["Title"] = "Listar";

#line default
#line hidden
            BeginContext(110, 30, true);
            WriteLiteral("\r\n<h2>Listar</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(140, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16da387cb79b4884babc4725a64007ca", async() => {
                BeginContext(163, 10, true);
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
            BeginContext(177, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(270, 44, false);
#line 16 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Fornecedor\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.Endereco));

#line default
#line hidden
            EndContext();
            BeginContext(314, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(370, 39, false);
#line 19 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Fornecedor\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.Cpf));

#line default
#line hidden
            EndContext();
            BeginContext(409, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(465, 38, false);
#line 22 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Fornecedor\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(503, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(559, 40, false);
#line 25 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Fornecedor\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(599, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 31 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Fornecedor\Listar.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(717, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(766, 43, false);
#line 34 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Fornecedor\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.Endereco));

#line default
#line hidden
            EndContext();
            BeginContext(809, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(865, 38, false);
#line 37 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Fornecedor\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cpf));

#line default
#line hidden
            EndContext();
            BeginContext(903, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(959, 37, false);
#line 40 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Fornecedor\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(996, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1052, 39, false);
#line 43 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Fornecedor\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1091, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1147, 65, false);
#line 46 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Fornecedor\Listar.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1212, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1233, 71, false);
#line 47 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Fornecedor\Listar.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1304, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1325, 69, false);
#line 48 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Fornecedor\Listar.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1394, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 51 "D:\Arquivos\Donwload's\Antigos\Github\Aspnet-Avani\Montadora_Arlisson_Menacho\Montadora_Arlisson_Menacho\Views\Fornecedor\Listar.cshtml"
}

#line default
#line hidden
            BeginContext(1433, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Montadora_Arlisson_Menacho.Models.Fornecedor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
