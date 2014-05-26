using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using cherryWebClassLibrary;

namespace WebApplication1
{
    public partial class PerfilUsuario : System.Web.UI.Page
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
           if (((ENUsuario)Session["Usuario"]) != null)
                usuarioActual = ((ENUsuario)Session["Usuario"]);

            ENUsuario user;

            user = ENUsuario.getUsuario(Request.QueryString["id"]);

            LApodo2.Text = user.Apodo;
            LContacto2.Text = user.Email;
            LPais2.Text = user.Pais;
           
        }
    }
}