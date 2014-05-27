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
        protected ENMensaje mens;
        protected List<ENMensaje> mensajes;
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

            mensajes = mens.dameMensajes(user.Apodo);

            this.GridView1.DataSource = mensajes;
            GridView1.DataBind();
        }

        protected void BotonMensajes_Click(object sender, EventArgs e)
        {
            string mensaje = Mensajes.Text;

            ENMensaje msg = new ENMensaje(usuarioActual.Apodo,LApodo2.Text,mensaje);

            msg.nuevoMensaje();
        }
    }
}