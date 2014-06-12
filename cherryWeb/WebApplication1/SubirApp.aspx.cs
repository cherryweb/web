using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using cherryWebClassLibrary;

namespace WebApplication1
{
    public partial class SubirApp : System.Web.UI.Page
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
            
        }
        //Confirma la subida una aplicación.
        protected void subirapp_subirboton_Click1(object sender, EventArgs e)
        {
            //Imagen de la aplicacion.
            string fileName;
            if (FileUpload1.HasFile)
            {
                fileName = FileUpload1.FileName;//Guarda el nombre de la imagen
                FileUpload1.SaveAs(@"C:\web\cherryWeb\WebApplication1\Imagenes\" + fileName);//Guarda la imagen en la web.
            }
            else
            {
                fileName = "ImagenNoDisp.jpg";//Si no hay imagen pondrá una por defecto.
            }

            //Guarda el archivo de la aplicación
            string appName = "";
            
            if (FileUpload2.HasFile)
            {
                appName = FileUpload2.FileName;
                string nomApp = subirapp_nombretextbox.Text + ".txt";
                if (appName.Contains("txt") && appName == nomApp)//Comprueba que el archivo contiene el formato correcto
                {
                    FileUpload2.SaveAs(@"C:\web\cherryWeb\WebApplication1\Aplicaciones\" + appName);//Guarda la aplicación en la web

                    string ruta = fileName;
                    try
                    {
                        ENAplicaciones nuevo = new ENAplicaciones(subirapp_nombretextbox.Text, subirapp_categoriaList.Text, subirapp_descripciontextbox.Text, usuarioActual.Apodo, (Convert.ToInt32(subirapp_pvptextbox.Text)), ruta);
                        Response.Write(nuevo.Nombre + " " + nuevo.Categoria + " " + nuevo.Descripcion + " " + nuevo.Usuario + " " + nuevo.PVP + " " + nuevo.Imagen);
                        nuevo.commitDB();
                        Response.Redirect("inicio.aspx?nuevo=ok");
                    }
                    catch (Exception i)
                    {
                        AplicacionYaExiste.Text = "Esta aplicación ya existe";//Si subes una aplicación ya existente dará error
                    }
                   
                }
            }
            else
            {
                LabelErrorApp.Text = "No has subido una aplicacion"; //Si no subes ningún fichero dará error.
            }

            
        }
    }
}