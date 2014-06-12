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

        protected void Page_Load(object sender, EventArgs e)
        {
            if (((ENUsuario)Session["Usuario"]) != null)
                usuarioActual = ((ENUsuario)Session["Usuario"]);

            InicioPass.TextMode = TextBoxMode.Password;
            InicioPass.TextMode = TextBoxMode.Password;
        }

        //Iniciar sesión.
        protected void BotonIniciar_Click(object sender, EventArgs e)
        {
            //Comprueba que el usuario que se esta intentando loguear existe con ese Apodo y esa contraseña.
            try
            {
                bool existe = true;

                existe = ENUsuario.esUsuario(InicioNom.Text, InicioPass.Text);

                if (!existe)
                    throw new Exception("El usuario no existe con esa contraseña");//Si no exisste el usuario lanza error.
                else//Si existe el usuario crea la sesión.
                {
                    Session["Usuario"] = ENUsuario.getUsuario(InicioNom.Text);
                    Response.Redirect("inicio.aspx");
                }
            }
            catch (Exception a) { LabelError.Text = a.Message; }
            
        }
    }
}