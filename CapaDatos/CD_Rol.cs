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
    public class CD_Rol
    {
        public List<Rol> Listar()
        {

            List<Rol> lista = new List<Rol>();

            //int respuesta = 0;
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();  // me permite hacer salto de linea
                    query.AppendLine("select idRol, descripcion from Rol");
                  


                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);  //usp_LoginUsuario
                    
                    cmd.CommandType = CommandType.Text;

                    oConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())   /// sqlreader es el encargado de leer
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Rol()
                            {
                                
                                idRol = Convert.ToInt32(dr["idRol"]),

                                descripcion = dr["descripcion"].ToString(),

                            });
                        }



                    }

                }
                catch (Exception ex)
                {
                    lista = new List<Rol>();  /// si tiene un error que me ponga como nuevo o sea vacio


                }

            }

            return lista;

        }
    }
}
