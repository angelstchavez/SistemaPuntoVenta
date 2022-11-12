using Entidad.Registros;
using System.Collections.Generic;
using System.IO;
using System;
using Seguridad;

namespace Datos.Archivos
{
    public class ArchivoProducto
    {
        protected string ruta = "productos.dat";

        public ArchivoProducto()
        {
            this.ruta = "productos.dat";
        }

        public ArchivoProducto(string ruta)
        {
            this.ruta = ruta;
        }

        public bool GuardarDatos(Producto producto)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta, true);
                sw.WriteLine(producto.ToString());
                sw.Close();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public bool update(List<Producto> producto)
        {
            try
            {
                StreamWriter sw = new StreamWriter("temporal", true);
                foreach (var item in producto) { sw.WriteLine(item); }
                sw.Close();
                File.Delete(ruta);
                File.Move("temporal", ruta);
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public void vaciar()
        {
            StreamWriter sw = new StreamWriter(ruta, false);
            sw.Write("");
            sw.Close();
        }
    }
}
