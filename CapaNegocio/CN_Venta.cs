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
    public class CN_Venta
    {

        private CD_Venta objcd_Venta = new CD_Venta();

        public bool restarStock(int idproducto, int cantidad)
        {
            return objcd_Venta.restarStock(idproducto, cantidad);
        }


        public bool sumarStock(int idproducto, int cantidad)
        {
            return objcd_Venta.sumarStock(idproducto, cantidad);
        }



        public int obtenerCorrelativo()
        {
            return objcd_Venta.obtenerCorrelativo(); // 

        }

        public bool Registrar(Venta obj, DataTable DetalleVenta, out string Mensaje)
        {
            return objcd_Venta.Registrar(obj, DetalleVenta, out Mensaje);
        }



        public Venta obtenerVenta(string numero)
        {
            Venta oVenta = objcd_Venta.obtenerVenta(numero);

            if (oVenta.idVenta != 0)
            {  //si existe un valor dentro de mi resultado , procedemos a la lista
                List<DetalleVenta> oDetalleVenta = objcd_Venta.ObtenerDetalleVenta(oVenta.idVenta);

                oVenta.oDetalleVenta = oDetalleVenta;

            }
            return oVenta;
        }








    }
}
