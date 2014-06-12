using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using cherryWebClassLibrary;

namespace WebApplication1
{
    public partial class Aplicaciones : System.Web.UI.Page
    {

        protected ENUsuario usuarioActual;

        //Comprueba si el usuario esta logueado y le asigna una página maestra.
        protected override void OnPreInit(EventArgs e)
        {
            if (((ENUsuario)Session["Usuario"]) != null)
                usuarioActual = ((ENUsuario)Session["Usuario"]);

            if (usuarioActual != null)
            {
                MasterPageFile = "privada.Master";
            }
            else
            {
                MasterPageFile = "Site.Master";
            }
        }
        //Busca una aplicacion
        protected void BotonBuscar_Click(object sender, EventArgs e)
        {
            string buscado;
            buscado = BusquedaAplicacion.Text;

            ENAplicaciones aplicaciones;

            try
            {
                bool esApp = true;

                if (!esApp)//mira si existe
                    throw new Exception("No existe la App");
                else
                {
                    aplicaciones = ENAplicaciones.getAplicacion(buscado);//Coge los datos de la aplicación buscada

                    Response.Redirect("PerfilApp.aspx?id=" + aplicaciones.Nombre); //Redirige al usuario al perfil de esa aplicación
                }
            }
            catch (Exception a) { LabelError.Text = "No existe la App"; } //Si la aplicación no existe mostrará este error.
        }

    }
}
