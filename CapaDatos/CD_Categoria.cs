using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
   
        public class CD_Categoria
        {
           public List<Categoria> Listar() 
             { 

                 List<Categoria> lista = new List<Categoria>();   
            
                using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
                {

                    try
                    {
                       StringBuilder query = new StringBuilder();
                    query.AppendLine("select idCategoria,nombreCategoria, estadoCategoria from Categoria");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);  
                    cmd.CommandType = CommandType.Text;

                        
                        oConexion.Open();
                        
                    using(SqlDataReader dr = cmd.ExecuteReader())
                    { 
                        while (dr.Read())
                        {
                            lista.Add(new Categoria()
                            {
                                idCategoria = Convert.ToInt32(dr["idCategoria"].ToString()),
                                nombreCategoria = dr["nombreCategoria"].ToString(),
                                estadoCategoria = Convert.ToBoolean(dr["estadoCategoria"].ToString()),
                            });
                        }
                       
                    }
                }
                    catch (Exception ex)
                    {
                        
                        lista = new List<Categoria>();
                    }
                }
                return lista;
            }

            public int Registrar(Categoria obj, out string Mensaje)
            {
                int idCategoriagenerado = 0;
                Mensaje = string.Empty; 

               try
                    {
                using (SqlConnection oConexion = new SqlConnection(Conexion.cadena)) { 


                 SqlCommand cmd = new SqlCommand("SP_RegistrarCategoria", oConexion);
                 cmd.Parameters.AddWithValue("nombreCategoria", obj.nombreCategoria);
                 cmd.Parameters.AddWithValue("estadoCategoria", obj.estadoCategoria);
                 cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                 cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                 cmd.CommandType = CommandType.StoredProcedure;

                  oConexion.Open();

                  cmd.ExecuteNonQuery();

                   idCategoriagenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                    }
            }

            catch (Exception ex)
                    {
                      idCategoriagenerado = 0;
                       Mensaje = ex.Message;
                    }
                
                return idCategoriagenerado;
            }

            public bool editar (Categoria obj, out string Mensaje)
            {
                bool respuesta = false;
                Mensaje = string.Empty;


                    try
                    {
                      using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
                       { 

                        SqlCommand cmd = new SqlCommand("sp_EditarCategoria", oConexion);
                        cmd.Parameters.AddWithValue("idCategoria", obj.idCategoria);
                        cmd.Parameters.AddWithValue("nombreCategoria", obj.nombreCategoria);
                        cmd.Parameters.AddWithValue("estadoCategoria", obj.estadoCategoria);
                        cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                        cmd.CommandType = CommandType.StoredProcedure;
                     
                        oConexion.Open();  // abre la conexion

                        cmd.ExecuteNonQuery();   // ejecuta mi procedimiento almacenado

                         respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                         Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                         }
                     }
                    catch (Exception ex)
                    {
                        respuesta = false;
                        Mensaje = ex.Message;
                    }

                

                return respuesta;

            }

            public bool Eliminar(Categoria obj, out string Mensaje)
            {

            bool respuesta = false;
            Mensaje = string.Empty;


            try
                {

                  using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
                     { 
                      
                        SqlCommand cmd = new SqlCommand("sp_EliminarCategoria", oConexion);
                        cmd.Parameters.AddWithValue("idCategoria", obj.idCategoria);                        
                        cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                        cmd.CommandType = CommandType.StoredProcedure;

                    oConexion.Open();

                    cmd.ExecuteNonQuery();


                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }

            }
                    catch (Exception ex)
                    {
                     respuesta = false;
                     Mensaje = ex.Message;
            }



            return respuesta;

        

        }

        public DataTable ListasCategoria()
        {
          

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {

                try
                {
                    oConexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select idCategoria,nombreCategoria, estadoCategoria from Categoria");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable(); 

                    dataAdapter.Fill(dt);

                    return dt;
                

             
                }
                catch (Exception ex)
                {

                    return null;
                }
            }
         
        }
    }
}
