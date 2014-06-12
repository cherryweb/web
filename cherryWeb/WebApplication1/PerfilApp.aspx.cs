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
                //BotonDescargar.Visible = false;
            }
        }

        //Carga los datos de la aplicación
        protected void Page_Load(object sender, EventArgs e)
        {
            aplicaciones = ENAplicaciones.getAplicacion(Request.QueryString["id"]);

            Label5.Text = aplicaciones.Nombre;

            Label6.Text = aplicaciones.Descripcion;

            Label7.Text = aplicaciones.PVP.ToString();            

            Label8.Text = ENValoracionesUsuario.getValoracion(aplicaciones.Nombre).ToString();

            ImagenApp.ImageUrl = @"Imagenes/" + aplicaciones.Imagen;

            duenyo.Text = aplicaciones.Usuario;

            Button1.Text = "Ver perfil";
        }

        //Ir al perfil del usuario que ha subido la aplicacion
        protected void Button1_Click(object sender, EventArgs e)
        {
            ENUsuario user = null;

            user = ENUsuario.getUsuario(aplicaciones.Usuario);//Coge el usuario que ha subido la aplicacion.
            Label7.Text = user.Apodo;
            Response.Redirect("PerfilUsuario.aspx?id=" + user.Apodo);//Redirect hacia su perfil al pulsar el boton.
        }
        //Boton de descargar la aplicacion
        protected void BotonDescargar_Click(object sender, EventArgs e)
        {
            try
            {
                //Establece la valoración que se da al descargar.

                ENValoracionesUsuario valoracion = new ENValoracionesUsuario((Convert.ToInt32(ValoracionList.Text)), usuarioActual.Apodo, Label5.Text);

                valoracion.valorar();

                //Descarga del fichero de la aplicación.

                string fileName = Label5.Text + ".txt";

                string filePath = @"C:\web\cherryWeb\WebApplication1\Aplicaciones\";

                Response.Clear();

                Response.ContentType = "application/txt";

                Response.AddHeader("Content-Disposition", "attachment; filename =" + fileName);

                Response.WriteFile(filePath + fileName);

                Response.End();
            }
            catch (Exception ex) { LabelError.Text = "Tienes que iniciar sesión"; } //Lanza error si el usuario no esta logueado.
        }
    }
}