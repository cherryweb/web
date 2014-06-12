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

        //Carga los datos del usuario.
        protected void Page_Load(object sender, EventArgs e)
        {
            //Añade en los labels los datos del usuario.
            LApodo2.Text = usuarioActual.Apodo;
            LContacto2.Text = usuarioActual.Email;
            LPais2.Text = usuarioActual.Pais;
            ImagenPerfil.ImageUrl = @"Imagenes/" + usuarioActual.Imagen;

            //Mostramos los mensajes que ha recibido el usuario

            mens = new ENMensaje();
            List<ENMensaje> mensajes;

            mensajes = mens.dameMensajes(usuarioActual.Apodo);

            this.GridView1.DataSource = mensajes;
            GridView1.DataBind();

            //Mostramos sus redes Sociales.

            string twitter = "";
            try
            {
                twitter = ENRedesSociales.dame_Twitter(usuarioActual.Apodo);
                LTwitter2.Text = twitter;
            }
            catch (Exception f)
            {
                LTwitter2.Text = "";
            }

            string facebook = "";

            try
            {
                facebook = ENRedesSociales.dame_Facebook(usuarioActual.Apodo);
                LFacebook2.Text = facebook;
            }
            catch (Exception w)
            {
                LFacebook2.Text = "";
            }
        }

        protected void EditarPerfil_Click(object sender, EventArgs e)
        {
            Response.Redirect("editarPerfil.aspx");
        }
    }
}