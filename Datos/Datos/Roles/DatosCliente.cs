using Entidad.Roles;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System;

namespace Datos.Datos.Roles
{
    public class DatosCliente
    {
        public List<Cliente> ListarClientes()
        {
            List<Cliente> Clientes = new List<Cliente>();

            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select IdCliente, Documento,NombreCompleto,Correo,Telefono,Estado from CLIENTE");
                    SqlCommand command = new SqlCommand(query.ToString(), connection)
                    {
                        CommandType = CommandType.Text
                    };

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Clientes.Add(new Cliente()
                            {
                                IdCliente = Convert.ToInt32(reader["IdCliente"]),
                                Documento = reader["Documento"].ToString(),
                                NombreCompleto = reader["NombreCompleto"].ToString(),
                                Correo = reader["Correo"].ToString(),
                                Telefono = reader["Telefono"].ToString(),
                                Estado = Convert.ToBoolean(reader["Estado"]),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Clientes = new List<Cliente>();
                    connection.Close();
                    throw ex;
                }
            }
            return Clientes;
        }

        public int RegistrarCliente(Cliente Cliente, out string mensaje)
        {
            int IdClienteResultado = 0;
            mensaje = string.Empty;

            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("InsertarCliente", connection);
                    cmd.Parameters.AddWithValue("@Documento", Cliente.Documento);
                    cmd.Parameters.AddWithValue("@NombreCompleto", Cliente.NombreCompleto);
                    cmd.Parameters.AddWithValue("@Correo", Cliente.Correo);
                    cmd.Parameters.AddWithValue("@Telefono", Cliente.Telefono);
                    cmd.Parameters.AddWithValue("@Estado", Cliente.Estado);
                    cmd.Parameters.AddWithValue("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    cmd.ExecuteNonQuery();

                    IdClienteResultado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
                catch (Exception ex)
                {
                    IdClienteResultado = 0;
                    connection.Close();
                    mensaje = ex.Message;
                }
            }
            return IdClienteResultado;
        }

        public bool EditarCliente(Cliente Cliente, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("EditarCliente", connection);
                    cmd.Parameters.AddWithValue("@IdCliente", Cliente.IdCliente);
                    cmd.Parameters.AddWithValue("@Documento", Cliente.Documento);
                    cmd.Parameters.AddWithValue("@NombreCompleto", Cliente.NombreCompleto);
                    cmd.Parameters.AddWithValue("@Correo", Cliente.Correo);
                    cmd.Parameters.AddWithValue("@Telefono", Cliente.Telefono);
                    cmd.Parameters.AddWithValue("@Estado", Cliente.Estado);
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

        public bool EliminarCliente(Cliente Cliente, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("delete from CLIENTE where IdCliente = @IdCliente", connection);
                    cmd.Parameters.AddWithValue("@IdCliente", Cliente.IdCliente);
                    cmd.CommandType = CommandType.Text;
                    connection.Open();
                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    connection.Close();
                    respuesta = false;
                    mensaje = ex.Message;
                }
            }
            return respuesta;
        }
    }
}
