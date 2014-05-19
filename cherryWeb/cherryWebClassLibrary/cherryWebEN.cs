using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Exception;

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

        public ENUsuario(string a = "", string n = "", string p = "", string e = "", string ps = "", bool b=false, string i = "", string paypal="")
        {
            apodo = a;
            nombre = n;
            password = p;
            e = email;
            ps = pais;
            b = boletin;
            i = imagen;
            p = paypal;
        }

        public void nuevo_usuario()
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
        }

        public void borrar_usuario()
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
        }

        public string Apodo
        {
            get { return apodo;}
            set { apodo = value;}
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
            get { return Foto; }
            set { Foto = value; }
        }
        public string Paypal
        {
            get { return paypal; }
            set { paypal = value; }
        }
    }

    public class ENAplicaciones
    {
        private string nombre;
        private string descripcion;
        private string categoria;
        private float peso;
        private float _PVP;
        private string imagen;
        
        //Datos
        private AplicacionCAD m_cc;

        public ENAplicaciones(string n = "", string c = "", string d ="", string i="", float p=0, float pv = 0)
        {
            nombre = n;
            descripcion = d;
            categoria = c;
            imagen = i;
            peso = p;
            pv = _PVP;
        }

        public void nueva_aplicacion()
        {
            try
            {
                m_cc = new AplicacionCAD("../webdb");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando usuario");

                return;
            }
        }

        public void borrar_aplicacion()
        {
            try
            {
                m_cc = new AplicacionCAD("../webdb");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error borrando usuario");

                return;
            }
        }

        public string Nombre
        {
            get { return nombre; }
            set {nombre=value;}
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
            set { peso = value;}
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
    }

    public class ENMensaje
    {
        private int _ID;
        private string emisor;
        private string receptor;
        private DateTime fecha_hora;
        private string mensaje;

        //Datos

        private MensajeCAD m_cc;

        public ENMensaje(DateTime d, int i=0, string a1="", string a2="", string m="")
        {
            _ID = i;
            emisor = a1;
            receptor = a2;
            fecha_hora = d;
            mensaje = m;
        }

        public void nuevo_mensaje()
        {
            try
            {
                m_cc = new MensajeCAD("../webdb");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando usuario");

                return;
            }
        }

        public void borrar_mensaje()
        {
            try
            {
                m_cc = new MensajeCAD("../webdb");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error borrando usuario");

                return;
            }
        }

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string Emisor
        {
            get { return emisor; }
            set { emisor = value; }
        }
        public string Receptor
        {
            get { return receptor; }
            set { receptor = value; }
        }
        public DateTime Fecha_hora
        {
            get { return fecha_hora; }
            set { fecha_hora = value; }
        }
        public string Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }
    }

    public class ENValoracionesUsuario
    {
        private int valoracion;
        private string apodo;
        private string aplicacion;

        //Datos

        private ValoracionesUsuarioCAD m_cc;

        public ENValoracionesUsuario(int v = 0, string a = "", string n = "")
        {
            valoracion = v;
            apodo = a;
            aplicacion = n;
        }

        public void nueva_valoracion()
        {
            try
            {
                m_cc = new ValoracionesUsuarioCAD("../webdb");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando usuario");

                return;
            }
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
    public class ENRedesSociales
    {
        private string usuario;
        private string redSocial;

        //Datos

        private RedesSocialesCAD m_cc;

        public ENRedesSociales(string u = "", string rs = "")
        {
            usuario = u;
            redSocial = rs;
        }

        public void nueva_cuenta_usuario()
        {
            try
            {
                m_cc = new RedesSocialesCAD("../webdb");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando usuario");

                return;
            }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string RedSocial
        {
            get { return redSocial; }
            set { redSocial = value; }
        }
    }
    public class ENDescargas
    {
        private int numerototal;
        private string aplicacion;
        private int valoracion;
        private string usuario;

        //Datos

        DescargasCAD m_cc;

        public ENDescargas(int nt=0, string a="", int v ="", string u="" )
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
    public class ENMediaAplicaciones
    {
        private float media;
        private string aplicacion;

        //Datos

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

        private string Aplicacion
        {
            get { return aplicacion; }
            set { aplicacion = value; }
        }

    }

}



