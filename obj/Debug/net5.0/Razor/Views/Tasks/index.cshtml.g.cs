#pragma checksum "C:\Users\Diego\DotNet_Revisao\aspdotnetcore(minicurso)\Tarefas\Views\Tasks\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30783d48f6d36deb403818852c9dc4d74f711220"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tasks_index), @"mvc.1.0.view", @"/Views/Tasks/index.cshtml")]
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
#line 1 "C:\Users\Diego\DotNet_Revisao\aspdotnetcore(minicurso)\Tarefas\Views\_ViewImports.cshtml"
using Tarefas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Diego\DotNet_Revisao\aspdotnetcore(minicurso)\Tarefas\Views\_ViewImports.cshtml"
using Tarefas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30783d48f6d36deb403818852c9dc4d74f711220", @"/Views/Tasks/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22b1d4ceb903fd790b0685a9067e34add11b7dd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Tasks_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TaskViewModel>
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
#line 3 "C:\Users\Diego\DotNet_Revisao\aspdotnetcore(minicurso)\Tarefas\Views\Tasks\index.cshtml"
  
    ViewData["Title"] = "Gerenciar Lista de tarefas";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"panel panel-default task-panel\">\r\n    <div class=\"panel-heading\">");
#nullable restore
#line 7 "C:\Users\Diego\DotNet_Revisao\aspdotnetcore(minicurso)\Tarefas\Views\Tasks\index.cshtml"
                          Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n    <table class=\"table table-hover\">\r\n        <thead>\r\n            <tr>\r\n                <td>&#x2714;</td>\r\n                <td>Tarefas</td>\r\n                <td>Previsão</td>\r\n            </tr>\r\n        </thead>\r\n    \r\n");
#nullable restore
#line 18 "C:\Users\Diego\DotNet_Revisao\aspdotnetcore(minicurso)\Tarefas\Views\Tasks\index.cshtml"
         foreach (var item in Model.TasksItens)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                <input type=\"checkbox\"");
            BeginWriteAttribute("name", " name=\"", 543, "\"", 558, 1);
#nullable restore
#line 22 "C:\Users\Diego\DotNet_Revisao\aspdotnetcore(minicurso)\Tarefas\Views\Tasks\index.cshtml"
WriteAttributeValue("", 550, item.Id, 550, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" value=\"true\" class=\"done-checkbox\">\r\n            </td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\Diego\DotNet_Revisao\aspdotnetcore(minicurso)\Tarefas\Views\Tasks\index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Diego\DotNet_Revisao\aspdotnetcore(minicurso)\Tarefas\Views\Tasks\index.cshtml"
           Write(item.Dataconclusion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>        \r\n");
#nullable restore
#line 27 "C:\Users\Diego\DotNet_Revisao\aspdotnetcore(minicurso)\Tarefas\Views\Tasks\index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n\r\n    <div class=\"panel-footer add-item-form\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30783d48f6d36deb403818852c9dc4d74f7112205688", async() => {
                WriteLiteral(@"
            <div id=""add-item-error"" class=""text-danger""></div>
            <label for=""add-item-title"">Incluir Nova Tarefa: </label>
            <input id=""add-item-title"">
            <button type=""button"" id=""add-item-button"">Incluir</button>
        ");
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
            WriteLiteral("\r\n    </div>\r\n</div>    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TaskViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591