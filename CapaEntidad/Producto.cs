using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Producto
    {
        public int idProducto { get; set; }

        public string codigo { get; set; }
        public string nombreProducto { get; set; }

        public string marca { get; set; }  // tengo pensado cambiar x nombre de descripcion
        public Categoria oCategoria { get; set; }  
        public string cantMedidaProducto { get; set; }  /// lo voy a quitar
      
        public int stock { get; set; }
        public decimal precioCompra { get; set; }
        public decimal precioventa { get; set; }

        public bool estadoProducto { get; set; }

        public string fechaRegistro { get; set; }
    }
}
