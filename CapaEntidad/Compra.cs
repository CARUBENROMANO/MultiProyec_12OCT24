using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compra
    {
        public int idCompra { get; set; }
        public Usuario oUsuario { get; set; }  // ver esta parte - lo que quiero es registrar los datos del personal que realizo esa actividad
        public Proveedor oProveedor { get; set; } // registrar proveedor
                                                  // public List <DetalleCompra> oDetalleCompra { get; set; }    // aqui va lista por una compra puede involucrar varios productos
        public string numeroDocumento { get; set; }

        public List<DetalleCompra> oDetalleCompra { get; set; }    // aqui va lista por una compra puede involucrar varios productos

        public string tipoDocumento { get; set; }
        public decimal montoTotal { get; set; }
        public string fechaRegistro { get; set; }

    }
}
