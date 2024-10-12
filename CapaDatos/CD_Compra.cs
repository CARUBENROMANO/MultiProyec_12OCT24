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
    public class CD_Compra
    {
        public int obtenerCorrelativo()  // aqui obtengo nro correltivo para mi documento
        {
            int idCorrelativo = 0;   //declaro mi variable


            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count (*) + 1 from Compra");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;


                    oConexion.Open();  //aqui abrimos la conexion

                    idCorrelativo = Convert.ToInt32(cmd.ExecuteScalar());   //cuando pasamos el cursor ejecuta la consulta y devuelvemos la 1ra fila

                }
                catch (Exception ex)
                {
                    idCorrelativo = 0;
                }

            }
            return idCorrelativo;
        }


        public bool Registrar(Compra obj, DataTable DetalleCompra, out string Mensaje)
        {

            bool Respuesta = false;
            Mensaje = string.Empty;


            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("sp_RegistrarCompra", oConexion);  //aqui llamamos a nuestra precedimiento almacenado
                    cmd.Parameters.AddWithValue("idUsuario", obj.oUsuario.idUsuario);
                    cmd.Parameters.AddWithValue("idProveedor", obj.oProveedor.idProveedor);
                    cmd.Parameters.AddWithValue("tipoDocumento", obj.tipoDocumento);
                    cmd.Parameters.AddWithValue("numeroDocumento", obj.numeroDocumento);
                    cmd.Parameters.AddWithValue("montoTotal", obj.montoTotal);
                    cmd.Parameters.AddWithValue("DetalleCompra", DetalleCompra);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oConexion.Open();  //aqui abrimos la conexion

                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();


                }
                catch (Exception ex)
                {
                    Respuesta = false;
                    Mensaje = ex.Message;
                }

            }
            return Respuesta;

        }



        public Compra obtenerCompra(string numero)   //obtiene el parametro numero
        {
            Compra obj = new Compra();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("SELECT c.idCompra,");
                    query.AppendLine("u.nombreUsuario,");
                    query.AppendLine("pr.documento, pr.razonSocial,");
                    query.AppendLine("c.tipoDocumento, c.numeroDocumento, c.montoTotal,convert(char(10), c.fechaRegistro, 103)[FechaRegistro]");
                    query.AppendLine("from Compra c");
                    query.AppendLine("inner join Usuario u on u.idusuario = c.idUsuario");
                    query.AppendLine("inner join Proveedor pr on pr.idProveedor = c.idProveedor");
                    query.AppendLine("where c.numeroDocumento = @numero");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.CommandType = CommandType.Text;


                    oConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())   /// sqlreader es el encargado de leer
                    {
                        while (dr.Read())
                        {
                            obj = new Compra()
                            {
                                idCompra = Convert.ToInt32(dr["idCompra"]),
                                oUsuario = new Usuario() { nombreUsuario = dr["nombreUsuario"].ToString() },
                                oProveedor = new Proveedor() { documento = dr["documento"].ToString(), razonSocial = dr["razonSocial"].ToString() },
                                tipoDocumento = dr["tipoDocumento"].ToString(),
                                numeroDocumento = dr["numeroDocumento"].ToString(),
                                montoTotal = Convert.ToDecimal(dr["montoTotal"].ToString()),
                                fechaRegistro = dr["fechaRegistro"].ToString()
                            };


                        }



                    }

                }
                catch (Exception ex)
                {
                    obj = new Compra();  /// si tiene un error que me ponga como nuevo o sea vacio

                }
            }

            return obj;
        }

        public List<DetalleCompra> ObtenerDetalleCompra(int idCompra)
        {
            List<DetalleCompra> oLista = new List<DetalleCompra>();
            try
            {
                using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
                {
                    oConexion.Open();
                    StringBuilder query = new StringBuilder();


                    query.AppendLine("select p.nombreProducto, dc.precioCompra, dc.cantidad, dc.montoTotal from Detalle_Compra dc");
                    query.AppendLine("inner join Producto p on p.idProducto = dc.idProducto");
                    query.AppendLine("where dc.idCompra = @idCompra");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.Parameters.AddWithValue("@idCompra", idCompra);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())   /// sqlreader es el encargado de leer
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new DetalleCompra()
                            {
                                oProducto = new Producto() { nombreProducto = dr["nombreProducto"].ToString() },
                                precioCostoProducto = Convert.ToDecimal(dr["precioCompra"].ToString()),
                                cantDetCompra = Convert.ToInt32(dr["cantidad"].ToString()),
                                montoTotal = Convert.ToDecimal(dr["montoTotal"].ToString()),

                            });


                        }
                    }

                }
            }

            catch (Exception ex)
            {
                oLista = new List<DetalleCompra>(); /// si tiene un error que me ponga como nuevo o sea vacio

            }

            return oLista;
        }


    }



}
