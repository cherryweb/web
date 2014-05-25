﻿using System;
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

        public ENAplicaciones dameAplicacion(string nombre)//VER
        {
            // Código para recuperar un tipo DataSet conteniendo los datos del Aplicacion.
            return aplicacion;
        }

        public void nueva_aplicacion(ENAplicaciones aplicacion)
        {
            //Código para crear una nueva aplicacion.
            string orden = "INSERT INTO APLICACIONES VALUES('" + aplicacion.Nombre + "', " + aplicacion.Descripcion + "', " + aplicacion + "', " + aplicacion.Peso + "', " + aplicacion.PVP + "', " + aplicacion.Imagen + "')";
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