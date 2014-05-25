using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using cherryWebClassLibrary;

namespace WebApplication1
{
    public partial class Inicio : System.Web.UI.Page
    {

        protected ENUsuario usuarioActual;

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

        protected void BotonBuscar_Click(object sender, EventArgs e)
        {
            string buscado;
            buscado = BuscarBox.Text;

            ENAplicaciones aplicaciones;

            aplicaciones = ENAplicaciones.getAplicacion(buscado);

            
        }
    }
}