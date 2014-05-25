using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using cherryWebClassLibrary;

namespace WebApplication1
{
    public partial class InicioSesion : System.Web.UI.Page
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

       /* void _Default_Init(object sender, EventArgs e)
        {
            
        }*/

        protected void Page_Load(object sender, EventArgs e)
        {
            if (((ENUsuario)Session["Usuario"]) != null)
                usuarioActual = ((ENUsuario)Session["Usuario"]);
        }

        protected void BotonIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                bool esUsuario = true;

                if (!esUsuario)
                    throw new Exception("El usuario no existe con esa contraseña");
                else
                {
                    Session["Usuario"] = ENUsuario.getUsuario(InicioNom.Text);
                    Response.Redirect("inicio.aspx");
                }
            }
            catch (Exception a) { LabelError.Text = a.Message; }
        }
    }
}