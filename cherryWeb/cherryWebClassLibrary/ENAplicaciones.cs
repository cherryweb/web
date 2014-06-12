using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cherryWebClassLibrary
{
    public class ENAplicaciones
    {
        private string nombre;
        private string descripcion;
        private string categoria;
        private float peso;
        private float _PVP;
        private string imagen;
        private string usuario;

        public ENAplicaciones(string n = "", string c = "", string d = "", string u="", float pv = 0, string i = "")
        {
            nombre = n;
            descripcion = d;
            categoria = c;
            imagen = i;
            //peso = p;
            usuario = u;
            _PVP = pv;
        }

        //Devuelve el objeto aplicación
        static public ENAplicaciones getAplicacion(string aplicacion)
        {
            return AplicacionCAD.dameAplicacion(aplicacion);
        }

        //Getters/setters 

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public float Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public float PVP
        {
            get { return _PVP; }
            set { _PVP = value; }
        }
        public string Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }


        public bool commitDB()
        {
            // Inserta en la DB si no existe llamando al CAD de la aplicación, o lo actualiza si ya existía
            AplicacionCAD cad = new AplicacionCAD(this);
            return cad.nueva_aplicacion();
        }

        
    }
}
