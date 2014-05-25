using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cherryWebClassLibrary
{
    public class MensajeCAD
    {
        public MensajeCAD(string db)
        {
            //Adquiere la cadena de conexión desde un único sitio.
        }

        public ENMensaje dameMensaje(ENMensaje mensaje)
        {
            // Código para recuperar un tipo DataSet conteniendo los datos del Mensaje

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

    public class ValoracionesUsuarioCAD
    {
        public ValoracionesUsuarioCAD(string db)
        {
            //Adquiere la cadena de conexión desde un único sitio.
        }

        public void nueva_valoracion(ENValoracionesUsuario valoracion)
        {
            //Código para crear una nueva valoracion
            string orden = "INSERT INTO VALORACIONES VALUES('" + valoracion.Apodo + "', " + valoracion.Aplicacion + "', " + valoracion.Valoracion + "')";
        }

        public void aplicacionesConValoracionSuperiorA(int valoracion)
        {
            //Saca las aplicaciones que tienen una valoracion superior a la indicada
            string orden = "SELECT aplicacion FROM VALORACIONES WHERE valoracion > '" + valoracion + "'";
        }

        public void aplicacionesConValoracionInferiorA(int valoracion)
        {
            //Saca las aplicaciones que tienen una valoracion inferior a la indicada
            string orden = "SELECT aplicacion FROM VALORACIONES WHERE valoracion < '" + valoracion + "'";
        }
    }

}
