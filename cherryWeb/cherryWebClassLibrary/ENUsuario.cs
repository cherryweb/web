using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cherryWebClassLibrary
{
    public class ENUsuario
    {
        //Propiedades
        private string apodo;
        private string nombre;
        private string password;
        private string email;
        private string pais;
        private bool boletin;
        private string imagen;
        private string paypal;

        //Datos
       // private UsuarioCAD m_cc;

        public ENUsuario(string a = "", string n = "", string p = "", string e = "", string ps = "", bool b = false, string i = "ImagenNoDisp.jpg")
        {
            apodo = a;
            nombre = n;
            password = p;
            email = e;
            pais = ps;
            boletin = b;
            imagen = i;
            //paypal = p;
        }

        //Funcion que llama al CAD para comprobar que los datos introducidos existen
        static public bool esUsuario(string apodo, string password)
        {
           // UsuarioCAD cad = new UsuarioCAD(this);
            return UsuarioCAD.esUsuario(apodo, password);
        }

        //Funcion para comprobar si existe un usuario mediante un apodo
        static public bool existeUsuario(string apodo)
        {
            // UsuarioCAD cad = new UsuarioCAD(this);
            return UsuarioCAD.existeUsuario(apodo);
        }

        //Funcion que devuelve un usuario
        static public ENUsuario getUsuario(string apodo)
        {
            return UsuarioCAD.dameUsuario(apodo);
        }

        //Funcion que llama al CAD para actualizar un usuario
        public bool actualizaUsuario(ENUsuario usuario)
        {
            UsuarioCAD cad = new UsuarioCAD(this);
            return cad.actualizar_usuario(usuario);
        }

      
        public string Apodo
        {
            get { return apodo; }
            set { apodo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }
        public bool Boletin
        {
            get { return boletin; }
            set { boletin = value; }
        }
        public string Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }
        public string Paypal
        {
            get { return paypal; }
            set { paypal = value; }
        }

        public bool commitDB()
        {
            // Inserta en la DB si no existe y lo actualiza si ya existía
            UsuarioCAD cad = new UsuarioCAD(this);
            return cad.nuevo_usuario();
        }
    }    
}
