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
        private UsuarioCAD m_cc;

        public ENUsuario(string a = "", string n = "", string p = "", string e = "", string ps = "", bool b = false)
        {
            apodo = a;
            nombre = n;
            password = p;
            email = e;
            pais = ps;
            boletin = b;
            //imagen = i;
            //paypal = p;
        }

        /* public ENUsuario[] getUsuario()
        {
            
        }*/

       /* public void nuevo_usuario()
        {
            try
            {
                m_cc = new UsuarioCAD("../webdb");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando usuario");

                return;
            }
        }*/

       /* public void borrar_usuario()
        {
            try
            {
                m_cc = new UsuarioCAD("../webdb");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error borrando usuario");

                return;
            }
        }*/

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
        public string Foto
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
