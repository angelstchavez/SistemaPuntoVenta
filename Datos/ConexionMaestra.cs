using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class ConexionMaestra
    {
        public static string conexion = Convert.ToString(Seguridad.Desencryptacion.checkServer());
        public static SqlConnection conectar = new SqlConnection(conexion);

        public static void Abrir()
        {
            if (conectar.State == ConnectionState.Closed) { conectar.Open(); }
        }

        public static void Cerrar()
        {
            if (conectar.State == ConnectionState.Open) { conectar.Close(); }
        }
    }
}
