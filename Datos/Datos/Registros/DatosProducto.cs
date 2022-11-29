using Entidad.Registros;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Datos.Datos.Registros
{
    /// <summary>
    /// Es una clase que contiene métodos que le permiten realizar operaciones CRUD en productos.
    /// </summary>
    public class DatosProducto
    {
        /// <summary>Lista los productos.</summary>
        /// <returns>
        ///   la lista de los productos.
        /// </returns>
        public List<Producto> ListarProductos()
        {
            List<Producto> Productos = new List<Producto>();

            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select IdProducto,Codigo,Nombre,p.Descripcion,c.IdCategoria,c.Descripcion[DescripcionCategoria],Stock,PrecioCompra,PrecioVenta,p.Estado from PRODUCTO p");
                    query.AppendLine("inner join CATEGORIA c on c.IdCategoria = p.IdCategoria");
                    SqlCommand command = new SqlCommand(query.ToString(), connection)
                    {
                        CommandType = CommandType.Text
                    };

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Productos.Add(new Producto()
                            {
                                IdProducto = Convert.ToInt32(reader["IdProducto"]),
                                Codigo = reader["Codigo"].ToString(),
                                Nombre = reader["Nombre"].ToString(),
                                Descripcion = reader["Descripcion"].ToString(),
                                ObjCategoria = new Categoria() { IdCategoria = Convert.ToInt32(reader["IdCategoria"]), Descripcion = reader["DescripcionCategoria"].ToString() },
                                Stock = Convert.ToInt32(reader["Stock"]),
                                PrecioCompra = Convert.ToDecimal(reader["PrecioCompra"]),
                                PrecioVenta = Convert.ToDecimal(reader["PrecioVenta"]),
                                Estado = Convert.ToBoolean(reader["Estado"]),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Productos = new List<Producto>();
                    connection.Close();
                    throw ex;
                }
            }
            return Productos;
        }

        /// <summary>Registra los productos.</summary>
        /// <param name="Producto">Un producto.</param>
        /// <param name="mensaje">Un mensaje.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        public int RegistrarProducto(Producto Producto, out string mensaje)
        {
            int resultado = 0;
            mensaje = string.Empty;

            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("InsertarProducto", connection);
                    cmd.Parameters.AddWithValue("@Codigo", Producto.Codigo);
                    cmd.Parameters.AddWithValue("@Nombre", Producto.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", Producto.Descripcion);
                    cmd.Parameters.AddWithValue("@IdCategoria", Producto.ObjCategoria.IdCategoria);
                    cmd.Parameters.AddWithValue("@Estado", Producto.Estado);
                    cmd.Parameters.AddWithValue("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    cmd.ExecuteNonQuery();

                    resultado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
                catch (Exception ex)
                {
                    resultado = 0;    
                    connection.Close();
                    mensaje = ex.Message;
                }
            }
            return resultado;
        }

        /// <summary>Edita los productos registrados.</summary>
        /// <param name="Producto">El producto a editar.</param>
        /// <param name="mensaje">Un mensaje</param>
        /// <returns>
        ///   <br />
        /// </returns>
        public bool EditarProducto(Producto Producto, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("EditarProducto", connection);
                    cmd.Parameters.AddWithValue("@IdProducto", Producto.IdProducto);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();

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

        /// <summary>
        /// Elimina los productos registrados.
        /// </summary>
        /// <param name="Producto">El producto a eliminar.</param>
        /// <param name="mensaje">Un mensaje.</param>
        /// <returns></returns>
        public bool EliminarProducto(Producto Producto, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("EliminarProducto", connection);
                    cmd.Parameters.AddWithValue("@IdProducto", Producto.IdProducto);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();

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
