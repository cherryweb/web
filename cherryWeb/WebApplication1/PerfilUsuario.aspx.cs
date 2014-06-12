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
        protected ENMensaje msg;
        protected List<ENMensaje> mensajes;
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
        //Carga el perfil de un usuario
        protected void Page_Load(object sender, EventArgs e)
        {
           if (((ENUsuario)Session["Usuario"]) != null)
                usuarioActual = ((ENUsuario)Session["Usuario"]);


            //Obtenemos los datos del usuario.
            ENUsuario user;

            user = ENUsuario.getUsuario(Request.QueryString["id"]);

            //Los cargamos en los labels
            LApodo2.Text = user.Apodo;
            LContacto2.Text = user.Email;
            LPais2.Text = user.Pais;
           
            //Cargamos los mensajes que ha recibido ese usuario.
           mens = new ENMensaje();

           mensajes = mens.dameMensajes(user.Apodo);
           this.GridView1.DataSource = mensajes;
           GridView1.DataBind();

           ImagenPerfil.ImageUrl = @"Imagenes/" + user.Imagen;//Cargamos la imagen de perfil del usuario

            //Redes Sociales.

           string twitter = "";

           try
           {
               twitter = ENRedesSociales.dame_Twitter(user.Apodo);
               TwitterInfo.Text = twitter;
           }
           catch (Exception w)
           {
               TwitterInfo.Text = "";
           }
           string facebook = "";

           try
           {
               facebook = ENRedesSociales.dame_Facebook(user.Apodo);
               LFacebook2.Text = facebook;
           }
           catch (Exception o)
           {
               LFacebook2.Text = "";
           }
        }

        //Enviar un mensaje a un usuario.
        protected void BotonMensaje_Click(object sender, EventArgs e)
        {
            string mensaje = MensajeBox.Text;
            
            //msg = new ENMensaje();

            if (mensaje != "")//Solo se puede enviar si no es un mensaje vacio
            {
                if (usuarioActual != null)//Comprobamos que quien envia el mensaje este logueado.
                {
                    if (usuarioActual.Apodo != LApodo2.Text)//Comprobamos que no se envie el mensaje a si mismo.
                    {
                        //Creamos el mensaje y lo guardamos en la base de datos.

                        msg = new ENMensaje(usuarioActual.Apodo, LApodo2.Text, mensaje);

                        msg.nuevoMensaje();

                        Response.Redirect("PerfilUsuario.aspx?id=" + LApodo2.Text);
                    }
                    else
                    {
                        ErrorMsg.Text = "No puedes enviarte un mensaje a ti mismo";
                    }
                }
                else
                {
                    ErrorMsg.Text = "Debes loguearte para enviar un mensaje";
                }
            }

        }

      
    }
}