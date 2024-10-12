using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetalleCompra
    {
        public string idDetalleCompra { get; set; }
        public Producto oProducto { get; set; }
        public decimal precioCostoProducto { get; set; }
        public decimal ventaCostoProducto { get; set; }
        public int cantDetCompra { get; set; }
        public string metodoPago { get; set; }
        public decimal montoTotal { get; set; }
        public DateTime fechaRegistro { get; set; }  // ver si lo cambio por un string
    }
}
