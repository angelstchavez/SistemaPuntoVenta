using Entidad.Roles;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System;
using Entidad.Registros;

namespace Datos.Datos.Registros
{
    /// <summary>
    /// Es una clase que contiene métodos que le permiten realizar operaciones CRUD en una tabla llamada CATEGORÍA
    /// </summary>
    public class DatosCategoria
    {
        /// <summary>Lista las categorias registradas.</summary>
        /// <returns>
        ///   la lista de categorias.
        /// </returns>
        public List<Categoria> ListarCategorias()
        {
            List<Categoria> Categorias = new List<Categoria>();

            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select IdCategoria,Descripcion,Estado from CATEGORIA");
                    SqlCommand command = new SqlCommand(query.ToString(), connection)
                    {
                        CommandType = CommandType.Text
                    };

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Categorias.Add(new Categoria()
                            {
                                IdCategoria = Convert.ToInt32(reader["IdCategoria"]),
                                Descripcion = reader["Descripcion"].ToString(),
                                Estado = Convert.ToBoolean(reader["Estado"]),
                            });
                        }
                    } 
                }
                catch (Exception ex)
                {
                    Categorias = new List<Categoria>();
                    connection.Close();
                    throw ex;
                }
            }
            return Categorias;
        }

        /// <summary>Registra las categoria.</summary>
        /// <param name="Categoria">una categorias.</param>
        /// <param name="mensaje">un mensaje.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        public int RegistrarCategoria(Categoria Categoria, out string mensaje)
        {
            int IdCategoriaResultado = 0;
            mensaje = string.Empty;

            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("InsertarCategoria", connection);
                    cmd.Parameters.AddWithValue("@Descripcion", Categoria.Descripcion);
                    cmd.Parameters.AddWithValue("@Estado", Categoria.Estado);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    cmd.ExecuteNonQuery();

                    IdCategoriaResultado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    IdCategoriaResultado = 0;
                    connection.Close();
                    mensaje = ex.Message;
                }
            }
            return IdCategoriaResultado;
        }

        /// <summary>Edita las categorias.</summary>
        /// <param name="Categoria">una categoria.</param>
        /// <param name="mensaje">un mensaje.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        public bool EditarCategoria(Categoria Categoria, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("EditarCategoria", connection);
                    cmd.Parameters.AddWithValue("@IdCategoria", Categoria.IdCategoria);
                    cmd.Parameters.AddWithValue("@Descripcion", Categoria.Descripcion);
                    cmd.Parameters.AddWithValue("@Estado", Categoria.Estado);
                    cmd.Parameters.AddWithValue("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
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

        /// <summary>Elimina las categorias.</summary>
        /// <param name="Categoria">una categoria.</param>
        /// <param name="mensaje">un mensaje.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        public bool EliminarCategoria(Categoria Categoria, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("EliminarCategoria", connection);
                    cmd.Parameters.AddWithValue("@IdCategoria", Categoria.IdCategoria);
                    cmd.Parameters.AddWithValue("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
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
