using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cherryWebClassLibrary
{
    public class MensajeCAD
    {
        ENMensaje mensaje;

        public MensajeCAD(string db)
        {
            //Adquiere la cadena de conexión desde un único sitio.
        }

        public ENMensaje dameMensaje(ENMensaje mensaje)
        {
            // Código para recuperar un tipo DataSet conteniendo los datos del Mensaje
            return mensaje;

        }

        public void nuevo_mensaje(ENMensaje mensaje)
        {
            //Código para crear un nuevo mensaje
            string orden = "INSERT INTO MENSAJE VALUES('" + mensaje.ID + "', " + mensaje.Fecha_hora + "', " + mensaje.Mensaje + "', " + mensaje.Emisor + "', " + mensaje.Receptor + "')";
        }

        public void borrar_mensaje(int id)
        {
            //Código para borrar un mensaje
            string orden = "DELETE FROM MENSAJE WHERE ID = ' " + id + "'";
        }

        public void mensajePorFecha(DateTime data)
        {
            //Sacar mensajes filtradas por la fecha en la que fueron enviados/recibidos
            string orden = "SELECT mensaje FROM MENSAJE where fecha = ' " + data + "'";
        }
    }
}
