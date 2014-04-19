using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cherryWebClassLibrary
{
    public class ENUsuario
    {
        private String apodo;
        private String nombre;
        private String password;
        private String email_registro;
        private String email_contacto;
        private String pais;
        private Boolean boletin;
        private String imagen;

        public String Apodo
        {
            get { return apodo;}
            set { apodo = value;}
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }

        }
        public String Email_registro
        {
            get { return email_registro; }
            set { email_registro = value; }
        }

        public String Email_contacto
        {
            get { return email_contacto; }
            set { email_contacto = value; }
        }
        public String Pais
        {
            get { return pais; }
            set { pais = value; }
        }
        public Boolean Boletin
        {
            get { return boletin; }
            set { boletin = value; }
        }
    }

    public class ENAplicaciones
    {
        private String nombre;
        private String descripcion;
        private float peso;
        private float _PVP;
        private String imagen;

        public String Nombre
        {
            get { return nombre; }
            set {nombre=value;}
        }
        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public float Peso
        {
            get { return peso; }
            set { peso = value;}
        }
        public float PVP
        {
            get { return _PVP; }
            set { _PVP = value; }
        }
        private String Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }
    }

    public class ENMensaje
    {
        private int _ID;
        private String apodo_1;
        private String apodo_2;
        private DateTime fecha_hora;
        private String mensaje;

        private int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private String Apodo_1
        {
            get { return apodo_1; }
            set { apodo_1 = value; }
        }
        private String Apodo_2
        {
            get { return apodo_2; }
            set { apodo_2 = value; }
        }
        private DateTime Fecha_hora
        {
            get { return fecha_hora; }
            set { fecha_hora = value; }
        }
        private String Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }
    }

}



