using Entidad.Registros;
using System.Collections.Generic;
using System.IO;
using System;
using Seguridad;

namespace Datos.Archivos
{
    public class ArchivoServicio
    {
        protected string ruta = "servicios.dat";

        public ArchivoServicio()
        {
            this.ruta = "servicios.dat";
        }

        public ArchivoServicio(string ruta)
        {
            this.ruta = ruta;
        }

        public bool GuardarDatos(Servicio servicio)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta, true);
                sw.WriteLine(servicio.ToString());
                sw.Close();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public bool update(List<Servicio> servicio)
        {
            try
            {
                StreamWriter sw = new StreamWriter("temporal", true);
                foreach (var item in servicio) { sw.WriteLine(item); }
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
