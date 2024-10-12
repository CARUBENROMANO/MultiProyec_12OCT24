using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Negocio
    {
        public Negocio obtenerDatos()
        {
            Negocio obj = new Negocio();  // creamos un objeto que vamos a devolver

            try {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();

                    string query = "select idNegocio, nombreNegocio, cuit, Direccion from Negocio where idNegocio =1";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    using(SqlDataReader dr = cmd.ExecuteReader()) { 
                        while (dr.Read())
                        {
                            obj = new Negocio()
                            {
                                idNegocio = int.Parse(dr["idNegocio"].ToString()),  // mientras lees almacena en mi objeto
                                nombreNegocio = dr["nombreNegocio"].ToString(),
                                cuit = dr["cuit"].ToString(),
                                Direccion = dr["Direccion"].ToString()
                            };
                        }
                    }

                }
            
            }
            catch {
            obj = new Negocio();
            
            }

            return obj;
        }

        public bool guardaDatos(Negocio objeto, out string mensaje)        //parametro que va a recibir y de salida out
        {
            mensaje = string.Empty;
            bool respuesta = true;



            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update Negocio set nombreNegocio = @nombreNegocio,");   // salto de linea
                    query.AppendLine("cuit = @cuit,");
                    query.AppendLine("Direccion = @Direccion");
                    query.AppendLine("where idNegocio =1;");
                     
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@nombreNegocio", objeto.nombreNegocio);    // aqui emviamos los parametros
                    cmd.Parameters.AddWithValue("@cuit", objeto.cuit);
                    cmd.Parameters.AddWithValue("@Direccion", objeto.Direccion);
                    cmd.CommandType = CommandType.Text;

                    if (cmd.ExecuteNonQuery() < 1)  // aqui validamos si es lo correcto si las fila afectada es menor a 1
                        {
                        mensaje = "NO se pudo guardar los Datos";
                        respuesta = false;
                        }             

                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                respuesta = false; //si hubo un error

            }


            return respuesta;

        }

        public byte[] obtenerLogo (out bool obtenido)
        {
            obtenido = true;    // si la imagen estamos obteniendo exitosamente
            byte[] logoBytes = new byte[0];

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();

                    string query = "select logo from Negocio where idNegocio =1";    

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);  //sqlcoman lo tome con la conexion
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            logoBytes = (byte[])dr["logo"];
                            
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                obtenido = false; // cuendo huno un error
                logoBytes = new byte[0]; 

            }

            return logoBytes;
        }

       
        public bool actualizarLogo( byte[] image, out string mensaje)
        {

            mensaje = string.Empty;
            bool respuesta = true;



            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update Negocio set logo = @imagen");   // salto de linea
                    query.AppendLine("where idNegocio =1;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@imagen", image);    // aqui emviamos los parametros
                  
                    cmd.CommandType = CommandType.Text;

                    if (cmd.ExecuteNonQuery() < 1)  // aqui validamos si es lo correcto si las fila afectada es menor a 1
                    {
                        mensaje = "NO se pudo Actualizar el Logo";
                        respuesta = false;
                    }

                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                respuesta = false; //si hubo un error

            }

            return respuesta;


        }





    }
}
