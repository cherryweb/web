using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cherryWebClassLibrary
{
    public class DescargasCAD
    {
        public DescargasCAD(string db)
        {
            //Adquiere la cadena de conexión desde un único sitio.
        }

        public void nueva_descarga(ENDescargas descarga)
        {
            string orden = "INSERT INTO Descargan VALUES('" + descarga.Usuario + "', " + descarga.Aplicacion + "', " + descarga.Valoracion + "')";
        }

        public int numeroDescargas(string aplicacion)
        {
            //Numero de descargas que tiene una aplicación.

            int numDescargas = 0;

            string orden = "SELECT COUNT(*) FROM DESCARGAN WHERE aplicacion = ' " + aplicacion + "'";

            return numDescargas;
        }
    }
}
