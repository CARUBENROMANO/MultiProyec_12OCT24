using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Usuario
    {
        public List<Usuario> Listar()
        {
           
            List<Usuario> lista = new List<Usuario>();

            //int respuesta = 0;
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select u.idUsuario,u.nombreUsuario,u.claveUsuario,u.documento,u.correo,u.telefono,u.domicilio,r.idRol,r.descripcion from Usuario u");
                    query.AppendLine("inner join Rol r on r.idRol = u.idRol");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);  //usp_LoginUsuario
                    cmd.CommandType = CommandType.Text;
                 

                    oConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())   /// sqlreader es el encargado de leer
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuario () { 
                            idUsuario = Convert.ToInt32(dr["idUsuario"]), // ["IdUsuario"] lo que esta adentro se refiera a mi columna de mi BD referido arriba
                            nombreUsuario = dr["nombreUsuario"].ToString(),
                            claveUsuario = dr["claveUsuario"].ToString(),
                            documento= dr["documento"].ToString(),
                                correo = dr["correo"].ToString(),
                                telefono = dr["telefono"].ToString(),
                                domicilio = dr["domicilio"].ToString(),

                                oRol = new Rol() { idRol = Convert.ToInt32(dr["idRol"]), descripcion = dr["descripcion"].ToString()}
                            });
                        }
                       

                      
                    }
         
               }
                catch (Exception ex)
                {
                    lista = new List<Usuario>();  /// si tiene un error que me ponga como nuevo o sea vacio
                    
                   
                }

            }

          return lista;

        }

        public int Registrar(Usuario obj, out string Mensaje)  /// obj entrada y mensaje salida
        {
            int idUsuariogenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
                {
                    /// esto uso de guia de mi BD 
                    //CREATE PROC SP_RegistrarUsuario(
                    //@nombreUsuario varchar(50),
                    //@claveUsuario  varchar(50),
                    //@idRol int,

                    //@idUsuarioResultado bit output,
                    //@Mensaje varchar(500) output

                    //)

                    // el 1er paramatro es de mi BD no hay necisidad de pasarle con arroba
                    // el obj es mi parametro de entrada declarado arriba

                    SqlCommand cmd = new SqlCommand("SP_RegistrarUsuario", oConexion);
                    cmd.Parameters.AddWithValue("nombreUsuario", obj.nombreUsuario);
                    cmd.Parameters.AddWithValue("claveUsuario", obj.claveUsuario);
                    

                    cmd.Parameters.AddWithValue("documento", obj.documento);
                    cmd.Parameters.AddWithValue("correo", obj.correo);
                    cmd.Parameters.AddWithValue("telefono", obj.telefono);
                    cmd.Parameters.AddWithValue("domicilio", obj.domicilio);

                    cmd.Parameters.AddWithValue("idRol", obj.oRol.idRol);
                    cmd.Parameters.Add("idUsuarioResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oConexion.Open();

                    cmd.ExecuteNonQuery();

                    idUsuariogenerado = Convert.ToInt32(cmd.Parameters["idUsuarioResultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }

            catch (Exception ex)
            {
                idUsuariogenerado = 0;  // decimo a nustra capa de presentacion hay un error
                Mensaje = ex.Message;
            }

            return idUsuariogenerado;
        }



        public bool editar(Usuario obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;


            try
            {
                using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
                {


                    //        CREATE PROC SP_EditarUsuario(
                    //@idUsuario int,
                    //@nombreUsuario varchar(50),
                    //@claveUsuario varchar(50),
                    //@idRol int,

                    //@Respuesta bit output, 
                    //@Mensaje varchar(500) output


                    SqlCommand cmd = new SqlCommand("sp_EditarUsuario", oConexion);
                    cmd.Parameters.AddWithValue("idUsuario", obj.idUsuario);
                    cmd.Parameters.AddWithValue("nombreUsuario", obj.nombreUsuario);
                    cmd.Parameters.AddWithValue("claveUsuario", obj.claveUsuario);


                    cmd.Parameters.AddWithValue("documento", obj.documento);
                    cmd.Parameters.AddWithValue("correo", obj.correo);
                    cmd.Parameters.AddWithValue("telefono", obj.telefono);
                    cmd.Parameters.AddWithValue("domicilio", obj.domicilio);

                    cmd.Parameters.AddWithValue("idRol", obj.oRol.idRol);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oConexion.Open();  // abre la conexion

                    cmd.ExecuteNonQuery();   // ejecuta mi procedimiento almacenado

                    Respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Respuesta = false;
                Mensaje = ex.Message;
            }



            return Respuesta;

        }


        public bool Eliminar (Usuario obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;


            try
            {
                using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
                {


                    //   CREATE PROC SP_EliminarUsuario(
                    // @idUsuario int,

                    // @Respuesta bit output,
                    // @Mensaje varchar(500) output


                    SqlCommand cmd = new SqlCommand("sp_EliminarUsuario", oConexion);
                    cmd.Parameters.AddWithValue("idUsuario", obj.idUsuario);
                  
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oConexion.Open();  // abre la conexion

                    cmd.ExecuteNonQuery();   // ejecuta mi procedimiento almacenado

                    Respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Respuesta = false;
                Mensaje = ex.Message;
            }



            return Respuesta;

        }


    }

}


