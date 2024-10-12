using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public string claveUsuario { get; set; }
        public Rol oRol { get; set;} // llama a clase perfil y la letra "O" es de objeto
        public string correo { get; set; }        // agregue 
        public string documento { get; set; }     // agregue
        public string domicilio { get; set; }      //  agregue
        public string telefono { get; set; }       //  agregue





    }
}
