using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Rol
    {
        private CD_Rol objcd_rol = new CD_Rol();  // aqui estamos haciendo una instancia de clase CD de la capa dato 

        public List<Rol> Listar()
        {
            return objcd_rol.Listar(); // aqui retorna la misma lista que tiene CD_Usuario que se encuentra en la capa de datos

        }
    }
}
