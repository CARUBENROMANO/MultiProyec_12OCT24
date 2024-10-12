using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Reporte
    {
        public CD_Reporte objcd_reporte = new CD_Reporte();


        public List<ReporteCompras> Compra(string fechainicio, string fechafin, int idproveedor)
        {
            return objcd_reporte.Compra(fechainicio, fechafin, idproveedor); // aqui retorna la misma lista que tiene CD_Usuario que se encuentra en la capa de datos

        }

        public List<ReporteVentas> Ventas(string fechainicio, string fechafin)
        {
            return objcd_reporte.Ventas(fechainicio, fechafin); // aqui retorna la misma lista que tiene CD_Usuario que se encuentra en la capa de datos

        }

    }
}
