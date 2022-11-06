using Entidad.Registros;
using System.Collections.Generic;
using System.IO;
using System;
using Seguridad;

namespace Datos.Repositorios.Registros
{
    public class RepositorioServicio : Archivos.ArchivoServicio
    {
        public RepositorioServicio() : base()
        {
        }

        public RepositorioServicio(string ruta) : base(ruta)
        {
        }

        public List<Servicio> GetServicios()
        {
            try
            {
                StreamReader sr = new StreamReader(ruta);
                List<Servicio> servicios = new List<Servicio>();
                while (!sr.EndOfStream)
                {
                    servicios.Add(Mappear(Encriptacion.Decrypt(sr.ReadLine())));
                }
                sr.Close();
                return servicios;
            }
            catch (Exception e) { throw e; }
        }

        public Servicio Mappear(string cadena)
        {
            try
            {
                Servicio servicio = new Servicio();
                servicio.IdServicio = int.Parse(cadena.Split(';')[0]);
                servicio.Nombre = cadena.Split(';')[1];
                servicio.Precio = decimal.Parse(cadena.Split(';')[2]);
                servicio.FechaRegistro = cadena.Split(';')[3];
                servicio.Estado = bool.Parse(cadena.Split(';')[4]);
                return servicio;
            }
            catch (Exception e) { throw e; }
        }

        public bool Update(List<Servicio> servicios, bool modo)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta, modo);
                foreach (var item in servicios) { sw.WriteLine(item.ToString()); }
                sw.Close();
                return true;
            }
            catch (Exception e) { throw e; }

        }
    }
}
