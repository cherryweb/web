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
        //Constructor mensaje enviado

        public ENMensaje(string emi, string mens)
        {
            emisor = emi;
            mensaje = mens;
        }

        //Constructor mensaje
        public ENMensaje(string a1 = "", string a2 = "", string m = "")
        {
            emisor = a1;
            receptor = a2;
            mensaje = m;
        }


        //Escribir nuevo mensaje
        public bool nuevoMensaje()
        {
            MensajeCAD cad = new MensajeCAD(this);
            return cad.nuevo_mensaje();
        }

        //Obtener lista de mensajes recibidos de cada usuario
        public List<ENMensaje> dameMensajes(string receptor)
        {
            MensajeCAD cad = new MensajeCAD(this);
            return cad.dame_mensajes(receptor);
        }

        //Getetter // Setters
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
