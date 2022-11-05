using Entidad.Registros;
using System.Collections.Generic;
using System.IO;
using System;

namespace Datos.Repositorios.Registros
{
    public class RepositorioReporte : Archivos.ArchivoReporte
    {
        public RepositorioReporte() : base()
        {
        }

        public RepositorioReporte(string ruta) : base(ruta)
        {
        }

        public List<Reporte> GetReportes()
        {
            try
            {
                StreamReader sr = new StreamReader(ruta);
                List<Reporte> reportes = new List<Reporte>();
                while (!sr.EndOfStream)
                {
                    reportes.Add(Mappear(sr.ReadLine()));
                }
                sr.Close();
                return reportes;
            }
            catch (Exception e) { throw e; }
        }

        public Reporte Mappear(string cadena)
        {
            try
            {
                Reporte reporte = new Reporte();
                reporte.IdReporte = int.Parse(cadena.Split(';')[0]);
                reporte.FechaRegistro = cadena.Split(';')[1];
                reporte.Estado = bool.Parse(cadena.Split(';')[2]);
                return reporte;
            }
            catch (Exception e) { throw e; }
        }

        public bool Update(List<Reporte> reportes, bool modo)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta, modo);
                foreach (var item in reportes) { sw.WriteLine(item.ToString()); }
                sw.Close();
                return true;
            }
            catch (Exception e) { throw e; }

        }
    }
}
