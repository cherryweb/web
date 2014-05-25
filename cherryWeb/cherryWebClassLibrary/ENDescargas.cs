using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cherryWebClassLibrary
{
    public class ENDescargas
    {
        private int numerototal;
        private string aplicacion;
        private int valoracion;
        private string usuario;

        //Datos

        DescargasCAD m_cc;

        public ENDescargas(int nt = 0, string a = "", int v = "", string u = "")
        {
            numerototal = nt;
            aplicacion = a;
            valoracion = v;
            usuario = u;
        }

        public void nueva_descarga()
        {
            try
            {
                m_cc = new DescargasCAD("../webdb");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando usuario");

                return;
            }
        }

        public int Numerototal
        {
            get { return numerototal; }
            set { numerototal = value; }
        }

        public string Aplicacion
        {
            get { return aplicacion; }
            set { aplicacion = value; }
        }
        public int Valoracion
        {
            get { return valoracion; }
            set { valoracion = value; }
        }
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
    }
}
