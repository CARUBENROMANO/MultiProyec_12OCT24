using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Permiso
    {
        private CD_Permiso objcd_Permiso = new CD_Permiso();  // aqui estamos haciendo una instancia de clase CD de la capa dato 

        public List<Permiso> Listar( int idUsuario)
        {
            return objcd_Permiso.Listar(idUsuario); // aqui retorna la misma lista que tiene CD_Usuario que se encuentra en la capa de datos

        }
    }
}
