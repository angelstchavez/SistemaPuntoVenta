using Entidad.Registros;
using System.Collections.Generic;
using System.IO;
using System;
using Seguridad;

namespace Datos.Repositorios.Registros
{
    public class RepositorioVenta : Archivos.ArchivoVenta
    {
        public RepositorioVenta() : base()
        {
        }

        public RepositorioVenta(string ruta) : base(ruta)
        {
        }

        public List<Venta> GetVentas()
        {
            try
            {
                StreamReader sr = new StreamReader(ruta);
                List<Venta> ventas = new List<Venta>();
                while (!sr.EndOfStream)
                {
                    ventas.Add(Mappear(sr.ReadLine()));
                }
                sr.Close();
                return ventas;
            }
            catch (Exception e) { throw e; }
        }

        public Venta Mappear(string cadena)
        {
            try
            {
                Venta venta = new Venta();
                venta.IdVenta = int.Parse(cadena.Split(';')[0]);
                venta.Usuario = cadena.Split(';')[1];
                venta.TipoDocumento = cadena.Split(';')[2];
                venta.NumeroDocumento = cadena.Split(';')[3];
                venta.DocumentoCliente = cadena.Split(';')[4];
                venta.NombreCliente = cadena.Split(';')[5];
                venta.MontoPago = decimal.Parse(cadena.Split(';')[6]);
                venta.MontoCambio = decimal.Parse(cadena.Split(';')[7]);
                venta.MontoTotal = decimal.Parse(cadena.Split(';')[8]);
                venta.FechaRegistro = cadena.Split(';')[9];
                return venta;
            }
            catch (Exception e) { throw e; }
        }

        public bool Update(List<Venta> ventas, bool modo)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta, modo);
                foreach (var item in ventas) { sw.WriteLine(item.ToString()); }
                sw.Close();
                return true;
            }
            catch (Exception e) { throw e; }

        }
    }
}
