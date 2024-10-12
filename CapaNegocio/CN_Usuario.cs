using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario objcd_Usuario = new CD_Usuario();  // aqui estamos haciendo una instancia de clase CD de la capa dato 

        public List<Usuario> Listar()
        {
           return objcd_Usuario.Listar(); // aqui retorna la misma lista que tiene CD_Usuario que se encuentra en la capa de datos

        }

        public int Registrar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.nombreUsuario == "")
            {
                Mensaje += "Es Necesario un Nombre de usuario\n";
            }

            if (obj.claveUsuario == "")
            {
                Mensaje += "Es Necesario una clave para el usuario\n";
            }



            if (Mensaje != string.Empty)
            {
                return 0;
            }

            else
            {
                return objcd_Usuario.Registrar(obj, out Mensaje);
            }
        }
        public bool editar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.nombreUsuario == "")
            {
                Mensaje += "Es Necesario un Nombre de usuario\n";
            }

            if (obj.claveUsuario == "")
            {
                Mensaje += "Es Necesario una clave para el usuario\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }

            else
            {
                return objcd_Usuario.editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            return objcd_Usuario.Eliminar(obj, out Mensaje);
        }



    }


}

