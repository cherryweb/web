using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace cherryWebClassLibrary
{
    public class ValoracionesUsuarioCAD
    {

        private ENValoracionesUsuario valoracion;

        private const string cadenaconexion = "data source=.\\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\Database.mdf;User Instance=true";
        SqlConnection conexion = new SqlConnection(cadenaconexion);//crear conexion esto es la misma  

        public ValoracionesUsuarioCAD(ENValoracionesUsuario usuario)
        {
            //Adquiere la cadena de conexión desde un único sitio.

            valoracion = usuario;
        }

        public bool nueva_valoracion()
        {
            //Código para crear una nueva valoracion o modificar una existente.
            
            bool aR = false;

            SqlConnection conexion = new SqlConnection(cadenaconexion);
            conexion.Open();

            string consulta = "UPDATE Valoraciones " + "SET valoracion = ' " + valoracion.Valoracion + "'" + "WHERE usuario = '" + valoracion.Apodo + "' and aplicacion = '"+ valoracion.Aplicacion + "'";

            SqlCommand com = new SqlCommand(consulta, conexion);

            //Comprobamos si no existia una valoracion previa del usuario sobre la App
            if (com.ExecuteNonQuery() > 0)
                aR = true;

            conexion.Close();

            //si no habia valorado antes la app, ahora le añadimos su primera valoracion
            if (!aR)
            {
                SqlConnection conexion2 = new SqlConnection(cadenaconexion);
                conexion2.Open();

                string orden = "INSERT INTO VALORACIONES VALUES('" + valoracion.Apodo + "', '" + valoracion.Aplicacion + "', '" + valoracion.Valoracion + "')";

                SqlCommand com2 = new SqlCommand(orden, conexion2);

                if (com2.ExecuteNonQuery() > 0)
                    aR = true;

                conexion2.Close();
            }
            

            //Si valora la aplicacion tambien aumentamos el número de descargas de dicha App
            if (aR)
            {
                SqlConnection conexion3 = new SqlConnection(cadenaconexion);
                conexion3.Open();

                string orden = "INSERT INTO DESCARGAS VALUES('" + valoracion.Aplicacion + "')";

                SqlCommand com3 = new SqlCommand(orden, conexion3);

                if (com3.ExecuteNonQuery() > 0)
                    aR = true;

                conexion3.Close();
            }

            return aR;
        }

        //Funcion que devuelve la valoracion de una App
        public static int get_valoracion(string aplicacion)
        {
            int val = 0;

            SqlConnection con = new SqlConnection(cadenaconexion);
 
            //Se  utiliza acceso Conectado a la BD
            string consulta = "SELECT avg(valoracion) as expr FROM VALORACIONES WHERE aplicacion = '" + aplicacion + "'";
            SqlCommand cm = new SqlCommand(consulta, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cm);
            SqlDataReader dr;

            con.Open();
            dr = cm.ExecuteReader();
            dr.Read();

            try
            {
                val = (int)dr["expr"];
            }
            catch (Exception e)
            {
                val = 0;
            }

            con.Close();

            return val;
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
