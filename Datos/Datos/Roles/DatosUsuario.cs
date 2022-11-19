using Entidad.Roles;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Text;
using System.Runtime.Remoting;
using System.Net.Configuration;

namespace Datos.Datos.Roles
{
    public class DatosUsuario
    {
        public List<Usuario> ListarUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select u.IdUsuario, u.Documento, u.NombreCompleto,u.Correo,u.Clave,u.Estado,r.IdRol,r.Descripcion from USUARIO u");
                    query.AppendLine("inner join ROL r on r.IdRol = u.IdRol");
                    SqlCommand command = new SqlCommand(query.ToString(), connection)
                    {
                        CommandType = CommandType.Text
                    };

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            usuarios.Add(new Usuario()
                            {
                                IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                                Documento = reader["Documento"].ToString(),
                                NombreCompleto = reader["NombreCompleto"].ToString(),
                                Correo = reader["Correo"].ToString(),
                                Contraseña = reader["Clave"].ToString(),
                                Estado = Convert.ToBoolean(reader["Estado"]),
                                ObJRol = new Rol() { IdRol = Convert.ToInt32(reader["IdRol"]), Descripcion = reader["Descripcion"].ToString() }
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    usuarios = new List<Usuario>();
                    connection.Close();
                    throw ex;
                }
            }
            return usuarios;
        }

        public List<Usuario> ValidarUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.Append("select IdUsuario, Documento, NombreCompleto,Correo, Clave, Estado from USUARIO");
                    SqlCommand command = new SqlCommand(query.ToString(), connection)
                    {
                        CommandType = CommandType.Text
                    };

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            usuarios.Add(new Usuario()
                            {
                                IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                                Documento = reader["Documento"].ToString(),
                                NombreCompleto = reader["NombreCompleto"].ToString(),
                                Correo = reader["Correo"].ToString(),
                                Contraseña = reader["Clave"].ToString(),
                                Estado = Convert.ToBoolean(reader["Estado"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    usuarios = new List<Usuario>();
                    connection.Close();
                    throw ex;
                }
            }
            return usuarios;
        }
    
        public int RegistrarUsuario(Usuario usuario, out string mensaje)
        {
            int IdUsuarioResultado = 0;
            mensaje = string.Empty;

            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("InsertarUsuario",connection);
                    cmd.Parameters.AddWithValue("@Documento",usuario.Documento);
                    cmd.Parameters.AddWithValue("@NombreCompleto", usuario.NombreCompleto);
                    cmd.Parameters.AddWithValue("@Correo", usuario.Correo);
                    cmd.Parameters.AddWithValue("@Clave", usuario.Contraseña);
                    cmd.Parameters.AddWithValue("@IdRol", usuario.ObJRol.IdRol);
                    cmd.Parameters.AddWithValue("@Estado", usuario.Estado);
                    cmd.Parameters.AddWithValue("IdUsuarioResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    cmd.ExecuteNonQuery();

                    IdUsuarioResultado = Convert.ToInt32(cmd.Parameters["IdUsuarioResultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
                catch (Exception ex)
                {
                    IdUsuarioResultado = 0;
                    connection.Close();
                    mensaje = ex.Message;
                }
            }
            return IdUsuarioResultado;
        }

        public bool EditarUsuario(Usuario usuario, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("EditarUsuario", connection);
                    cmd.Parameters.AddWithValue("@IdUsuario", usuario.IdUsuario);
                    cmd.Parameters.AddWithValue("@Documento", usuario.Documento);
                    cmd.Parameters.AddWithValue("@NombreCompleto", usuario.NombreCompleto);
                    cmd.Parameters.AddWithValue("@Correo", usuario.Correo);
                    cmd.Parameters.AddWithValue("@Clave", usuario.Contraseña);
                    cmd.Parameters.AddWithValue("@IdRol", usuario.ObJRol.IdRol);
                    cmd.Parameters.AddWithValue("@Estado", usuario.Estado);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;
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

        public bool EliminarUsuario(Usuario usuario, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                try 
                {
                    SqlCommand cmd = new SqlCommand("EliminarUsuario", connection);
                    cmd.Parameters.AddWithValue("@IdUsuario", usuario.IdUsuario); 
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;
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
