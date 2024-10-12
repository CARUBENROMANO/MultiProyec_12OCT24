using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Proveedor
    {

        private CD_Proveedor objcd_Proveedor = new CD_Proveedor();  // aqui estamos haciendo una instancia de clase CD de la capa dato 

        public List<Proveedor> Listar()
        {
            return objcd_Proveedor.Listar(); // aqui retorna la misma lista que tiene CD_Proveedor que se encuentra en la capa de datos

        }

        public int Registrar(Proveedor obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.razonSocial == "")
            {
                Mensaje += "Es Necesario un Nombre de Razon Social\n";
            }

            if (obj.correo == "")
            {
                Mensaje += "Es Necesario un correo para el Proveedor\n";
            }

            if (obj.telefono == "")
            {
                Mensaje += "Es Necesario un Nro. de Telefono para el Proveedor\n";
            }


            if (obj.documento == "")
            {
                Mensaje += "Es Necesario un Nro. de documento para el Proveedor\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }

            else
            {
                return objcd_Proveedor.Registrar(obj, out Mensaje);
            }
        }
        public bool editar(Proveedor obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.razonSocial == "")
            {
                Mensaje += "Es Necesario un Nombre de Razon Social\n";
            }

            if (obj.correo == "")
            {
                Mensaje += "Es Necesario un correo para el Proveedor\n";
            }

            if (obj.telefono == "")
            {
                Mensaje += "Es Necesario un Nro. de Telefono para el Proveedor\n";
            }

            if (obj.documento == "")
            {
                Mensaje += "Es Necesario un Nro. de documento para el Proveedor\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }

            else
            {
                return objcd_Proveedor.editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Proveedor obj, out string Mensaje)
        {
            return objcd_Proveedor.Eliminar(obj, out Mensaje);
        }



    }


}

