using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Exception;
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

        string cadenaconexion="_";
        SqlConnection conexion = new SqlConnection(cadenaconexion);//crear conexion esto es la misma            siempre para todos
         
        public UsuarioCAD (string db) 
        {
            //Adquiere la cadena de conexión desde un único sitio.
        }

        public ENUsuario dameUsuario(string apodo)
        {
            // Código para recuperar un tipo DataSet conteniendo los datos del Cliente

            SqlCommand consulta = new SqlCommand("SELECT * FROM USUARIOS WHERE APODO="+apodo, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(consulta);//obtiene los datos
            SqlDataReader dr;

            conexion.Open();

            dr = consulta.ExecuteReader();

            ENUsuario aux = new ENUsuario();

            aux.Nombre = dr["Nombre"].ToString();
            aux.Apodo = dr["Apodo"].ToString();
            aux.Boletin = (bool)dr["Boletin"];
            aux.Email = dr["Email"].ToString();
            aux.Foto= dr["Foto"].ToString();
            aux.Password= dr["Contraseña"].ToString();
            aux.Pais= dr["Pais"].ToString();

            conexion.Close();

            return aux;

        }

        public void nuevo_usuario(ENUsuario usuario)
        {
            string s = "INSERT INTO USUARIOS(APODO, NOMBRE, CONTRASEÑA, EMAIL, PAIS, BOLETIN, FOTO_PERFIL) Values(@apod, @nomb, @pass, @email, @country, @bolet, @foto_per)";
            SqlCommand cm = new SqlCommand(s,conexion);
            cm.Parameters.AddWithValue("apod", usuario.Apodo);
            cm.Parameters.AddWithValue("nomb", usuario.Nombre);
            cm.Parameters.AddWithValue("pass",usuario.Password);
            cm.Parameters.AddWithValue("email", usuario.Email);
            cm.Parameters.AddWithValue("country", usuario.Pais);
            cm.Parameters.AddWithValue("bolet", usuario.Boletin);
            cm.Parameters.AddWithValue("foto_per", usuario.Foto);
            conexion.Open();
            cm.ExecuteNonQuery();
            conexion.Close();
        }

        public void borrar_usuario(string apodo)
        {
            //Código para borrar un usuario
            string s = "DELETE FROM USUARIOS WHERE apodo = '" + apodo + "'"; 
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

    public class AplicacionCAD
    {
        public AplicacionCAD(string db)
        {
            //Adquiere la cadena de conexión desde un único sitio.
        }

        public ENAplicaciones dameAplicacion(string nombre)//VER
        {
            // Código para recuperar un tipo DataSet conteniendo los datos del Aplicacion.

        }

        public void nueva_aplicacion(ENAplicaciones aplicacion)
        {
            //Código para crear una nueva aplicacion.
            string orden = "INSERT INTO APLICACIONES VALUES('"+ aplicacion.Nombre + "', " + aplicacion.Descripcion + "', " + aplicacion + "', " + aplicacion.Peso + "', " + aplicacion.Peso + "', " + aplicacion.PVP + "', " + aplicacion.Imagen + "')";
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
            string orden = "SELECT nombre FROM APLICACIONES where peso < '"+ peso + "'";
        }

        public void aplicacionesPorPrecio(float PVP)
        {
            //Sacar aplicaciones filtradas por su precio.
            string orden = "SELECT nombre FROM APLICACIONES where PVP < "+ PVP + "'";
        }
    }

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
            string orden = "SELECT aplicacion FROM VALORACIONES WHERE valoracion > '"+ valoracion+ "'";
        }

        public void aplicacionesConValoracionInferiorA(int valoracion)
        {
            //Saca las aplicaciones que tienen una valoracion inferior a la indicada
            string orden = "SELECT aplicacion FROM VALORACIONES WHERE valoracion < '" +valoracion +"'";
        }
    }

    public class RedesSocialesCAD
    {
        public RedesSocialesCAD(string db)
        {
            //Adquiere la cadena de conexión desde un único sitio.
        }

        public void agregar_cuenta_usuario(ENRedesSociales red)
        {
            string orden = "INSERT INTO RedesSociales VALUES('" + red.Usuario + "', " + red.RedSocial + "')";
        }

        public void actualizar_cuenta(string usuario, string cuenta)
        {
            string orden = "UPDATE RedesSociales " +"set redesSociales = '" + cuenta + "' WHERE usuario = ' " + usuario + "'";
        }
    }

    public class DescargasCAD
    {
        public DescargasCAD(string db)
        {
            //Adquiere la cadena de conexión desde un único sitio.
        }

        public void nueva_descarga(ENDescargas descarga)
        {
            string orden = "INSERT INTO Descargan VALUES('" + descarga.Usuario + "', " + descarga.Aplicacion + "', " + descarga.Valoracion + "')";
        }

        public int numeroDescargas(string aplicacion)
        {
            //Numero de descargas que tiene una aplicación.

            int numDescargas = 0;

            string orden = "SELECT COUNT(*) FROM DESCARGAN WHERE aplicacion = ' " + aplicacion + "'";

            return numDescargas;
        }
    }

    public class MediaAplicacionesCAD
    {

        public MediaAplicacionesCAD(string db)
        {

        }

        public float CalculoMediaAplicacion(string aplicacion)
        {
            float media=0;
            string orden = "SELECT avg(valoracion) where aplicacion = ' " + aplicacion + "'";
            return media;
        }
    }
}
