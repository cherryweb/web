using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using cherryWebClassLibrary;

namespace WebApplication1
{
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] != null)
                Response.Redirect("inicio.aspx");
        }

        protected void Enviar_Click(object sender, EventArgs e)
        {
            //int d = 0;

            /*if (nuevoApellidos.Text == "" || nuevoDNI.Text == "" || nuevoNombre.Text == "" || nuevoPass.Text == "" || nuevoDNI.Text.Length != 8)
            {
                PanelError.Visible = true;
            }
            else
            {*/
               /* try
                {*/
                    ENUsuario nuevo = new ENUsuario(UsuarioBox.Text, NombreBox.Text, ContrasenaBox.Text, EmailBox.Text, DespPaises.Text, BoletinBox.Checked);
                    Response.Write(nuevo.Apodo + " " + nuevo.Nombre + " " + nuevo.Password + " " + nuevo.Email + " " + nuevo.Pais + " " + nuevo.Boletin);
                    nuevo.commitDB();

                    Response.Redirect("inicio.aspx?nuevo=ok");
                //}
                //catch (Exception a) { return false; }
            //}

        }
    }
}
