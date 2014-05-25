using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using cherryWebClassLibrary;

namespace WebApplication1
{
    public partial class MiPerfil : System.Web.UI.Page
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
            LApodo2.Text = ((ENUsuario)Session["Usuario"]).Apodo;
            LContacto2.Text = ((ENUsuario)Session["Usuario"]).Email;
            LPais2.Text = ((ENUsuario)Session["Usuario"]).Pais;
        }
    }
}