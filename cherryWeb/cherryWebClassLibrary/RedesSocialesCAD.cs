using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cherryWebClassLibrary
{
    public class RedesSocialesCAD
    {
        public RedesSocialesCAD(string db)
        {
            //Adquiere la cadena de conexión desde un único sitio.
        }

        public void agregar_cuenta_usuario(ENRedesSociales red)
        {
            string orden = "INSERT INTO RedesSociales VALUES('" + red.Usuario + "', " + red.RedSocial + "')";
        }

        public void actualizar_cuenta(string usuario, string cuenta)
        {
            string orden = "UPDATE RedesSociales " + "set redesSociales = '" + cuenta + "' WHERE usuario = ' " + usuario + "'";
        }
    }
}
