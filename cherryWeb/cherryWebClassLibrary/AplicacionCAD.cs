using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace cherryWebClassLibrary
{
    public class AplicacionCAD
    {

        private const string cadenaconexion = "data source=.\\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\Database.mdf;User Instance=true";
        SqlConnection conexion = new SqlConnection(cadenaconexion);//crear conexion esto es la misma            siempre para todos

        private ENAplicaciones aplicacion;

        public AplicacionCAD(ENAplicaciones aplicacion)
        {
            //Adquiere la cadena de conexión desde un único sitio.
            this.aplicacion = aplicacion;
        }

        public static ENAplicaciones dameAplicacion(string nombre)//VER
        {
            // Código para recuperar un tipo DataSet conteniendo los datos del Cliente
            SqlConnection conexion = new SqlConnection(cadenaconexion);//crear conexion esto es la misma            siempre para todos
            SqlCommand consulta = new SqlCommand("SELECT NOMBRE,DESCRIPCION,CATEGORIA,PVP,IMAGEN,USUARIO FROM APLICACIONES WHERE NOMBRE= '" + nombre + "'", conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(consulta);//obtiene los datos en modo conectado
            SqlDataReader dr;

            conexion.Open();

            dr = consulta.ExecuteReader();
            dr.Read();

            ENAplicaciones aux = new ENAplicaciones();
            

                aux.Nombre = dr["Nombre"].ToString();
                aux.Descripcion = dr["Descripcion"].ToString();
                aux.Categoria = dr["Categoria"].ToString();
                aux.PVP = (int)dr["PVP"];
                aux.Usuario = dr["Usuario"].ToString();
                aux.Imagen = dr["Imagen"].ToString();
                //aux.Boletin = (bool)dr["boletin"];

            conexion.Close();

            return aux;
        }

        public bool nueva_aplicacion()
        {
            //Código para crear una nueva aplicacion.

            string s = "INSERT INTO APLICACIONES(NOMBRE, DESCRIPCION, CATEGORIA, PVP, IMAGEN, USUARIO) Values(@nom, @desc, @cat, @pvp, @img, @usu)";
            SqlCommand cm = new SqlCommand(s, conexion);
            cm.Parameters.AddWithValue("nom", aplicacion.Nombre);
            cm.Parameters.AddWithValue("desc", aplicacion.Descripcion);
            cm.Parameters.AddWithValue("cat", aplicacion.Categoria);
            cm.Parameters.AddWithValue("pvp", aplicacion.PVP);
            cm.Parameters.AddWithValue("img", aplicacion.Imagen);
            cm.Parameters.AddWithValue("usu", aplicacion.Usuario);
            //cm.Parameters.AddWithValue("bolet", usuario.Boletin);
            //cm.Parameters.AddWithValue("foto_per", usuario.Foto);
            conexion.Open();
            cm.ExecuteNonQuery();
            conexion.Close();

            return true;
        }

        public void borra_aplicacion(string nombre)
        {
            //Código para borrar una aplicación
            string orden = "DELETE FROM APLICACIONES WHERE nombre = ' " + nombre + "'";
        }

        public void actualiza_aplicacion(ENAplicaciones aplicacion)
        {
            //Código para actualizar una aplicación. Cambio de descripción etc...
            string orden = "UPDATE APLICACIONES ";
            orden += "set descripcion = '" + aplicacion.Descripcion + "', ";
            orden += "categoria = '" + aplicacion.Categoria + "', ";
            orden += "peso = '" + aplicacion.Peso + "', ";
            orden += "pvp = '" + aplicacion.PVP + "', ";
            orden += "imagen = '" + aplicacion.Imagen + "', ";
            orden += "where nombre = '" + aplicacion.Nombre + "'";
        }

        public void aplicacionesPorPeso(float peso)
        {
            //Sacar aplicaciones filtradas por su peso.
            string orden = "SELECT nombre FROM APLICACIONES where peso < '" + peso + "'";
        }

        public void aplicacionesPorPrecio(float PVP)
        {
            //Sacar aplicaciones filtradas por su precio.
            string orden = "SELECT nombre FROM APLICACIONES where PVP < " + PVP + "'";
        }
    }
}
