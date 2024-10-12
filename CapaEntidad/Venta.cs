using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Venta
    {
        public int idVenta { get; set; }
        public string tipoDocumento { get; set; }

        public string numeroDocumento { get; set; }

        public decimal montoPago { get; set; }

        public decimal montoCambio { get; set; }

        public decimal montoTotal { get; set; }
        public string fechaRegistro { get; set; }
        public List<DetalleVenta> oDetalleVenta { get; set; }    // aqui va lista por una venta puede involucrar varios productos
        public Usuario oUsuario { get; set; }  // ver si va el usuario o el personal 
    }
}
