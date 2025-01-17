#pragma checksum "C:\Users\jean\Desktop\PORTAFOLIO DE TITULO\bacon-desktop\Views\Garzon\IndexGarzon.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6ff008cb8b2ea8a925aa89ec8e861ec96718051"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Garzon_IndexGarzon), @"mvc.1.0.view", @"/Views/Garzon/IndexGarzon.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Garzon/IndexGarzon.cshtml", typeof(AspNetCore.Views_Garzon_IndexGarzon))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6ff008cb8b2ea8a925aa89ec8e861ec96718051", @"/Views/Garzon/IndexGarzon.cshtml")]
    public class Views_Garzon_IndexGarzon : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 8723, true);
            WriteLiteral(@"<bacon class=""task-bacon"">
    <!--inicio row-->
    <div class=""row"">
        <div class=""col-md-5 grid-margin"">
            <div class=""card"">
                <div class=""card-body"">
                    <h4 class=""card-title"">Totalidad de recetas ordenadas cristian</h4>
                    <div class=""template-demo"">
                        <table class=""table mb-0"">
                            <thead>
                                <tr>
                                    <th class=""pl-0"">Receta</th>
                                    <th class=""text-right"">Cantidad</th>
                                </tr>
                            </thead>
                            <tbody id=""target-ord-garzon-cantidad"">
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>

        <div class=""col-md-7 grid-margin"">
            <div class=""card-rows"" id=""target-ord-garzon"">
                ");
            WriteLiteral(@"<!--inicio tarjeta de ordenes--->
                <!--fin tarjeta de ordenes--->
            </div>
        </div>
        <!---fin columnas--->
    </div>
    <!--fin row-->
    <script type=""text/javascript"">
        function garzonIndex() {
            cargarOrdenesGarzon();
            cargarRecetasGarzon();
            timerIndexGarzon = false;
        }
        //para cargar las ordenes
        function cargarOrdenesGarzon() {
            //Carga de las ordenes Cocina
            ipcRenderer.send(""async-ordenes-garzon"", 'buscar');
            var loader = document.getElementById('loader');
            loader.style.visibility = '';
            ///fin de carga de ordenes
        }
        ipcRenderer.on('asynchronous-reply-ordenes-garzon', (event, arg) => {
            let message = """";
            document.getElementById('target-ord-garzon').innerHTML = """";
            for (var i = 0; i < arg.length; i++) {
                message += ""<div class='col-12 mb-4'  ><div class='card'>");
            WriteLiteral(@"<div class='card-body'><h4 class='card-title mt-3'>Orden número #"" + arg[i].orden.idOrden + ""</h4>""
                    + ""<div class='badge badge-outline-primary mr-1'>Mesa #"" + arg[i].orden.cliente.mesa.numeroMesa + ""</div>""
                    + ""<div class='badge badge-outline-primary mr-1'>"" + arg[i].orden.tiempoPreparacion + "" minutos</div>""
                    + ""<div class='badge badge-info mr-1'>"" + arg[i].orden.fechaCompleta + ""</div> ""
                    + ""<div class='badge badge-"" + estadoOrdenStyle(arg[i].orden.fechaCompleta) + "" mr-1'>"" + estadoOrden(arg[i].orden.fechaCompleta) + ""</div> ""
                    + ""<div class='badge badge-info mr-1 mt-1'>"" + calcularMinutos(arg[i].orden.fechaCompleta) + "" minutos</div> ""
                    + ""<br />""
                    + ""<table class='table mb-0'><thead><tr><th class='pl-0'>Receta</th><th class='text-right'>Cantidad</th></tr></thead><tbody>"";
                if (arg[i].recetaOrdenada.length == 0) {
                    message += ""<tr>");
            WriteLiteral(@"<td class='pl-0'  >N/A</td><td class='pl-0'  >N/A</td></tr>"";
                }
                for (var j = 0; j < arg[i].recetaOrdenada.length; j++) {
                    message += ""<tr><td class='pl-0'  >"" + cortarTextoConPuntos(arg[i].recetaOrdenada[j].receta.nombreReceta, 37) + ""</td>""
                        + ""<td class='pr-0 text-center'><div class='badge badge-pill badge-outline-primary'>""
                        + arg[i].recetaOrdenada[j].cantidad + ""</div></td></tr>"";
                }
                message += ""</tbody></table>""
                    + ""<h4 class='card-title mt-3'>Descripción</h4>""
                    + ""<p class='card-text'>"" + arg[i].orden.descripcion + ""</p>""
                    + ""<table class='table mb-0'><thead><tr><th class='text-right'>"";
                if (arg[i].estadoOrden === 1) {
                    message += ""<button type='button' onclick='modalAnularOrdenGarzon("" + arg[i].orden.idOrden + "")' class='btn btn-outline-warning btn-fw'>Anular Orden</button>""");
            WriteLiteral(@";
                }
                if (arg[i].estadoOrden === 2) {
                    message += ""<button type='button' onclick='servirOrden("" + arg[i].orden.idOrden + "")' class='btn btn-outline-success btn-fw'>Orden Servida</button>"";
                }
                message += ""</th></tr></thead></table>""
                    + ""</div ></div ></div > "";
            }
            document.getElementById('target-ord-garzon').innerHTML = message;
            var loader = document.getElementById('loader');
            loader.style.visibility = 'hidden';
            cargarTextos();
        });
        //fin para cargar las ordenes
        //para cargar las recetas
        function cargarRecetasGarzon() {
            ipcRenderer.send(""async-grupo-recetas-garzon"", 'buscar');
            var loader = document.getElementById('loader');
            loader.style.visibility = '';
        }
        ipcRenderer.on('asynchronous-reply-grupo-recetas-garzon', (event, arg) => {
            let message ");
            WriteLiteral(@"= """";
            //aca se carga la lista de recetas
            document.getElementById('target-ord-garzon-cantidad').innerHTML = """";
            if (arg.length == 0) {
                message += ""<tr><td class='pl-0'>N/A</td>td class='pl-0'>N/A</td></tr>"";
            }
            for (var i = 0; i < arg.length; i++) {
                message += ""<tr><td class='pl-0'><a href='#23423423' onclick='modalRecetaGarzon( "" + arg[i].receta.idReceta + ""  )' >"" + cortarTextoConPuntos(arg[i].receta.nombreReceta, 34) + ""</a>""
                    + ""</td><td class='pr-0 text-right'><div class='badge badge-pill badge-primary'>"" + arg[i].cantidad + ""</div></td></tr>"";
            }
            document.getElementById('target-ord-garzon-cantidad').innerHTML = message;
            var loader = document.getElementById('loader');
            loader.style.visibility = 'hidden';
        });
        //fin para cargar la cantidad de receta
        //para completar la orden
        function servirOrden(idOrden) {");
            WriteLiteral(@"
            ipcRenderer.send(""async-receta-servirOrden-garzon"", idOrden);
            var loader = document.getElementById('loader');
            loader.style.visibility = '';
        }
        ipcRenderer.on('asynchronous-reply-receta-servirOrden-garzon', (event, arg) => {
            garzonIndex();
        });
        //fin para completar la orden
        function modalRecetaGarzon(idReceta) {
            ipcRenderer.send(""modalReceta-window-garzon"", idReceta);
        }
        function modalAnularOrdenGarzon(idOrden) {
            ipcRenderer.send(""modalAnular-window-garzon"", idOrden);
        }
        function cortarTextoConPuntos(texto, limite) {
            var puntosSuspensivos = ""..."";
            if (texto.length > limite) {
                texto = texto.substring(0, limite) + puntosSuspensivos;
            }
            return texto;
        }
        function cargarTextosGarzon() {
            var highlightedItems = document.querySelector("".cortarTexto"");
            highl");
            WriteLiteral(@"ightedItems.forEach(function (userItem) {
                var text = cortarTextoConPuntos(userItem.innerHTML, 6);
                userItem.innerHTML = text;
            });
        }
        function calcularMinutosGarzon(fecha) {
            var today = new Date();
            var Christmas = new Date(fecha);
            var diffMs = (Christmas - today); // milliseconds between now & Christmas
            var diffMins = Math.round(((diffMs % 86400000) % 3600000) / 60000); // minutes
            return diffMins * -1;
        }
        function estadoOrdenGarzon(fecha) {
            var minutos = calcularMinutosGarzon(fecha);
            var integer = parseInt(minutos, 10);
            var estado = ""Ingresado"";
            if (integer < 15) {
                estado = ""Limite""
            }
            if (integer < 5) {
                estado = ""Retrasado""
            }
            return estado;
        }
        function estadoOrdenStyleGarzon(fecha) {
            var minutos = calcu");
            WriteLiteral(@"larMinutosGarzon(fecha);
            var integer = parseInt(minutos, 10);
            var estado = ""info"";
            if (integer < 15) {
                estado = ""danger""
            }
            if (integer < 5) {
                estado = ""Retrasado""
            }
            return estado;
        }
        setInterval(function () {
            if (timerIndexGarzon) {
                cargarOrdenesGarzon();
                cargarRecetasGarzon();
            }
        }, 60000);
    </script>


</bacon>");
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
