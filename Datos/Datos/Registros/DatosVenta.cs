using Entidad.Registros;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System;

namespace Datos.Datos.Registros
{
    public class DatosVenta
    {
        public int ObtenerCorrelativo()
        {
            int idCorrelativo = 0;

            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*) + 1 from VENTA");
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

        public bool RestarStock(int idProducto, int cantidad)
        {
            bool respuesta = true;

            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update PRODUCTO set Stock  = Stock - @Cantidad where IdProducto = @IdProducto");
                    SqlCommand command = new SqlCommand(query.ToString(), connection);
                    command.Parameters.AddWithValue("@Cantidad", cantidad);
                    command.Parameters.AddWithValue("@IdProducto", idProducto);
                    command.CommandType = CommandType.Text;
                    connection.Open();

                    respuesta = command.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception)
                {
                    connection.Close();
                    respuesta = false;
                }
            }
            return respuesta;
        }

        public bool SumarStock(int idProducto, int cantidad)
        {
            bool respuesta = true;

            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update PRODUCTO set Stock  = Stock + @Cantidad where IdProducto = @IdProducto");
                    SqlCommand command = new SqlCommand(query.ToString(), connection);
                    command.Parameters.AddWithValue("@Cantidad", cantidad);
                    command.Parameters.AddWithValue("@IdProducto", idProducto);
                    command.CommandType = CommandType.Text;
                    connection.Open();

                    respuesta = command.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception)
                {
                    connection.Close();
                    respuesta = false;
                }
            }
            return respuesta;
        }

        public bool RegistrarVenta(Venta Venta, DataTable detalleVenta, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand command = new SqlCommand("InsertarVenta", connection);
                    command.Parameters.AddWithValue("IdUsuario", Venta.ObjUsuario.IdUsuario);
                    command.Parameters.AddWithValue("TipoDocumento", Venta.TipoDocumento);
                    command.Parameters.AddWithValue("NumeroDocumento", Venta.NumeroDocumento);
                    command.Parameters.AddWithValue("DocumentoCliente", Venta.DocumentoCliente);
                    command.Parameters.AddWithValue("MontoPago", Venta.MontoPago);
                    command.Parameters.AddWithValue("MontoCambio", Venta.MontoCambio);
                    command.Parameters.AddWithValue("MontoTotal", Venta.MontoTotal);
                    command.Parameters.AddWithValue("DetalleVenta", detalleVenta);
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
