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
        protected ENMensaje mens;
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
            LApodo2.Text = usuarioActual.Apodo;
            LContacto2.Text = usuarioActual.Email;
            LPais2.Text = usuarioActual.Pais;

            mens = new ENMensaje();
            List<ENMensaje> mensajes;

            mensajes = mens.dameMensajes(usuarioActual.Apodo);

            this.GridView1.DataSource = mensajes;
            GridView1.DataBind();

        }
    }
}