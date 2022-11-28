using System.Configuration;
namespace Datos
{
    /// <summary>
    /// 
    /// </summary>
    public class Conexion
    {
        /// <summary>
        /// Obtiene la cadena de conexión a la base de datos.
        /// </summary>
        public static string cadena = ConfigurationManager.ConnectionStrings["cadena_conexión"].ToString();
    }
}
