#pragma checksum "C:\Users\jean\Desktop\PORTAFOLIO DE TITULO\bacon-desktop\Views\Cocina\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "892ba544c2ae04b376c39f6c5573de33ed6b9b91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cocina_Index), @"mvc.1.0.view", @"/Views/Cocina/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cocina/Index.cshtml", typeof(AspNetCore.Views_Cocina_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"892ba544c2ae04b376c39f6c5573de33ed6b9b91", @"/Views/Cocina/Index.cshtml")]
    public class Views_Cocina_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 19324, true);
            WriteLiteral(@"<bacon class=""task-bacon"">
    <!--inicio row-->
    <div class=""row"">
        <div class=""col-md-3 grid-margin"">
            <div class=""card"">
                <div class=""card-body"">
                    <h4 class=""card-title"">Totalidad de recetas ordenadas</h4>
                    <button class=""btn btn-primary"" id=""async-msg"" onclick=""algo(this)"" >Ping</button>
                    <div class=""alert alert-info"" id=""async-reply""></div>
                    <div class=""template-demo"">
                        <table class=""table mb-0"">
                            <thead>
                                <tr>
                                    <th class=""pl-0"">Receta</th>
                                    <th class=""text-right"">Cantidad</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td class=""pl-0"">
                                        <a href=""#r");
            WriteLiteral(@"eceta"" data-toggle=""modal"" data-target=""#receta"">Nombre de la receta</a>
                                        <div class=""modal fade"" id=""receta"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel-2"" style=""display: none;"" aria-hidden=""true"">
                                            <div class=""modal-dialog"" role=""document"">
                                                <div class=""modal-content"">
                                                    <div class=""modal-header"">
                                                        <h5 class=""modal-title"" id=""exampleModalLabel-2"">Nombre de la receta</h5>
                                                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                            <span aria-hidden=""true"">×</span>
                                                        </button>
                                                    </div>
                                ");
            WriteLiteral(@"                    <div class=""modal-body"">
                                                        <p>

                                                        </p>
                                                    </div>
                                                    <div class=""modal-footer"">
                                                        <button type=""button"" class=""btn btn-light"" data-dismiss=""modal"">Cerrar</button>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </td>
                                    <td class=""pr-0 text-right"">
                                        <div class=""badge badge-pill badge-primary"">3</div>
                                    </td>
                                </tr>
                                <tr>
                                    <");
            WriteLiteral(@"td class=""pl-0"">Rounded Info</td>
                                    <td class=""pr-0 text-right"">
                                        <div class=""badge badge-pill badge-primary"">5</div>
                                    </td>
                                </tr>
                                <tr>
                                    <td class=""pl-0"">Rounded Danger</td>
                                    <td class=""pr-0 text-right"">
                                        <div class=""badge badge-pill badge-primary"">1</div>
                                    </td>
                                </tr>
                                <tr>
                                    <td class=""pl-0"">Rounded Success</td>
                                    <td class=""pr-0 text-right"">
                                        <div class=""badge badge-pill badge-primary"">9</div>
                                    </td>
                                </tr>
                                <tr>
   ");
            WriteLiteral(@"                                 <td class=""pl-0"">Rounded Warning</td>
                                    <td class=""pr-0 text-right"">
                                        <div class=""badge badge-pill badge-primary"">4</div>
                                    </td>
                                </tr>
                                <tr>
                                    <td class=""pl-0"">Rounded Info</td>
                                    <td class=""pr-0 text-right"">
                                        <div class=""badge badge-pill badge-primary"">5</div>
                                    </td>
                                </tr>
                                <tr>
                                    <td class=""pl-0"">Rounded Success</td>
                                    <td class=""pr-0 text-right"">
                                        <div class=""badge badge-pill badge-primary"">9</div>
                                    </td>
                                </tr>
      ");
            WriteLiteral(@"                          <tr>
                                    <td class=""pl-0"">Rounded Warning</td>
                                    <td class=""pr-0 text-right"">
                                        <div class=""badge badge-pill badge-primary"">4</div>
                                    </td>
                                </tr>
                                <tr>
                                    <td class=""pl-0"">Rounded Info</td>
                                    <td class=""pr-0 text-right"">
                                        <div class=""badge badge-pill badge-primary"">5</div>
                                    </td>
                                </tr>
                                <tr>
                                    <td class=""pl-0"">Rounded Danger</td>
                                    <td class=""pr-0 text-right"">
                                        <div class=""badge badge-pill badge-primary"">1</div>
                                    </td>
           ");
            WriteLiteral(@"                     </tr>
                                <tr>
                                    <td class=""pl-0"">Rounded Success</td>
                                    <td class=""pr-0 text-right"">
                                        <div class=""badge badge-pill badge-primary"">9</div>
                                    </td>
                                </tr>
                                <tr>
                                    <td class=""pl-0"">Rounded Warning</td>
                                    <td class=""pr-0 text-right"">
                                        <div class=""badge badge-pill badge-primary"">4</div>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>

        <div class=""col-md-9 grid-margin"">

            <div class=""card-columns"">
                <!--inicio tarjeta de or");
            WriteLiteral(@"denes--->
                <div class=""card"">
                    <div class=""card-body"">
                        <h4 class=""card-title mt-3"">Orden número #452</h4>
                        <div class=""badge badge-outline-primary"">Mesa 19</div>
                        <div class=""badge badge-primary"">Categoria</div>
                        <div class=""badge badge-outline-primary"">40 minutos</div>
                        <div class=""badge badge-info mr-3"">Ingresado</div>
                        <br />
                        <table class=""table mb-0"">
                            <thead>
                                <tr>
                                    <th class=""pl-0"">Receta</th>
                                    <th class=""text-right"">Cantidad</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td class=""pl-0"">Rounded Primary</td>
                 ");
            WriteLiteral(@"                   <td class=""pr-0 text-right"">
                                        <div class=""badge badge-pill badge-outline-primary"">2</div>
                                    </td>
                                </tr>
                                <tr>
                                    <td class=""pl-0"">Rounded Info</td>
                                    <td class=""pr-0 text-right"">
                                        <div class=""badge badge-pill badge-outline-info"">5</div>
                                    </td>
                                </tr>
                                <tr>
                                    <td class=""pl-0"">Rounded Danger</td>
                                    <td class=""pr-0 text-right"">
                                        <div class=""badge badge-pill badge-outline-danger"">1</div>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
    ");
            WriteLiteral(@"                    <h4 class=""card-title mt-3"">Descripción</h4>
                        <p class=""card-text"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. </p>
                        <table class=""table mb-0"">
                            <thead>
                                <tr>
                                    <th class=""text-right""><button type=""button"" class=""btn btn-outline-success btn-fw"">Orden Lista</button></th>
                                </tr>
                            </thead>
                        </table>
                    </div>
                </div>
                <!--fin tarjeta de ordenes--->

                <div class=""card"">
                    <div class=""card-body"">
                        <h4 class=""card-title mt-3"">Orden número #432</h4>
                        <div class=""badge badge-outline-primary"">Mesa 20</div>
                        <div class=""badge badge-outline-primary"">30 minutos</div>
                        <div class=""badge ");
            WriteLiteral(@"badge-warning mr-3"">Limite</div>
                        <br />
                        <table class=""table mb-0"">
                            <thead>
                                <tr>
                                    <th class=""pl-0"">Receta</th>
                                    <th class=""text-right"">Cantidad</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td class=""pl-0"">Rounded Primary</td>
                                    <td class=""pr-0 text-right"">
                                        <div class=""badge badge-pill badge-outline-primary"">2</div>
                                    </td>
                                </tr>
                                <tr>
                                    <td class=""pl-0"">Rounded Success</td>
                                    <td class=""pr-0 text-right"">
                                    ");
            WriteLiteral(@"    <div class=""badge badge-pill badge-outline-success"">9</div>
                                    </td>
                                </tr>
                                <tr>
                                    <td class=""pl-0"">Rounded Warning</td>
                                    <td class=""pr-0 text-right"">
                                        <div class=""badge badge-pill badge-outline-warning"">4</div>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                        <h4 class=""card-title mt-3"">Descripción</h4>
                        <p class=""card-text"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. </p>
                        <table class=""table mb-0"">
                            <thead>
                                <tr>
                                    <th class=""text-right""><button type=""button"" class=""btn btn-outline-success btn-fw"">Orden Lista</butt");
            WriteLiteral(@"on></th>
                                </tr>
                            </thead>
                        </table>
                    </div>
                </div>
                <div class=""card"">
                    <div class=""card-body"">
                        <h4 class=""card-title mt-3"">Orden número #232</h4>
                        <div class=""badge badge-outline-primary"">Mesa 21</div>
                        <div class=""badge badge-outline-primary"">25 minutos</div>
                        <div class=""badge badge-danger mr-3"">Retrasado</div>

                        <br />
                        <table class=""table mb-0"">
                            <thead>
                                <tr>
                                    <th class=""pl-0"">Receta</th>
                                    <th class=""text-right"">Cantidad</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
");
            WriteLiteral(@"                                    <td class=""pl-0"">Rounded Primary</td>
                                    <td class=""pr-0 text-right"">
                                        <div class=""badge badge-pill badge-outline-primary"">2</div>
                                    </td>
                                </tr>
                                <tr>
                                    <td class=""pl-0"">Rounded Info</td>
                                    <td class=""pr-0 text-right"">
                                        <div class=""badge badge-pill badge-outline-info"">5</div>
                                    </td>
                                </tr>
                                <tr>
                                    <td class=""pl-0"">Rounded Danger</td>
                                    <td class=""pr-0 text-right"">
                                        <div class=""badge badge-pill badge-outline-danger"">1</div>
                                    </td>
                       ");
            WriteLiteral(@"         </tr>
                                <tr>
                                    <td class=""pl-0"">Rounded Success</td>
                                    <td class=""pr-0 text-right"">
                                        <div class=""badge badge-pill badge-outline-success"">9</div>
                                    </td>
                                </tr>
                                <tr>
                                    <td class=""pl-0"">Rounded Warning</td>
                                    <td class=""pr-0 text-right"">
                                        <div class=""badge badge-pill badge-outline-warning"">4</div>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                        <h4 class=""card-title mt-3"">Descripción</h4>
                        <p class=""card-text"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. </p>
                        <table cl");
            WriteLiteral(@"ass=""table mb-0"">
                            <thead>
                                <tr>
                                    <th class=""text-right""><button type=""button"" class=""btn btn-outline-success btn-fw"">Orden Lista</button></th>
                                </tr>
                            </thead>
                        </table>
                    </div>
                </div>

                <div class=""card"">
                    <div class=""card-body"">
                        <h4 class=""card-title mt-3"">Orden número #523</h4>
                        <div class=""badge badge-outline-primary"">Mesa 21</div>
                        <div class=""badge badge-outline-primary"">24 minutos</div>
                        <div class=""badge badge-primary mr-3"">Anulado</div>

                        <br />
                        <table class=""table mb-0"">
                            <thead>
                                <tr>
                                    <th class=""pl-0"">Receta<");
            WriteLiteral(@"/th>
                                    <th class=""text-right"">Cantidad</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td class=""pl-0"">Rounded Primary</td>
                                    <td class=""pr-0 text-right"">
                                        <div class=""badge badge-pill badge-outline-primary"">2</div>
                                    </td>
                                </tr>
                                <tr>
                                    <td class=""pl-0"">Rounded Info</td>
                                    <td class=""pr-0 text-right"">
                                        <div class=""badge badge-pill badge-outline-info"">5</div>
                                    </td>
                                </tr>
                                <tr>
                                    <td class=""pl-0"">Rounded Danger</td>
");
            WriteLiteral(@"                                    <td class=""pr-0 text-right"">
                                        <div class=""badge badge-pill badge-outline-danger"">1</div>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                        <h4 class=""card-title mt-3"">Descripción</h4>
                        <p class=""card-text"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. </p>
                        <table class=""table mb-0"">
                            <thead>
                                <tr>
                                    <th class=""text-right""><button type=""button"" class=""btn btn-outline-success btn-fw"">Orden Lista</button></th>
                                </tr>
                            </thead>
                        </table>
                    </div>
                </div>

            </div>


        </div>
        <!---fin columnas--->
    </div>
   ");
            WriteLiteral(@" <!--fin row-->


    <script type=""text/javascript"" >

        const { ipcRenderer } = require(""electron"");

        function algo(btn) {
            var loader = document.getElementById('loader');
            loader.style.visibility = '';
            btn.disabled = true;
            ipcRenderer.send(""async-msg"", 'ping');
        }

        ipcRenderer.on('asynchronous-reply', (event, arg) => {

            let message = """";


            for (var i = 0; i < arg.length; i++) {
                message += arg[i].nombres_personal + "" "";
            }
            
            document.getElementById('async-reply').innerHTML = message;

            var loader = document.getElementById('loader');
            loader.style.visibility = 'hidden';
            document.getElementById('async-msg').disabled = false;

        });

    </script>


</bacon>

");
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
