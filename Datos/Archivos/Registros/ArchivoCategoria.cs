using System.Collections.Generic;
using System.IO;
using System;
using Entidad.Registros;

namespace Datos.Archivos
{
    public class ArchivoCategoria
    {
        protected string ruta = "categorias.dat";

        public ArchivoCategoria()
        {
            this.ruta = "categorias.dat";
        }

        public ArchivoCategoria(string ruta)
        {
            this.ruta = ruta;
        }

        public bool GuardarDatos(Categoria categoria)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta, true);
                sw.WriteLine(categoria.ToString());
                sw.Close();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public bool update(List<Categoria> categoria)
        {
            try
            {
                StreamWriter sw = new StreamWriter("temporal", true);
                foreach (var item in categoria) { sw.WriteLine(item); }
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
