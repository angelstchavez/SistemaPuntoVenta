using System;
using System.IO;
using System.Windows.Forms;

namespace Presentacion
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region GENERACIÓN DE ARCHIVOS
            //Registros
            StreamWriter sw_categoria = new StreamWriter("categorias.dat", true);
            sw_categoria.Close();

            StreamWriter sw_producto = new StreamWriter("productos.dat", true);
            sw_producto.Close();

            StreamWriter sw_servicio = new StreamWriter("servicios.dat", true);
            sw_servicio.Close();

            StreamWriter sw_ventas = new StreamWriter("ventas.dat", true);
            sw_ventas.Close();

            StreamWriter sw_reporte = new StreamWriter("reportes.dat", true);
            sw_reporte.Close();

            //Roles
            StreamWriter sw_cliente = new StreamWriter("clientes.dat", true);
            sw_cliente.Close();

            StreamWriter sw_usuarios = new StreamWriter("usuarios.dat", true);
            sw_usuarios.Close();

            StreamWriter sw_administrador = new StreamWriter("administradores.dat", true);
            sw_administrador.Close();

            #region CONEXION
            StreamWriter conexion = new StreamWriter("ConnectionString.xml", false);
            conexion.WriteLine("<?xml version=\"1.0\"?>");
            conexion.WriteLine("<database DBcnString=\"SistemaPuntoVenta\">");
            conexion.WriteLine("</database>");
            conexion.Close();
            #endregion

            #endregion

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-CO");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Ventanas.Login());
        }
    }
}
