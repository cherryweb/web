using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cherryWebClassLibrary
{
    public class ValoracionesUsuarioCAD
    {
        public ValoracionesUsuarioCAD(string db)
        {
            //Adquiere la cadena de conexión desde un único sitio.
        }

        public void nueva_valoracion(ENValoracionesUsuario valoracion)
        {
            //Código para crear una nueva valoracion
            string orden = "INSERT INTO VALORACIONES VALUES('" + valoracion.Apodo + "', " + valoracion.Aplicacion + "', " + valoracion.Valoracion + "')";
        }

        public void aplicacionesConValoracionSuperiorA(int valoracion)
        {
            //Saca las aplicaciones que tienen una valoracion superior a la indicada
            string orden = "SELECT aplicacion FROM VALORACIONES WHERE valoracion > '" + valoracion + "'";
        }

        public void aplicacionesConValoracionInferiorA(int valoracion)
        {
            //Saca las aplicaciones que tienen una valoracion inferior a la indicada
            string orden = "SELECT aplicacion FROM VALORACIONES WHERE valoracion < '" + valoracion + "'";
        }
    }
}
