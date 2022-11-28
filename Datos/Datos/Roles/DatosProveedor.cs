using Entidad.Roles;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System;
using System.Xml.Linq;

namespace Datos.Datos.Roles
{
    /// <summary>
    /// 
    /// </summary>
    public class DatosProveedor
    {
        /// <summary>
        /// Listars the proveedores.
        /// </summary>
        /// <returns></returns>
        public List<Proveedor> ListarProveedores()
        {
            List<Proveedor> Proveedors = new List<Proveedor>();

            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select IdProveedor, Documento, RazonSocial, Telefono, Estado from PROVEEDOR");
                    SqlCommand command = new SqlCommand(query.ToString(), connection)
                    {
                        CommandType = CommandType.Text
                    };

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Proveedors.Add(new Proveedor()
                            {
                                IdProveedor = Convert.ToInt32(reader["IdProveedor"]),
                                Documento = reader["Documento"].ToString(),
                                RazonSocial = reader["RazonSocial"].ToString(),
                                Telefono = reader["Telefono"].ToString(),
                                Estado = Convert.ToBoolean(reader["Estado"]),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Proveedors = new List<Proveedor>();
                    connection.Close();
                    throw ex;
                }
            }
            return Proveedors;
        }

        /// <summary>
        /// Registrars the proveedor.
        /// </summary>
        /// <param name="Proveedor">The proveedor.</param>
        /// <param name="mensaje">The mensaje.</param>
        /// <returns></returns>
        public int RegistrarProveedor(Proveedor Proveedor, out string mensaje)
        {
            int IdProveedorResultado = 0;
            mensaje = string.Empty;

            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("InsertarProveedor", connection);
                    cmd.Parameters.AddWithValue("@Documento", Proveedor.Documento);
                    cmd.Parameters.AddWithValue("@RazonSocial", Proveedor.RazonSocial);
                    cmd.Parameters.AddWithValue("@Telefono", Proveedor.Telefono);
                    cmd.Parameters.AddWithValue("@Estado", Proveedor.Estado);
                    cmd.Parameters.AddWithValue("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    cmd.ExecuteNonQuery();

                    IdProveedorResultado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
                catch (Exception ex)
                {
                    IdProveedorResultado = 0;
                    connection.Close();
                    mensaje = ex.Message;
                }
            }
            return IdProveedorResultado;
        }

        /// <summary>
        /// Editars the proveedor.
        /// </summary>
        /// <param name="Proveedor">The proveedor.</param>
        /// <param name="mensaje">The mensaje.</param>
        /// <returns></returns>
        public bool EditarProveedor(Proveedor Proveedor, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("EditarProveedor", connection);
                    cmd.Parameters.AddWithValue("@IdProveedor", Proveedor.IdProveedor);
                    cmd.Parameters.AddWithValue("@Documento", Proveedor.Documento);
                    cmd.Parameters.AddWithValue("@RazonSocial", Proveedor.RazonSocial);
                    cmd.Parameters.AddWithValue("@Telefono", Proveedor.Telefono);
                    cmd.Parameters.AddWithValue("@Estado", Proveedor.Estado);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    cmd.ExecuteNonQuery();

                    resultado = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
                catch (Exception ex)
                {
                    connection.Close();
                    resultado = false;
                    mensaje = ex.Message;
                }
            }
            return resultado;
        }

        /// <summary>
        /// Eliminars the proveedor.
        /// </summary>
        /// <param name="Proveedor">The proveedor.</param>
        /// <param name="mensaje">The mensaje.</param>
        /// <returns></returns>
        public bool EliminarProveedor(Proveedor Proveedor, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("EliminarProveedor", connection);
                    cmd.Parameters.AddWithValue("@IdProveedor", Proveedor.IdProveedor);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    cmd.ExecuteNonQuery();

                    resultado = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
                catch (Exception ex)
                {
                    connection.Close();
                    resultado = false;
                    mensaje = ex.Message;
                }
            }
            return resultado;
        }
    }
}
