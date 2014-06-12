using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cherryWebClassLibrary
{
    public class ENMediaAplicaciones
    {
        private float media;
        private string aplicacion;

        //Datos
        //Constructor
        public ENMediaAplicaciones(float m = 0, string a = "")
        {
            media = m;
            aplicacion = a;
        }

        //Getters y Setters para el calculo de la media de las aplicaciones
        private float Media
        {
            get { return media; }
            set { media = value; }
        }

        private string Aplicacion
        {
            get { return aplicacion; }
            set { aplicacion = value; }
        }

    }
}
