using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace cherryWebClassLibrary
{
    public class MensajeCAD
    {
        ENMensaje mensaje;

        private const string cadenaconexion = "data source=.\\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\Database.mdf;User Instance=true";
        SqlConnection conexion = new SqlConnection(cadenaconexion);//crear conexion esto es la misma  

        public MensajeCAD(ENMensaje mensaje)
        {
            //Adquiere la cadena de conexión desde un único sitio.
            this.mensaje = mensaje;
        }

        public ENMensaje dameMensaje(ENMensaje mensaje)
        {
            // Código para recuperar un tipo DataSet conteniendo los datos del Mensaje
            return mensaje;

        }

        public bool nuevo_mensaje()
        {
            bool aR = false;
            //Código para crear un nuevo mensaje
            SqlConnection conexion = new SqlConnection(cadenaconexion);
            conexion.Open();

            string orden = "INSERT INTO MENSAJE VALUES('" + mensaje.Mensaje + "', '" + mensaje.Emisor + "', '" + mensaje.Receptor + "')";

            SqlCommand com2 = new SqlCommand(orden, conexion);

            if (com2.ExecuteNonQuery() > 0)
                aR = true;

            conexion.Close();

            return aR;
        }

        public List<ENMensaje> dame_mensajes(string receptor)
        {
            List<ENMensaje> mensajes = new List<ENMensaje>();

            SqlConnection c = new SqlConnection(cadenaconexion);
            c.Open();
            string comando = "Select emisor ,mensaje from mensaje where receptor = '" + receptor + "'";
            SqlCommand com = new SqlCommand(comando, c);
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            SqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                mensajes.Add(new ENMensaje(dr["emisor"].ToString(), dr["mensaje"].ToString()));
            }

            dr.Close();
            c.Close();

            return mensajes;
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
