using Datos.Datos.Registros;
using Entidad.Registros;
using System;
using System.Collections.Generic;
using System.Data;

namespace Logica.Logica.Registros
{
    public class LogicaVenta
    {
        private DatosVenta datosVenta = new DatosVenta();

        public int ObtenerCorrelativo()
        {
            return datosVenta.ObtenerCorrelativo();
        }

        public bool RestarStock(int idProducto, int cantidad)
        {
            return datosVenta.RestarStock(idProducto, cantidad);
        }

        public bool SumarStock(int idProducto, int cantidad)
        {
            return datosVenta.SumarStock(idProducto, cantidad);
        }

        public bool Registrar(Venta Venta, DataTable detalleVenta, out string mensaje)
        {
            return datosVenta.RegistrarVenta(Venta, detalleVenta, out mensaje);
        }

        public Venta ObtenerVenta(string numero)
        {
            Venta venta = datosVenta.ObtenerVenta(numero);
            if (venta.IdVenta != 0)
            {
                List<DetalleVenta> detalleVentas = datosVenta.ObtenerDetalleVenta(venta.IdVenta);
                venta.ListDatalleVenta = detalleVentas;
            }

            return venta;
        }
    }
}
