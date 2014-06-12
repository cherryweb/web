using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cherryWebClassLibrary
{
    public class MediaAplicacionesCAD
    {

        public MediaAplicacionesCAD(string db)
        {

        }

        //Funcion que calcula la nota media de una aplicacion
        public float CalculoMediaAplicacion(string aplicacion)
        {
            float media = 0;
            string orden = "SELECT avg(valoracion) where aplicacion = ' " + aplicacion + "'";
            return media;
        }
    }
}
