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

            //Archivos
            StreamWriter sw;

            sw = new StreamWriter("categorias.dat", true);
            sw.Close();

            sw = new StreamWriter("productos.dat", true);
            sw.Close();

            sw = new StreamWriter("servicios.dat", true);
            sw.Close();

            sw = new StreamWriter("ventas.dat", true);
            sw.Close();

            sw = new StreamWriter("clientes.dat", true);
            sw.Close();

            sw = new StreamWriter("usuarios.dat", true);
            sw.Close();

            sw = new StreamWriter("administradores.dat", true);
            sw.Close();

            sw = new StreamWriter("reportes.dat", true);
            sw.Close();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Ventanas.Login());
        }
    }
}
