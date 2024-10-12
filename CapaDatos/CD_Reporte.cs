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
    public class CD_Reporte
    {
        public List<ReporteCompras> Compra(string fechainicio, string fechafin, int idproveedor)

        {

            List<ReporteCompras> lista = new List<ReporteCompras>();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))

            {


                try
                {
                    StringBuilder query = new StringBuilder();
                    SqlCommand cmd = new SqlCommand("sp_ReporteCompras", oConexion);
                    cmd.Parameters.AddWithValue("fechainicio", fechainicio);
                    cmd.Parameters.AddWithValue("fechafin", fechafin);
                    cmd.Parameters.AddWithValue("idproveedor", idproveedor);
                    cmd.CommandType = CommandType.StoredProcedure;


                    oConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())   /// sqlreader es el encargado de leer
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ReporteCompras()
                            {
                                fechaRegistro = dr["fechaRegistro"].ToString(), // ["IdUsuario"] lo que esta adentro se refiera a mi columna de mi BD referido arriba
                                tipoDocumento = dr["tipoDocumento"].ToString(),
                                numeroDocumento = dr["numeroDocumento"].ToString(),
                                montoTotal = dr["montoTotal"].ToString(),
                                usuarioRegistro = dr["usuarioRegistro"].ToString(),
                                documentoProveedor = dr["documentoProveedor"].ToString(),
                                razonSocial = dr["razonSocial"].ToString(),
                                codigoProducto = dr["CodigoProducto"].ToString(),
                                nombreProducto = dr["NombreProducto"].ToString(),
                                categoria = dr["Categoria"].ToString(),
                                precioCompra = dr["precioCompra"].ToString(),
                                precioVenta = dr["precioVenta"].ToString(),
                                cantidad = dr["cantidad"].ToString(),
                                subtotal = dr["subTotal"].ToString(),
                            });
                        }



                    }

                }
                catch (Exception ex)
                {
                    lista = new List<ReporteCompras>();  /// si tiene un error que me ponga como nuevo o sea vacio


                }

            }

            return lista;

        }



        public List<ReporteVentas> Ventas(string fechainicio, string fechafin)

        {

            List<ReporteVentas> lista = new List<ReporteVentas>();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))

            {


                try
                {
                    StringBuilder query = new StringBuilder();
                    SqlCommand cmd = new SqlCommand("sp_ReporteVentas", oConexion);
                    cmd.Parameters.AddWithValue("fechainicio", fechainicio);
                    cmd.Parameters.AddWithValue("fechafin", fechafin);

                    cmd.CommandType = CommandType.StoredProcedure;


                    oConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())   /// sqlreader es el encargado de leer
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ReporteVentas()
                            {
                                fechaRegistro = dr["fechaRegistro"].ToString(), // ["IdUsuario"] lo que esta adentro se refiera a mi columna de mi BD referido arriba
                                tipoDocumento = dr["tipoDocumento"].ToString(),
                                numeroDocumento = dr["numeroDocumento"].ToString(),
                                montoTotal = dr["montoTotal"].ToString(),
                                usuarioRegistro = dr["UsuarioRegistro"].ToString(),
                                codigoProducto = dr["CodigoProducto"].ToString(),
                                nombreProducto = dr["NombreProducto"].ToString(),
                                categoria = dr["Categoria"].ToString(),
                                precioVenta = dr["precioVenta"].ToString(),
                                cantidad = dr["cantidad"].ToString(),
                                subtotal = dr["SubTotal"].ToString(),
                            });
                        }

                    }

                }
                catch (Exception ex)
                {
                    lista = new List<ReporteVentas>();  /// si tiene un error que me ponga como nuevo o sea vacio

                }

            }

            return lista;
        }
    }
}
