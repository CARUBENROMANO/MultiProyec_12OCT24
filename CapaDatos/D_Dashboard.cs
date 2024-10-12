using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class D_Dashboard
    {

        SqlConnection Conexion = new SqlConnection("Data Source=MSI;Initial Catalog=Multi_Proye;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        public void ProdPorCategoria(E_Dashboard obj)
        {
            cmd = new SqlCommand("prodPorCategoria", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                obj.Categoria1.Add(dr.GetString(0));
                obj.CantProd1.Add(dr.GetInt32(1));
            }
            dr.Close();
            Conexion.Close();
        }
        public void ProdPreferidos(E_Dashboard obj)
        {
            cmd = new SqlCommand("ProdPreferidos", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                obj.Producto1.Add(dr.GetString(0));
                obj.Cant1.Add(dr.GetInt32(1));
            }
            dr.Close();
            Conexion.Close();
        }
        public void SumarioDatos(E_Dashboard obj)
        {
            cmd = new SqlCommand("DashboardDatos", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter total = new SqlParameter("@totVentas", 0); total.Direction = ParameterDirection.Output;
            SqlParameter nprod = new SqlParameter("@nprod", 0); nprod.Direction = ParameterDirection.Output;
            SqlParameter ncategora = new SqlParameter("@ncateg", 0); ncategora.Direction = ParameterDirection.Output;
            SqlParameter nproveedores = new SqlParameter("@nprove", 0); nproveedores.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(total);
            cmd.Parameters.Add(nprod);
            cmd.Parameters.Add(ncategora);
            cmd.Parameters.Add(nproveedores);
      
            Conexion.Open();
            cmd.ExecuteNonQuery();
            obj.TotalVentas = cmd.Parameters["@totVentas"].Value.ToString();
            obj.CantCategorias1 = cmd.Parameters["@ncateg"].Value.ToString();        
            obj.CantProductos1 = cmd.Parameters["@nprod"].Value.ToString();
            obj.CantProveedores1 = cmd.Parameters["@nprove"].Value.ToString();
            Conexion.Close();
        }
    }
}
