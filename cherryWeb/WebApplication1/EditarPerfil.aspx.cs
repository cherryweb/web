using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using cherryWebClassLibrary;
using System.Text.RegularExpressions;

namespace WebApplication1
{
    public partial class EditarPerfil : System.Web.UI.Page
    {
        protected ENUsuario usuarioActual;
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

        //Carga los datos del usuario en los TextBox.
        protected void Page_Load(object sender, EventArgs e)
        {

            ContrasenaBox.TextMode = TextBoxMode.Password;
            ContrasenaRepetirBox.TextMode = TextBoxMode.Password;

           //Redes Sociales.

           string twitter = "";

           try
           {
               twitter = ENRedesSociales.dame_Twitter(usuarioActual.Apodo);
           }
           catch (Exception w)
           {
               twitter = "";
           }
           string facebook = "";

           try
           {
               facebook = ENRedesSociales.dame_Facebook(usuarioActual.Apodo);
           }
           catch (Exception o)
           {
               twitter = "";
           }
            
            if (NombreBox.Text == "")
            {
                NombreBox.Text = usuarioActual.Nombre;
            }
            if (ContrasenaBox.Text == "")
            {
                ContrasenaBox.Text = usuarioActual.Password;
                if (ContrasenaRepetirBox.Text == "")
                {
                    ContrasenaRepetirBox.Text = usuarioActual.Password;
                }
            }
            else
            {

                if (ContrasenaBox.Text != ContrasenaRepetirBox.Text)
                {
                    ContrasenaBox.Text = usuarioActual.Password;
                }
               
            }
            if (ContactoBox.Text == "")
            {
                ContactoBox.Text = usuarioActual.Email;
            }
            else
            {
                if (!IsEmailAllowed(ContactoBox.Text))
                {
                    ContactoBox.Text = usuarioActual.Email;
                }
            }
            if (DespPaises.Text == "")
            {
                DespPaises.Text = usuarioActual.Pais;
            }
            if (FacebookBox.Text == "")
            {
                FacebookBox.Text = facebook;
            }
            if (TwitterBox.Text == "")
            {
                TwitterBox.Text = twitter;
            }
        }

        //Comprueba que el Email introducido tenga el formato correcto.
        private static bool IsEmailAllowed(string text)
        {
            bool blnValidEmail = false;
            Regex regEMail = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (text.Length > 0)
            {
                blnValidEmail = regEMail.IsMatch(text);
            }

            return blnValidEmail;
        }
        //Confirma los cambios realizados por el usuario en su perfil.
        protected void Confirmar_Click(object sender, EventArgs e)
        {
            string d = NombreBox.Text;

            //Subir imagen
            string fileName="";
            if (ImgBox.HasFile)//Comprueba si el FileUpload tiene un archivo
            {
                fileName = ImgBox.FileName;//Guarda el nombre del archivo
                ImgBox.SaveAs(@"C:\web\cherryWeb\WebApplication1\Imagenes\" + fileName);//Guarda el archivo en la ruta
            }
            
            //Actualiza los datos del usuario
            string ruta = fileName;
            ENUsuario nuevo = new ENUsuario(usuarioActual.Apodo, NombreBox.Text, ContrasenaBox.Text, ContactoBox.Text, DespPaises.Text, usuarioActual.Boletin, ruta);
            Response.Write(nuevo.Apodo + " " + nuevo.Nombre + " " + nuevo.Password + " " + nuevo.Email + " " + nuevo.Pais + " " + nuevo.Boletin + " " + nuevo.Imagen);
            nuevo.actualizaUsuario(nuevo);

            //Actualiza las redes Sociales del usuario
            if (TwitterBox.Text != "")
            {
                ENRedesSociales.nueva_red_social(usuarioActual.Apodo, "Twitter", TwitterBox.Text);
            }
            if (FacebookBox.Text != "")
            {
                ENRedesSociales.nueva_red_social(usuarioActual.Apodo, "Facebook", FacebookBox.Text);
            }

            //Por seguridad cerramos la sesión.
            Session.Abandon();

            Response.Redirect("inicio.aspx");
        }
    }
}