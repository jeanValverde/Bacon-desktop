#pragma checksum "C:\Users\CRISTIAN\Desktop\proyecto_portafolio\bacon-desktop\Views\BarNotificacion\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ad2b5d470e336901cdf4324c2337c93ec0a7650"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BarNotificacion_Index), @"mvc.1.0.view", @"/Views/BarNotificacion/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BarNotificacion/Index.cshtml", typeof(AspNetCore.Views_BarNotificacion_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ad2b5d470e336901cdf4324c2337c93ec0a7650", @"/Views/BarNotificacion/Index.cshtml")]
    public class Views_BarNotificacion_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 5078, true);
            WriteLiteral(@"<bacon class=""task-bacon"">

    <div class=""row"">

        <div class=""col-12"">
            <div class=""card"">
                <div class=""card-body"">
                    <h4 class=""card-title"">Notificaciones a Bar</h4>
                    <p class=""card-description"">Todas las notificaciones a Bar</p>
                    <div class=""row"">
                        <div class=""col-md-6 text-center text-primary display-4"">Notificaciones enviadas</div>
                        <div class=""col-md-6 text-center text-primary display-4"">Notificaciones recibidas</div>
                    </div>
                    <div class=""mt-5"">
                        <div class=""timeline"" id=""notify"">



                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>


    <script type=""text/javascript"">

        
        function barNotificacion() {

            getNotificacionDeBar();
            
            

            timerBarNo");
            WriteLiteral(@"tificacion = true;

        }


        function getNotificacionDeBar() {
            ipcRenderer.send(""async-BarNotificacion-notify"", 'buscar');
            var loader = document.getElementById('loader');
            loader.style.visibility = '';
        }
     
        ipcRenderer.on('asynchronous-reply-BarNotificacion-notify', (event, arg) => {

            //enviadas - recibidas

            let message = """";

            document.getElementById('notify').innerHTML = """";


            for (var i = 0; i < arg.length; i++) {

                //recibida
                if (arg[i].rol.id_rol == 6) {


                        message += ""<div class='timeline-wrapper timeline-inverted timeline-wrapper-"" + colorNotify(arg[i].estado) +  ""'><div class='timeline-badge'></div><div class='timeline-panel'><div class='timeline-heading'>""
                            + ""<h6 class='timeline-title'>"" + arg[i].asunto + ""</h6></div><div class='timeline-body'>""
                            + ""<p>"" +");
            WriteLiteral(@" arg[i].descripcion + ""</p></div><div class='timeline-footer d-flex align-items-center flex-wrap'>""
                            + marcarLeida(arg[i].estado, arg[i].idNotificacion ) + "" <span class='ml-md-auto font-weight-bold'>"" + arg[i].fecha + ""</span>""
                            + ""</div></div></div>"" ;


                } else {
                    //enviada

                       message += ""<div class='timeline-wrapper timeline-wrapper-"" + colorNotify(arg[i].estado) + ""'><div class='timeline-badge'></div><div class='timeline-panel'><div class='timeline-heading'>""
                            + ""<h6 class='timeline-title'>"" + arg[i].asunto + ""</h6></div><div class='timeline-body'>""
                            + ""<p>"" + arg[i].descripcion + ""</p></div><div class='timeline-footer d-flex align-items-center flex-wrap'>""
                            + marcarLeidaEnviado(arg[i].estado) + "" <span class='ml-md-auto font-weight-bold'>"" + arg[i].fecha + ""</span>""
                            + ""</div></");
            WriteLiteral(@"div></div>"" ;

                }
            }


            document.getElementById('notify').innerHTML = message;


            var loader = document.getElementById('loader');
            loader.style.visibility = 'hidden';

        });


        function marcarLeida(estado, idNotificacion) {

                let status = ""<button type='button' onclick='cambiarEstadoNotificacion( "" + idNotificacion + "" )' class='btn btn-outline-secondary btn-rounded btn-icon mr-2'><i class='mdi mdi-heart-outline text-danger'></i></button><span>Marcar como leído</span>"";

                if (estado == 1) {
                    status = ""<i class='mdi mdi-check-all mr-1'></i><span>leído</span>"";
                }

                return status;
        }

         function marcarLeidaEnviado(estado) {

                let status = ""<i class='mdi mdi-check mr-1'></i><span>Enviado</span>"";

                if (estado == 1) {
                    status = ""<i class='mdi mdi-check-all mr-1'></i><span>");
            WriteLiteral(@"leído</span>"";
                }

                return status;
         }

        function colorNotify(estado) {
            let color = ""danger"";

            if (estado == 1) {
                color = ""info"";
            }

            return color;
        }

        function cambiarEstadoNotificacion(idNotificacion) {
            ipcRenderer.send(""async-BarNotificacion-notify-leido"", idNotificacion);
            var loader = document.getElementById('loader');
            loader.style.visibility = '';
        }


        ipcRenderer.on('asynchronous-reply-BarNotificacion-notify-leido', (event, arg) => {

            barNotificacion();
            var loader = document.getElementById('loader');
            loader.style.visibility = '';

        });


         setInterval(function () {
             if (timerBarNotificacion) {
                barNotificacion();
            }
        }, 60000);

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
