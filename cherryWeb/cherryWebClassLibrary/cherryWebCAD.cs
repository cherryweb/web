using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Exception;

namespace cherryWebClassLibrary
{
    public class UsuarioCAD
    {

        public UsuarioCAD () 
        {
            //Adquiere la cadena de conexión desde un único sitio.
        }

        public ENUsuario dameUsuario(string apodo)
        {
            // Código para recuperar un tipo DataSet conteniendo los datos del Cliente
        }

        public void nuevo_usuario(ENUsuario usuario)
        {
            //Código para crear un nuevo usuario
        }

        public void borrar_usuario(string apodo)
        {
            //Código para borrar un usuario
        }

        public void actualizar_usuario(ENUsuario usuario)
        {
            //Código para actualizar un usuario. Por si cambia su e-mail, nombre etc...
        }
    }

    public class AplicacionCAD
    {
        public AplicacionCAD()
        {
            //Adquiere la cadena de conexión desde un único sitio.
        }

        public ENAplicaciones dameAplicacion(string nombre)
        {
            // Código para recuperar un tipo DataSet conteniendo los datos del Aplicacion
        }

        public void nueva_aplicacion(ENAplicaciones aplicacion)
        {
            //Código para crear una nueva aplicacion
        }

        public void borra_aplicacion(string nombre)
        {
            //Código para borrar una aplicación
        }

        public void actualiza_aplicacion(ENAplicaciones aplicacion)
        {
            //Código para actualizar una aplicación. Cambio de descripción etc...
        }

        public void aplicacionesPorPeso(float peso)
        {
            //Sacar aplicaciones filtradas por su peso.
        }

        public void aplicacionesPorPrecio(float PVP)
        {
            //Sacar aplicaciones filtradas por su precio.
        }
    }

    public class MensajeCAD
    {
        public MensajeCAD()
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
        }

        public void borrar_mensaje(int id)
        {
            //Código para borrar un mensaje
        }

        public void mensajePorFecha(DateTime data)
        {
            //Sacar mensajes filtradas por la fecha en la que fueron enviados/recibidos
        }
    }

    public class ValoracionesUsuarioCAD
    {
        public ValoracionesUsuarioCAD()
        {
            //Adquiere la cadena de conexión desde un único sitio.
        }

        public ENValoracionesUsuario nueva_valoracion(ENValoracionesUsuario valoracion)
        {
            //Código para crear una nueva valoracion
        }

        public void aplicacionesConValoracionSuperiorA(int valoracion)
        {
            //Saca las aplicaciones que tienen una valoracion superior a la indicada
        }

        public void aplicacionesConValoracionInferiorA(int valoracion)
        {
            //Saca las aplicaciones que tienen una valoracion inferior a la indicada
        }
    }

    public class RedesSocialesCAD
    {
        public RedesSocialesCAD()
        {
            //Adquiere la cadena de conexión desde un único sitio.
        }

        public ENRedesSociales agregar_cuenta_usuario(ENRedesSociales red)
        {

        }

        public void actualizar_cuenta(string usuario, string cuenta)
        {

        }
    }

    public class DescargasCAD
    {
        public DescargasCAD()
        {
            //Adquiere la cadena de conexión desde un único sitio.
        }

        public ENDescargas nueva_descarga(ENDescargas desarga)
        {

        }

        public int numeroDescargas(string aplicacion)
        {
            //Numero de descargas que tiene una aplicación.

            int numDescargas = 0;

            return numDescargas;
        }
    }

    public class MediaAplicacionesCAD
    {

        public MediaAplicacionesCAD()
        {

        }

        public float CalculoMediaAplicacion(int numVotosEmitidos, int totalValoracion)
        {
            float media=0;
            return media;
        }
    }
}
