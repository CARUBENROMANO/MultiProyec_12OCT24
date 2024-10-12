using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CapaDatos
{
    public class CD_Permiso
    {
        public List<Permiso> Listar(int idUsuario)
        {

            List<Permiso> lista = new List<Permiso>();

            //int respuesta = 0;
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                   StringBuilder query = new StringBuilder();  // me permite hacer salto de linea
                    query.AppendLine("select p.idRol, p.nombreMenu from Permiso p");
                    query.AppendLine("inner join Rol r on r.idRol = p.idRol");
                    query.AppendLine("inner join Usuario u on u.idRol = r.idRol");
                    query.AppendLine("where u.idUsuario = @idUsuario");
                

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);  //usp_LoginUsuario
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.CommandType = CommandType.Text;
                   
                    oConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())   /// sqlreader es el encargado de leer
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Permiso()
                            {
                                oRol =new Rol() {idRol= Convert.ToInt32(dr["idRol"]) }, // ["IdUsuario"] lo que esta adentro se refiera a mi columna
                                nombreMenu = dr["nombreMenu"].ToString(),
                               
                            });
                        }



                    }
                     
                }
                catch (Exception ex)
                {
                    lista = new List<Permiso>();  /// si tiene un error que me ponga como nuevo o sea vacio


                }

            }

            return lista;

        }
    }
}
