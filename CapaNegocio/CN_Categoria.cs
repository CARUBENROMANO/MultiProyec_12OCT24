using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Categoria
    {
        public CD_Categoria objcd_Categoria = new CD_Categoria();  // aqui estamos haciendo una instancia de clase CD de la capa dato 


        public List<Categoria> Listar()
        {
            return objcd_Categoria.Listar(); // aqui retorna la misma lista que tiene CD_Usuario que se encuentra en la capa de datos

        }

        public DataTable ListarCategoria()
        {
            return objcd_Categoria.ListasCategoria();
        }

        public int Registrar (Categoria obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.nombreCategoria == "" )
            {
                Mensaje += "Es Necesario un Nombre de Categoria\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }

            else
            {
                return objcd_Categoria.Registrar(obj, out Mensaje);
            }
        }
        public bool editar(Categoria obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.nombreCategoria == "")
            {
                Mensaje += "Es Necesario un Nombre de Categoria\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }

            else
            {
                return objcd_Categoria.editar(obj, out Mensaje);
            }
        }

        public bool Eliminar (Categoria obj, out string Mensaje)
        {
            return objcd_Categoria.Eliminar(obj, out Mensaje);
        }



    }
 }
