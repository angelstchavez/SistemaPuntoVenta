using Entidad.Roles;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;

namespace Datos.Datos.Registros
{
    /// <summary>
    /// 
    /// </summary>
    public class DatosRol
    {
        /// <summary>
        /// Listars the roles.
        /// </summary>
        /// <returns></returns>
        public List<Rol> ListarRoles()
        {
            List<Rol> roles = new List<Rol>();

            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select IdRol, Descripcion from ROL";
                    SqlCommand command = new SqlCommand(query, connection)
                    {
                        CommandType = CommandType.Text
                    };

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            roles.Add(new Rol()
                            {
                                IdRol = Convert.ToInt32(reader["IdRol"]),
                                Descripcion = reader["Descripcion"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    roles = new List<Rol>();
                    connection.Close();
                    throw ex;
                }
            }
            return roles;
        }
    }
}
