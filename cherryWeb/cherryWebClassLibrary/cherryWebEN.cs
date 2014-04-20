using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cherryWebClassLibrary
{

    public class ENUsuario
    {
        //Propiedades
        private String apodo;
        private String nombre;
        private String password;
        private String email_registro;
        private String email_contacto;
        private String pais;
        private Boolean boletin;
        private String imagen;
        private String paypal;

        //Datos
        private UsuarioCAD m_cc;

        public ENUsuario(string a = "", string n = "", string p = "", string er = "", string ec = "", string ps = "", Boolean b, string i = "", string paypal="")
        {
            apodo = a;
            nombre = n;
            password = p;
            er = email_registro;
            ec = email_contacto;
            ps = pais;
            b = boletin;
            i = imagen;
            p = paypal;
        }

       /* public void nuevo_usuario()
        {
            try
            {
                m_cc = new UsuarioCAD("../webdb");
            }
            catch (Error e)
            {
                Console.WriteLine("Error creando usuario");

                return;
            }
        }

        public void borrar_usuario()
        {
            try
            {
                m_cc = new UsuarioCAD("../webdb");
            }
            catch (Error e)
            {
                Console.WriteLine("Error borrando usuario");

                return;
            }
        }*/

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

        //Datos

        //private AplicacionCAD m_cc;

        public ENAplicaciones(string n = "", string d ="", string i="", float p=0, float pv = 0)
        {
            nombre = n;
            descripcion = d;
            imagen = i;
            peso = p;
            pv = _PVP;
        }

        /*public void nueva_aplicacion()
        {
            try
            {
                m_cc = new AplicacionCAD("../webdb");
            }
            catch (Error e)
            {
                Console.WriteLine("Error añadiendo aplicación");

                return;
            }
        }*/

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

        public ENMensaje(DateTime d, int i=0, string a1="", string a2="", string m="")
        {
            _ID = i;
            apodo_1 = a1;
            apodo_2 = a2;
            fecha_hora = d;
            mensaje = m;
        }

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

    public class ENValoracionesUsuario
    {
        private int valoracion;
        private String apodo;
        private String aplicacion;

        public ENValoracionesUsuario(int v = 0, string a = "", string n = "")
        {
            valoracion = v;
            apodo = a;
            aplicacion = n;
        }

        private int Valoracion
        {
            get { return valoracion; }
            set { valoracion = value; }
        }

        private String Apodo
        {
            get { return apodo; }
            set { apodo = value; }
        }

        private String Aplicacion
        {
            get { return aplicacion; }
            set { aplicacion = value; }
        }
    }
    public class ENRedesSociales
    {
        private String usuario;
        private String redSocial;

        public ENRedesSociales(string u = "", string rs = "")
        {
            usuario = u;
            redSocial = rs;
        }

        private String Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        private String RedSocial
        {
            get { return redSocial; }
            set { redSocial = value; }
        }
    }
    private class ENDescargas
    {
        private int numerototal;
        private String aplicacion;

        public ENDescargas(int nt=0, string a="")
        {
            numerototal = nt;
            aplicacion = a;
        }

        private int Numerototal
        {
            get { return numerototal; }
            set { numerototal = value; }
        }

        private String Aplicacion
        {
            get { return aplicacion; }
            set { aplicacion = value; }
        }
    }
    public class ENMediaAplicaciones
    {
        private float media;
        private string aplicacion;

        public ENMediaAplicaciones(float m = 0, string a = "")
        {
            media = m;
            aplicacion = a;
        }

        private float Media
        {
            get { return media; }
            set { media = value; }
        }

        private String Aplicacion
        {
            get { return aplicacion; }
            set { aplicacion = value; }
        }

    }

}



