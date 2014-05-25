using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using cherryWebClassLibrary;

namespace WebApplication1
{
    public partial class SubirApp : System.Web.UI.Page
    {

        protected ENUsuario usuarioActual = null;

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

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void subirapp_subirboton_Click1(object sender, EventArgs e)
        {
            ENAplicaciones nuevo = new ENAplicaciones(subirapp_nombretextbox.Text, subirapp_categoriaList.Text, subirapp_descripciontextbox.Text, usuarioActual.Apodo, (Convert.ToInt32(subirapp_pvptextbox.Text)));
            Response.Write(nuevo.Nombre + " " + nuevo.Categoria + " " + nuevo.Descripcion + " " + nuevo.Usuario + " " + nuevo.PVP);
            nuevo.commitDB();

            Response.Redirect("inicio.aspx?nuevo=ok");
        }
    }
}