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
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] != null)
                Response.Redirect("inicio.aspx");


            ContrasenaBox.TextMode = TextBoxMode.Password;
            Contrasena2Box.TextMode = TextBoxMode.Password;
        }
        //Confirma el registro del usuario
        protected void Enviar_Click(object sender, EventArgs e)
        {
            //Se hacen diversas comprobaciones antes de guardar el usuario, que ponga campos obligatorios, que no exista ya, que las contraseñas coincidan o que su e-mail sea correcto.
            if (UsuarioBox.Text != "" && ContrasenaBox.Text != "" && Contrasena2Box.Text != "" && EmailBox.Text != "")
            {
                if (!ENUsuario.existeUsuario(UsuarioBox.Text))
                {
                    if (ContrasenaBox.Text == Contrasena2Box.Text)
                    {
                        if (IsEmailAllowed(EmailBox.Text))
                        {

                            ENUsuario nuevo = new ENUsuario(UsuarioBox.Text, NombreBox.Text, ContrasenaBox.Text, EmailBox.Text, DespPaises.Text, BoletinBox.Checked);
                            Response.Write(nuevo.Apodo + " " + nuevo.Nombre + " " + nuevo.Password + " " + nuevo.Email + " " + nuevo.Pais + " " + nuevo.Boletin);
                            nuevo.commitDB();

                            if (TwitterBox.Text != "")
                            {
                                ENRedesSociales.nueva_red_social(UsuarioBox.Text, "Twitter", TwitterBox.Text);
                            }
                            if (FacebookBox.Text != "")
                            {
                                ENRedesSociales.nueva_red_social(UsuarioBox.Text, "Facebook", FacebookBox.Text);
                            }

                            Response.Redirect("inicio.aspx?nuevo=ok");
                        }
                        else
                        {
                            ErrorEmail.Text = "Se esperaba un correo";

                        }
                    }
                    else
                    {

                        ErrorContrasena.Text = "Las contraseñas no son iguales";
                    }

                }
                else
                {
                    ErrorApodo.Text = "Este usuario ya existe";
                }

            }
            else
            {
                ErrorLb.Text = "Faltan campos por rellenar";
            }


        }

        //Método que comprueba que un e-mail cumple el formato.
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

         
    }
}
