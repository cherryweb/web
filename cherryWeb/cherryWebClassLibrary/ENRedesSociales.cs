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

        public ENRedesSociales(string u = "", string rs = "")
        {
            usuario = u;
            redSocial = rs;
        }

        public void nueva_cuenta_usuario()
        {
            try
            {
                m_cc = new RedesSocialesCAD("../webdb");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando usuario");

                return;
            }
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
