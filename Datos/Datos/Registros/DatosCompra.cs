using Entidad.Roles;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System;
using Entidad.Registros;

namespace Datos.Datos.Registros
{
    public class DatosCompra
    {
        public int ObtenerCorrelativo()
        {
            int idCorrelativo = 0;

            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*) + 1 from COMPRA");
                    SqlCommand command = new SqlCommand(query.ToString(), connection)
                    {
                        CommandType = CommandType.Text
                    };

                    connection.Open();
                    idCorrelativo = Convert.ToInt32(command.ExecuteScalar());

                }
                catch (Exception)
                {
                    idCorrelativo = 0;
                    connection.Close();
                }
            }
            return idCorrelativo;
        }

        public bool RegistrarCompra(Compra compra, DataTable detalleCompra, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand command = new SqlCommand("InsertarCompra", connection);
                    command.Parameters.AddWithValue("IdUsuario", compra.ObjUsuario.IdUsuario);
                    command.Parameters.AddWithValue("IdProveedor", compra.ObjProvedor.IdProveedor);
                    command.Parameters.AddWithValue("TipoDocumento",compra.TipoDocumento);
                    command.Parameters.AddWithValue("NumeroDocumento", compra.NumeroDocumento);
                    command.Parameters.AddWithValue("MontoTotal",compra.MontoTotal);
                    command.Parameters.AddWithValue("DetalleCompra", detalleCompra);
                    command.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    
                    connection.Open();
                    command.ExecuteNonQuery();

                    resultado = Convert.ToBoolean(command.Parameters["Resultado"].Value);
                    mensaje = command.Parameters["Mensaje"].Value.ToString();

                }
                catch (Exception ex)
                {
                    resultado = false;
                    mensaje = ex.Message;
                    connection.Close();
                }
            }
            return resultado;
        }
    }
}
