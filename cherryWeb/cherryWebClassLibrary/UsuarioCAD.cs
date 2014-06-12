using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace cherryWebClassLibrary
{
    public class UsuarioCAD
    {
        /*La cadena de conexion puede ser de dos maneras. Una de forma local y otra si esta en
         un servidor
         -  cadenaconexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\basededatos.accdb" este 
         * caso es para una bbdd en access
         - Server sql 2008 cadenaconexion =  "Data Source='RAUL-PC\\SQLEXPRESS';Initial                             Catalog=basededatos;Integrated Security=True";
         Hay otro tercer caso que creo que es que la propia aplicacion tenga su propia bbdd con 
         linq o algo así*/

        private const string cadenaconexion = "data source=.\\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\Database.mdf;User Instance=true";
        SqlConnection conexion = new SqlConnection(cadenaconexion);//crear conexion esto es la misma            siempre para todos

        private ENUsuario usuario;

        public UsuarioCAD(ENUsuario usuario)
        {
            //Adquiere la cadena de conexión desde un único sitio.
            this.usuario = usuario;
        }

        //Funcion para comprobar que existe ya un usuario registrado en la base de datos
        public static bool existeUsuario(string apodo)
        {
            bool existe = false;
            
            //Se utiliza acceso Conectado a la base de datos

            SqlConnection c = new SqlConnection(cadenaconexion);
            c.Open();
            SqlCommand com = new SqlCommand("Select * from usuarios where apodo='" + apodo + "'", c);
            SqlDataReader dr = com.ExecuteReader();

            existe = dr.HasRows;

            dr.Close();
            c.Close();

            return existe;
        }

        //Funcion para comprobar que la informacion introducida es un usuario existente
        public static bool esUsuario(string apodo, string password)
        {
            bool existe = false;

            //Se utiliza acceso Conectado
            SqlConnection c = new SqlConnection(cadenaconexion);
            c.Open();
            SqlCommand com = new SqlCommand("Select * from usuarios where apodo='" + apodo + "' and password='" + password + "'", c);
            SqlDataReader dr = com.ExecuteReader();

            existe = dr.HasRows;

            dr.Close();
            c.Close();

            return existe;
        }

        //Funcion para devolver la informacion de un usuario mediante un apodo
        public static ENUsuario dameUsuario(string apodo)
        {
            // Código para recuperar un tipo DataSet conteniendo los datos del Cliente
            SqlConnection conexion = new SqlConnection(cadenaconexion);//crear conexion esto es la misma            siempre para todos
            SqlCommand consulta = new SqlCommand("SELECT APODO,NOMBRE,PASSWORD,EMAIL,PAIS,BOLETIN,FOTOPERFIL FROM USUARIOS WHERE APODO= '" + apodo + "'", conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(consulta);//obtiene los datos
            SqlDataReader dr;

            conexion.Open();

            ENUsuario aux = new ENUsuario();

            dr = consulta.ExecuteReader();
            dr.Read();
           
            aux.Apodo = dr["Apodo"].ToString();
            aux.Nombre = dr["Nombre"].ToString();
            aux.Email = dr["Email"].ToString();
            aux.Pais = dr["Pais"].ToString();
            aux.Password = dr["Password"].ToString();
            aux.Boletin = (bool)dr["boletin"];
            aux.Imagen = dr["fotoPerfil"].ToString();
            

            conexion.Close();

            return aux;

        }

        //Funcion para crear un nuevo usuario y añadirlo a la BD
        public bool nuevo_usuario()
        {
            string s = "INSERT INTO USUARIOS(APODO, NOMBRE, PASSWORD, EMAIL, PAIS, BOLETIN) Values(@apod, @nomb, @pass, @email, @country, @bolet)";
            SqlCommand cm = new SqlCommand(s, conexion);
            cm.Parameters.AddWithValue("apod", usuario.Apodo);
            cm.Parameters.AddWithValue("nomb", usuario.Nombre);
            cm.Parameters.AddWithValue("pass", usuario.Password);
            cm.Parameters.AddWithValue("email", usuario.Email);
            cm.Parameters.AddWithValue("country", usuario.Pais);
            cm.Parameters.AddWithValue("bolet", usuario.Boletin);
            //cm.Parameters.AddWithValue("foto_per", usuario.Foto);
            conexion.Open();
            cm.ExecuteNonQuery();
            conexion.Close();

            return true;
        }

        //Funcion para borrar un usuario de la base de datos
        public bool borrar_usuario()
        {
            //Código para borrar un usuario
            
            bool aR = false;

            SqlConnection conexion = new SqlConnection(cadenaconexion);
            conexion.Open();

            string consulta = "DELETE FROM USUARIOS WHERE apodo = '" + usuario.Apodo + "'";

            SqlCommand com2 = new SqlCommand(consulta, conexion);

            //Se comprueba que se ha borrado el usuario
            if (com2.ExecuteNonQuery() > 0)
                aR = true;

            conexion.Close();

            return aR;
        }

        public bool actualizar_usuario(ENUsuario usuario)
        {
            //Código para actualizar un usuario. Por si cambia su e-mail, nombre etc...
            bool aR = false;

            SqlConnection conexion = new SqlConnection(cadenaconexion);
            conexion.Open();

            string orden = "UPDATE USUARIOS ";
            orden += "set nombre = '" + usuario.Nombre + "', ";
            orden += "password = '" + usuario.Password + "', ";
            orden += "email = '" + usuario.Email + "', ";
            orden += "pais = '" + usuario.Pais + "' ";
            if (usuario.Imagen != "")
            {
                orden += ", fotoPerfil = '" + usuario.Imagen + "' ";
            }
            orden += "where apodo = '" + usuario.Apodo + "'";

            SqlCommand com = new SqlCommand(orden, conexion);

            //Comprobamos que se actualiza el usuario
            if (com.ExecuteNonQuery() > 0)
                aR = true;

            conexion.Close();

            return aR;
        }
    }
}