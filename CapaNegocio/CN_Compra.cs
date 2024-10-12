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
    public class CN_Compra
    {
        private CD_Compra objcd_Compra = new CD_Compra();

        public int obtenerCorrelativo()
        {
            return objcd_Compra.obtenerCorrelativo(); // 

        }

        public bool Registrar(Compra obj, DataTable DetalleCompra, out string Mensaje)
        {
            return objcd_Compra.Registrar(obj, DetalleCompra, out Mensaje);
        }

        public Compra obtenerCompra(string numero)
        {
            Compra oCompra = objcd_Compra.obtenerCompra(numero);

            if (oCompra.idCompra != 0)
            {  //si existe un valor dentro de mi resultado , procedemos a la lista
                List<DetalleCompra> oDetalleCompra = objcd_Compra.ObtenerDetalleCompra(oCompra.idCompra);

                oCompra.oDetalleCompra = oDetalleCompra;   

            }
            return oCompra;


        }
    }
}
