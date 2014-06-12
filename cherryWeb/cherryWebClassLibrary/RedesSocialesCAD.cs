using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace cherryWebClassLibrary
{
    public class RedesSocialesCAD
    {

        ENRedesSociales red;

        private const string cadenaconexion = "data source=.\\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\Database.mdf;User Instance=true";
        SqlConnection conexion = new SqlConnection(cadenaconexion);//crear conexion esto es la misma  

        public RedesSocialesCAD(ENRedesSociales red)
        {
            //Adquiere la cadena de conexión desde un único sitio.
            this.red = red;
        }

        
        //Funcion para agregar una red social a la informacion de un usuario
        static public bool agregar_cuenta_usuario(string usuario, string red, string cuenta)
        {
            bool aR = false;

            SqlConnection conexion = new SqlConnection(cadenaconexion);
            conexion.Open();



            string consulta = "UPDATE RedesSociales " + "SET cuenta = '" + cuenta + "'" + "WHERE usuario = '" + usuario + "' and red = '" + red + "'";

            SqlCommand com = new SqlCommand(consulta, conexion);

            if (com.ExecuteNonQuery() > 0)
                aR = true;

            conexion.Close();


            //Si no devuelve ningun valor la consulta anterior, significa que debemos añadir la informacion
            //de las redes sociales
            if (!aR)
            {

                SqlConnection conexion2 = new SqlConnection(cadenaconexion);
                conexion2.Open();

                string orden = "INSERT INTO RedesSociales VALUES('" + usuario + "', '" + red + "', '" + cuenta + "')";

                SqlCommand com2 = new SqlCommand(orden, conexion2);

                if (com2.ExecuteNonQuery() > 0)
                    aR = true;

                conexion.Close();

            }

            return aR;

        }

        //Funcion para conocer el twitter de un usuario
        static public string dame_Twitter(string usuario)
        {

            //Se utiliza acceso Conectada con DataReader
            SqlConnection conexion = new SqlConnection(cadenaconexion);//crear conexion esto es la misma            siempre para todos
            SqlCommand consulta = new SqlCommand("SELECT cuenta FROM RedesSociales WHERE USUARIO= '" + usuario + "' and red = 'Twitter'", conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(consulta);//obtiene los datos
            SqlDataReader dr;

            conexion.Open();

            string cuenta = "";

            dr = consulta.ExecuteReader();
            dr.Read();

            cuenta = dr["cuenta"].ToString();

            return cuenta;
        }

        //Funcion para conocer el Facebook de un usuario
        static public string dame_Facebook(string usuario)
        {

            //Se utiliza acceso Conectada mediante DataReader
            SqlConnection conexion = new SqlConnection(cadenaconexion);//crear conexion esto es la misma            siempre para todos
            SqlCommand consulta = new SqlCommand("SELECT cuenta FROM RedesSociales WHERE USUARIO= '" + usuario + "' and red = 'Facebook'", conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(consulta);//obtiene los datos
            SqlDataReader dr;

            conexion.Open();

            string cuenta = "";

            dr = consulta.ExecuteReader();
            dr.Read();

            cuenta = dr["cuenta"].ToString();

            return cuenta;
        }

        //Funcion para actualizar la informacion de un usuario y sus redes sociales
        public void actualizar_cuenta(string usuario, string cuenta)
        {
            string orden = "UPDATE RedesSociales " + "set redesSociales = '" + cuenta + "' WHERE usuario = ' " + usuario + "'";
        }
    }
}
