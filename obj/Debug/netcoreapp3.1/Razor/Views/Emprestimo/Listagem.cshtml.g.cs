#pragma checksum "C:\Users\Carlos\Desktop\Senac_2023\Biblioteca\Views\Emprestimo\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "caf27edba54d230dc275f608a0e461ff3fcba487"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Emprestimo_Listagem), @"mvc.1.0.view", @"/Views/Emprestimo/Listagem.cshtml")]
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
#line 1 "C:\Users\Carlos\Desktop\Senac_2023\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Carlos\Desktop\Senac_2023\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"caf27edba54d230dc275f608a0e461ff3fcba487", @"/Views/Emprestimo/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Emprestimo_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Emprestimo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Usuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Livro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "10", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "15", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "30", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "50", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Carlos\Desktop\Senac_2023\Biblioteca\Views\Emprestimo\Listagem.cshtml"
  

    ViewData["Title"] = "Listagem de Empréstimos";



    int filtroPorPagina = Int32.Parse(ViewData["livrosPorPagina"].ToString());//conversao object int object -> int
    int paginaAtual = Int32.Parse(ViewData["paginaAtual"].ToString());

    int numLivrosPorPagina = (Model.Count < filtroPorPagina ? Model.Count : filtroPorPagina);
    int numTotalDePagina = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Carlos\Desktop\Senac_2023\Biblioteca\Views\Emprestimo\Listagem.cshtml"
 if (numLivrosPorPagina > 0)
{
    numTotalDePagina = Model.Count / numLivrosPorPagina + (Model.Count % numLivrosPorPagina == 0 ? 0 : 1);
  
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Carlos\Desktop\Senac_2023\Biblioteca\Views\Emprestimo\Listagem.cshtml"
 if (Model.Count > 0)

{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "caf27edba54d230dc275f608a0e461ff3fcba4876887", async() => {
                WriteLiteral("\r\n                <div class=\"form-group mb-2\">\r\n                    <select name=\"TipoFiltro\" class=\"form-control\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "caf27edba54d230dc275f608a0e461ff3fcba4877295", async() => {
                    WriteLiteral("Usuário");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "caf27edba54d230dc275f608a0e461ff3fcba4878543", async() => {
                    WriteLiteral("Livro");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </select>
                </div>
                <div class=""form-group mb-2 mx-sm-3"">
                    <input type=""text"" placeholder=""Filtro"" name=""Filtro"" class=""form-control"" />
                </div>
                    <select name=""itensPorPagina"" id=""itensPorPagina"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "caf27edba54d230dc275f608a0e461ff3fcba48710107", async() => {
                    WriteLiteral("10 livros");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "caf27edba54d230dc275f608a0e461ff3fcba48711358", async() => {
                    WriteLiteral("15 livros");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "caf27edba54d230dc275f608a0e461ff3fcba48712609", async() => {
                    WriteLiteral("30 livros");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "caf27edba54d230dc275f608a0e461ff3fcba48713860", async() => {
                    WriteLiteral("50 livros");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "caf27edba54d230dc275f608a0e461ff3fcba48715111", async() => {
                    WriteLiteral("Todos os livros");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\Carlos\Desktop\Senac_2023\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                          WriteLiteral(Model.Count);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"


                    </select>
                    <button type=""submit"" class=""btn btn-primary mb-2"">Pesquisar</button>
                    <div id=""seletorPaginas"">


                    </div>

                     <div id=""SeletorPaginas"">

                    <span>Página:</span>

");
#nullable restore
#line 52 "C:\Users\Carlos\Desktop\Senac_2023\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                     for (int i = 1; i <= numTotalDePagina; i++)

                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                        <span><a");
                BeginWriteAttribute("href", " href=\"", 1997, "\"", 2039, 2);
                WriteAttributeValue("", 2004, "/Emprestimo/Listagem?PaginaAtual=", 2004, 33, true);
#nullable restore
#line 56 "C:\Users\Carlos\Desktop\Senac_2023\Biblioteca\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 2037, i, 2037, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 56 "C:\Users\Carlos\Desktop\Senac_2023\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                                                       Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral(",</a></span>\r\n");
#nullable restore
#line 57 "C:\Users\Carlos\Desktop\Senac_2023\Biblioteca\Views\Emprestimo\Listagem.cshtml"

                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-md-12"">
            <table class=""table table-striped"">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Usuario</th>
                        <th>Data Empréstimo</th>
                        <th>Data Devolução</th>
                        <th>Livro</th>
                        <th>Autor</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 80 "C:\Users\Carlos\Desktop\Senac_2023\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                     for (int i = (paginaAtual - 1) * numLivrosPorPagina; i < (numLivrosPorPagina * paginaAtual < Model.Count ? numLivrosPorPagina * paginaAtual : Model.Count); i++)
                    {
                        var dDev = Int32.Parse(Model[i].DataDevolucao.Day.ToString());
                        var mDev = Int32.Parse(Model[i].DataDevolucao.Month.ToString());
                        var aDev = Int32.Parse(Model[i].DataDevolucao.Year.ToString());
                        var dataDev = new DateTime(aDev, mDev, dDev);
                        //var dataDev = new DateTime(dDev)


                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\Users\Carlos\Desktop\Senac_2023\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                         if (@Model[i].Devolvido == false)
                        {


                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\Carlos\Desktop\Senac_2023\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                             if (dataDev < @System.DateTime.Now)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr class=\"table-danger\">\r\n                                    <td class=\"emprestimo\">");
#nullable restore
#line 96 "C:\Users\Carlos\Desktop\Senac_2023\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                                      Write(Model[i].Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"emprestimo\">");
#nullable restore
#line 97 "C:\Users\Carlos\Desktop\Senac_2023\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                                      Write(Model[i].NomeUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"emprestimo\">");
#nullable restore
#line 98 "C:\Users\Carlos\Desktop\Senac_2023\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                                      Write(Model[i].DataEmprestimo.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"emprestimo\">");
#nullable restore
#line 99 "C:\Users\Carlos\Desktop\Senac_2023\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                                      Write(Model[i].DataDevolucao.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"emprestimo\">");
#nullable restore
#line 100 "C:\Users\Carlos\Desktop\Senac_2023\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                                      Write(Model[i].Livro.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"emprestimo\">");
#nullable restore
#line 101 "C:\Users\Carlos\Desktop\Senac_2023\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                                      Write(Model[i].Livro.Autor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"emprestimo\"><a");
            BeginWriteAttribute("href", " href=\"", 4167, "\"", 4205, 2);
            WriteAttributeValue("", 4174, "/Emprestimo/Edicao/", 4174, 19, true);
#nullable restore
#line 102 "C:\Users\Carlos\Desktop\Senac_2023\Biblioteca\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 4193, Model[i].Id, 4193, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\r\n                                </tr>\r\n");
#nullable restore
#line 104 "C:\Users\Carlos\Desktop\Senac_2023\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td class=\"emprestimo\">");
#nullable restore
#line 108 "C:\Users\Carlos\Desktop\Senac_2023\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                                      Write(Model[i].Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"emprestimo\">");
#nullable restore
#line 109 "C:\Users\Carlos\Desktop\Senac_2023\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                                      Write(Model[i].NomeUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"emprestimo\">");
#nullable restore
#line 110 "C:\Users\Carlos\Desktop\Senac_2023\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                                      Write(Model[i].DataEmprestimo.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"emprestimo\">");
#nullable restore
#line 111 "C:\Users\Carlos\Desktop\Senac_2023\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                                      Write(Model[i].DataDevolucao.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"emprestimo\">");
#nullable restore
#line 112 "C:\Users\Carlos\Desktop\Senac_2023\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                                      Write(Model[i].Livro.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"emprestimo\">");
#nullable restore
#line 113 "C:\Users\Carlos\Desktop\Senac_2023\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                                      Write(Model[i].Livro.Autor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"emprestimo\"><a");
            BeginWriteAttribute("href", " href=\"", 5023, "\"", 5061, 2);
            WriteAttributeValue("", 5030, "/Emprestimo/Edicao/", 5030, 19, true);
#nullable restore
#line 114 "C:\Users\Carlos\Desktop\Senac_2023\Biblioteca\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 5049, Model[i].Id, 5049, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\r\n                                </tr>\r\n");
#nullable restore
#line 116 "C:\Users\Carlos\Desktop\Senac_2023\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "C:\Users\Carlos\Desktop\Senac_2023\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                             

                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "C:\Users\Carlos\Desktop\Senac_2023\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 124 "C:\Users\Carlos\Desktop\Senac_2023\Biblioteca\Views\Emprestimo\Listagem.cshtml"

}

else

{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p> Nenhum registro encontrado!</p>\r\n");
#nullable restore
#line 131 "C:\Users\Carlos\Desktop\Senac_2023\Biblioteca\Views\Emprestimo\Listagem.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Emprestimo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
