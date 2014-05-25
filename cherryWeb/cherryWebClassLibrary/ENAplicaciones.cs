﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cherryWebClassLibrary
{
    public class ENAplicaciones
    {
        private string nombre;
        private string descripcion;
        private string categoria;
        private float peso;
        private float _PVP;
        private string imagen;

        //Datos
        private AplicacionCAD m_cc;

        public ENAplicaciones(string n = "", string c = "", string d = "", string i = "", float p = 0, float pv = 0)
        {
            nombre = n;
            descripcion = d;
            categoria = c;
            imagen = i;
            peso = p;
            pv = _PVP;
        }

        /*public void nueva_aplicacion()
        {
            try
            {
                m_cc = new AplicacionCAD("../webdb");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando usuario");

                return;
            }
        }*/

        /*public void borrar_aplicacion()
        {
            try
            {
                m_cc = new AplicacionCAD("../webdb");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error borrando usuario");

                return;
            }
        }*/

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public float Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public float PVP
        {
            get { return _PVP; }
            set { _PVP = value; }
        }
        public string Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }
    }
}