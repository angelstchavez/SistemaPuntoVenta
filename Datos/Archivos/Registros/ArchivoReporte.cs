using Entidad.Registros;
using System;
using System.Collections.Generic;
using System.IO;

namespace Datos.Archivos
{
    public class ArchivoReporte
    {
        protected string ruta = "reportes.dat";


        public ArchivoReporte()
        {
            this.ruta = "reportes.dat";
        }

        public ArchivoReporte(string ruta)
        {
            this.ruta = ruta;
        }

        public bool GuardarDatos(Reporte reporte)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta, true);
                sw.WriteLine(reporte.ToString());
                sw.Close();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public bool update(List<Reporte> reporte)
        {
            try
            {
                StreamWriter sw = new StreamWriter("temporal", true);
                foreach (var item in reporte) { sw.WriteLine(item); }
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
