using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cherryWebClassLibrary
{
    public class ENRedesSociales
    {
        private string usuario;
        private string redSocial;

        //Datos

        private RedesSocialesCAD m_cc;

        //Constructor
        public ENRedesSociales(string u = "", string rs = "")
        {
            usuario = u;
            redSocial = rs;
        }

        
        

        //Funcion que llama al CAD para  añadir una red social a la informacion del usuario
        public static bool nueva_red_social(string usuario, string red, string cuenta)
        {
            return RedesSocialesCAD.agregar_cuenta_usuario(usuario,red,cuenta);
        }

        //Funcion que devuelve el twitter de un usuario
        public static string dame_Twitter(string usuario)
        {
            return RedesSocialesCAD.dame_Twitter(usuario);
        }

        //Funcion que devuelve el Facebook de un usuario
        public static string dame_Facebook(string usuario)
        {
            return RedesSocialesCAD.dame_Facebook(usuario);
        }


        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string RedSocial
        {
            get { return redSocial; }
            set { redSocial = value; }
        }
    }
}
