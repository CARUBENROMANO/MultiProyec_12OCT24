using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Negocio
    {
        private CD_Negocio objcd_Negocio = new CD_Negocio();  // aqui estamos haciendo una instancia de clase CD de la capa dato 

        public Negocio obtenerDatos()
        {
            return objcd_Negocio.obtenerDatos(); // aqui retorna la misma lista que tiene CD_Usuario que se encuentra en la capa de datos

        }

        public bool guardaDatos(Negocio obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.nombreNegocio == "")
            {
                Mensaje += "Es Necesario un Nombre de Negocio\n";
            }

            if (obj.cuit == "")
            {
                Mensaje += "Es Necesario una CUit para el Negocio\n";
            }

            if (obj.Direccion == "")
            {
                Mensaje += "Es Necesario la Direccion\n";
            }


            if (Mensaje != string.Empty)
            {
                return false;
            }
            

            else
            {
                return objcd_Negocio.guardaDatos(obj, out Mensaje);
            }


           }

            public byte[] obtenerLogo(out bool obtenido)
            {
                return objcd_Negocio.obtenerLogo(out obtenido); // se encuentra en la capa de datos

            }
      
              public bool actualizarLogo(byte[] imagen, out string mensaje)
              {
                 return objcd_Negocio.actualizarLogo(imagen,out mensaje); // se encuentra en la capa de datos

               }




    }
}
