using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Producto
    {
        public CD_Producto objcd_Producto = new CD_Producto();  // aqui estamos haciendo una instancia de clase CD de la capa dato 


        public List<Producto> Listar()
        {
            return objcd_Producto.Listar(); // aqui retorna la misma lista que tiene CD_Usuario que se encuentra en la capa de datos

        }

        public int Registrar(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.codigo == "")
            {
                Mensaje += "Es Necesario el codigo del Producto\n";
            }
            if (obj.nombreProducto == "")
            {
                Mensaje += "Es Necesario el Nombre del Producto\n";
            }

            if (obj.marca == "")
            {
                Mensaje += "Es Necesario la Marca del Producto\n";
            }


            if (Mensaje != string.Empty)
            {
                return 0;
            }

            else
            {
                return objcd_Producto.Registrar(obj, out Mensaje);
            }
        }
        public bool editar(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.codigo == "")
            {
                Mensaje += "Es Necesario el codigo del Producto\n";
            }
            if (obj.nombreProducto == "")
            {
                Mensaje += "Es Necesario el Nombre del Producto\n";
            }

            if (obj.marca == "")
            {
                Mensaje += "Es Necesario la Marca del Producto\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }

            else
            {
                return objcd_Producto.editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Producto obj, out string Mensaje)
        {
            return objcd_Producto.Eliminar(obj, out Mensaje);
        }

    }
}
