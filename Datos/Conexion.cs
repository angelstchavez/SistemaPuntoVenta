using System.Configuration;
namespace Datos
{
    /// <summary>
    /// 
    /// </summary>
    public class Conexion
    {
        /// <summary>
        /// The cadena
        /// </summary>
        public static string cadena = ConfigurationManager.ConnectionStrings["cadena_conexión"].ToString();
    }
}
