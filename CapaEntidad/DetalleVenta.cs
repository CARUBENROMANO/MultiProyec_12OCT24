using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetalleVenta
    {
        public int idDetalleFactura {  get; set; }
        public Producto oProducto { get; set;}
        public decimal precioVenta { get; set; }
        public int cantidad { get; set; }
        public decimal subTotal { get; set; }  // debo agregar a mi tabla BD
        public string fechaRegistro { get; set; }  // ver si lo cambio por un string
    }
}
