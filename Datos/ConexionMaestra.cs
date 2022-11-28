using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    /// <summary>
    /// 
    /// </summary>
    public class ConexionMaestra
    {
        /// <summary>
        /// The conexion
        /// </summary>
        public static string conexion = Convert.ToString(Seguridad.Desencryptacion.checkServer());
        
        /// <summary>
        /// The conectar
        /// </summary>
        public static SqlConnection conectar = new SqlConnection(conexion);

        /// <summary>
        /// Abrirs this instance.
        /// </summary>
        public static void Abrir()
        {
            if (conectar.State == ConnectionState.Closed) { conectar.Open(); }
        }

        /// <summary>
        /// Cerrars this instance.
        /// </summary>
        public static void Cerrar()
        {
            if (conectar.State == ConnectionState.Open) { conectar.Close(); }
        }
    }
}
