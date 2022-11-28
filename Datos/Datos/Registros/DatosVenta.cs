using Entidad.Registros;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System;
using Entidad.Roles;
using System.Collections.Generic;

namespace Datos.Datos.Registros
{
    /// <summary>
    /// Es una clase que contiene métodos que le permiten realizar operaciones para las ventas.
    /// </summary>
    public class DatosVenta
    {
        /// <summary>Obtiene el correlativo de una venta.</summary>
        /// <returns>
        ///   El idCorrelativo.
        /// </returns>
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

        /// <summary>Resta elementos del stock de un producto.</summary>
        /// <param name="idProducto">El id del producto.</param>
        /// <param name="cantidad">La cantidad.</param>
        /// <returns>
        ///   <br />
        /// </returns>
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

        /// <summary>Suma elementos del stock de un producto.</summary>
        /// <param name="idProducto">El id del producto.</param>
        /// <param name="cantidad">La cantidad.</param>
        /// <returns>
        ///   <br />
        /// </returns>
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

        /// <summary>Registra las ventas.</summary>
        /// <param name="Venta">Una venta.</param>
        /// <param name="detalleVenta">Un detalle venta.</param>
        /// <param name="mensaje">Un mensaje.</param>
        /// <returns>
        ///   <br />
        /// </returns>
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
                    command.Parameters.AddWithValue("NombreCliente", Venta.NombreCliente);
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

        /// <summary>Obtiene las ventas registradas.</summary>
        /// <param name="numero">El numero dem venta a consultar.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        public Venta ObtenerVenta(string numero)
        {
            Venta venta = new Venta();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select v.IdVenta,u.NombreCompleto,");
                    query.AppendLine("v.DocumentoCliente, v.NombreCliente,");
                    query.AppendLine("v.TipoDocumento , v. NumeroDocumento,");
                    query.AppendLine("v.MontoPago, v.MontoCambio, v.MontoTotal,");
                    query.AppendLine("convert (char(10),v. FechaRegistro, 103) [FechaRegistro]");
                    query.AppendLine("from VENTA v");
                    query.AppendLine("inner join USUARIO u on u.IdUsuario = v.IdUsuario");
                    query.AppendLine($"where v.NumeroDocumento = @numero");

                    SqlCommand command = new SqlCommand(query.ToString(), conexion);
                    command.Parameters.AddWithValue("@numero", numero);
                    command.CommandType = CommandType.Text;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            venta = new Venta()
                            {
                                IdVenta = int.Parse(reader["IdVenta"].ToString()),
                                ObjUsuario = new Usuario() { NombreCompleto = reader["NombreCompleto"].ToString() },
                                NombreCliente = reader["NombreCliente"].ToString(),
                                DocumentoCliente = reader["DocumentoCliente"].ToString(),
                                TipoDocumento = reader["TipoDocumento"].ToString(),
                                NumeroDocumento = reader["NumeroDocumento"].ToString(),
                                MontoPago = Convert.ToDecimal(reader["MontoPago"].ToString()),
                                MontoCambio = Convert.ToDecimal(reader["MontoCambio"].ToString()),
                                MontoTotal = Convert.ToDecimal(reader["MontoTotal"].ToString()),
                                FechaRegistro = reader["FechaRegistro"].ToString()
                            };
                        }
                    }
                    conexion.Close();
                }
                catch (Exception)
                {
                    venta = new Venta();
                    conexion.Close();
                    throw;
                }
            }
            return venta;
        }

        /// <summary>Obtiene los detalles de las ventas.</summary>
        /// <param name="idVenta">El id de la venta.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        public List<DetalleVenta> ObtenerDetalleVenta(int idVenta)
        {
            List<DetalleVenta> detalleVenta = new List<DetalleVenta>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.Nombre, dv. PrecioVenta, dv. Cantidad, dv. SubTotal from DETALLE_VENTA dv");
                    query.AppendLine("inner join PRODUCTO p on p.IdProducto = dv. IdProducto");
                    query.AppendLine("where dv.IdVenta = @idVenta");


                    SqlCommand command = new SqlCommand(query.ToString(), conexion);
                    command.Parameters.AddWithValue("@idVenta", idVenta);
                    command.CommandType = CommandType.Text;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            detalleVenta.Add(new DetalleVenta()
                            {
                                ObjProducto = new Producto() { Nombre = reader["Nombre"].ToString() },
                                PrecioVenta = Convert.ToDecimal(reader["PrecioVenta"].ToString()),
                                Cantidad = Convert.ToInt32(reader["Cantidad"].ToString()),
                                SubTotal = Convert.ToDecimal(reader["SubTotal"].ToString()),
                            });
                        }
                    }
                    conexion.Close();
                }
                catch (Exception)
                {
                    detalleVenta = new List<DetalleVenta>();
                    conexion.Close();
                    throw;
                }
                return detalleVenta;
            }
        }
    }
}
