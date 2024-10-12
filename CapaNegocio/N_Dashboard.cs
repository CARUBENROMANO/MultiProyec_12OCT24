using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
     public class N_Dashboard
    {
        public void Dashboard(E_Dashboard obj)
        {
            D_Dashboard accesDB = new D_Dashboard();
            accesDB.ProdPorCategoria(obj);
            accesDB.ProdPreferidos(obj);
            accesDB.SumarioDatos(obj);
        }
    }
}
