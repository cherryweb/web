using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cherryWebClassLibrary
{
    public class ENValoracionesUsuario
    {
        private int valoracion;
        private string apodo;
        private string aplicacion;

        //Datos

        private ValoracionesUsuarioCAD m_cc;

        //Constructor
        public ENValoracionesUsuario(int v = 0, string a = "", string n = "")
        {
            valoracion = v;
            apodo = a;
            aplicacion = n;
        }

        //Funcion que llama a ValoracionesUsuarioCAD para valorar una App
        public bool valorar()
        {
            ValoracionesUsuarioCAD cad = new ValoracionesUsuarioCAD(this);
            return cad.nueva_valoracion();
        }
        
        //Funcion que devuelve la valoracion de una App
        static public int getValoracion(string aplicacion)
        {
            return ValoracionesUsuarioCAD.get_valoracion(aplicacion);
        }

        
        public int Valoracion
        {
            get { return valoracion; }
            set { valoracion = value; }
        }

        public string Apodo
        {
            get { return apodo; }
            set { apodo = value; }
        }

        public string Aplicacion
        {
            get { return aplicacion; }
            set { aplicacion = value; }
        }
    }
}
