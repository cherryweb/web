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

        public static ENUsuario dameUsuario(string apodo)
        {
            // Código para recuperar un tipo DataSet conteniendo los datos del Cliente
            SqlConnection conexion = new SqlConnection(cadenaconexion);//crear conexion esto es la misma            siempre para todos
            SqlCommand consulta = new SqlCommand("SELECT APODO,NOMBRE,PASSWORD,EMAIL,PAIS,BOLETIN FROM USUARIOS WHERE APODO= '" + apodo + "'", conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(consulta);//obtiene los datos
            SqlDataReader dr;

            conexion.Open();

            dr = consulta.ExecuteReader();
            dr.Read();

            ENUsuario aux = new ENUsuario();

            aux.Apodo = dr["Apodo"].ToString();
            aux.Nombre = dr["Nombre"].ToString();
            aux.Email = dr["Email"].ToString();
            aux.Pais = dr["Pais"].ToString();
            aux.Password = dr["Password"].ToString();
            aux.Boletin = (bool)dr["boletin"];
            //aux.Foto = dr["Foto"].ToString();


            conexion.Close();

            return aux;

        }

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

        public bool borrar_usuario()
        {
            //Código para borrar un usuario
            
            bool aR = false;

            SqlConnection conexion = new SqlConnection(cadenaconexion);
            conexion.Open();

            string consulta = "DELETE FROM USUARIOS WHERE apodo = '" + usuario.Apodo + "'";

            SqlCommand com2 = new SqlCommand(consulta, conexion);

            if (com2.ExecuteNonQuery() > 0)
                aR = true;

            conexion.Close();

            return aR;
        }

        public void actualizar_usuario(ENUsuario usuario)
        {
            //Código para actualizar un usuario. Por si cambia su e-mail, nombre etc...
            string orden = "UPDATE USUARIOS ";
            orden += "set nombre = '" + usuario.Nombre + "', ";
            orden += "password = '" + usuario.Password + "', ";
            orden += "email = '" + usuario.Email + "', ";
            orden += "pais = '" + usuario.Pais + "', ";
            orden += "boletin = '" + usuario.Boletin + "', ";
            orden += "fotoPerfil = '" + usuario.Foto + "', ";
            orden += "paypal = '" + usuario.Paypal + "', ";
            orden += "where apodo = '" + usuario.Apodo + "'";
        }
    }
}