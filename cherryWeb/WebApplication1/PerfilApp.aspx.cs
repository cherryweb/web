using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using cherryWebClassLibrary;

namespace WebApplication1
{
    public partial class PerfilApp : System.Web.UI.Page
    {
        protected ENUsuario usuarioActual = null;
        protected ENAplicaciones aplicaciones = null;

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
                //BotonDescargar.Visible = false;
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
              // Response.redirect("otherpage.aspx?id=5");
           
            
           /* if (Request.QueryString["id"] !=null)
            {*/
                 //nombre = Request.QueryString["id"];

            //}

            aplicaciones = ENAplicaciones.getAplicacion(Request.QueryString["id"]);

            Label5.Text = aplicaciones.Nombre;

            Label6.Text = aplicaciones.Descripcion;

            Label7.Text = "Hola";

            duenyo.Text = aplicaciones.Usuario;
            Button1.Text = "Ver perfil";


               //string nombre = Response.QueryString["id"];

               //Response.RedirectToRoute("PerfilApp", nombre);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ENUsuario user = null;

            user = ENUsuario.getUsuario(aplicaciones.Usuario);
            Label7.Text = user.Apodo;
            //Response.Redirect("PerfilApp.aspx?id=" + aplicaciones.Nombre);
            Response.Redirect("PerfilUsuario.aspx?id=" + user.Apodo);
        }

        protected void BotonDescargar_Click(object sender, EventArgs e)
        {
            try
            {

                ENValoracionesUsuario valoracion = new ENValoracionesUsuario((Convert.ToInt32(ValoracionList.Text)), usuarioActual.Apodo, Label5.Text);

                valoracion.valorar();

            }
            catch (Exception ex) { LabelError.Text = "Tienes que iniciar sesión"; }
        }
    }
}