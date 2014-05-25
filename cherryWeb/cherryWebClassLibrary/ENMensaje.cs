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
        private DateTime fecha_hora;
        private string mensaje;

        //Datos

        private MensajeCAD m_cc;

        public ENMensaje(DateTime d, int i = 0, string a1 = "", string a2 = "", string m = "")
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
}
