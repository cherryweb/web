using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cherryWebClassLibrary
{
    public class ENMensaje
    {
        private int _ID;
        private string emisor;
        private string receptor;
        private string mensaje;

        //Datos

        //private MensajeCAD m_cc;

        public ENMensaje(string emi, string mens)
        {
            emisor = emi;
            mensaje = mens;
        }

        public ENMensaje(string a1 = "", string a2 = "", string m = "")
        {
            emisor = a1;
            receptor = a2;
            mensaje = m;
        }

       /* public void nuevo_mensaje()
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
        }*/

        public bool nuevoMensaje()
        {
            MensajeCAD cad = new MensajeCAD(this);
            return cad.nuevo_mensaje();
        }

        public List<ENMensaje> dameMensajes(string receptor)
        {
            MensajeCAD cad = new MensajeCAD(this);
            return cad.dame_mensajes(receptor);
        }

        /*public void borrar_mensaje()
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
        }*/

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
        
        public string Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }
    }
}
