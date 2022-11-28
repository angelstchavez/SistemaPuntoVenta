using Datos.Datos.Registros;
using Entidad.Registros;
using System;
using System.Collections.Generic;
using System.Data;

namespace Logica.Logica.Registros
{
    /// <summary>
    /// 
    /// </summary>
    public class LogicaVenta
    {
        /// <summary>
        /// The datos venta
        /// </summary>
        private DatosVenta datosVenta = new DatosVenta();

        /// <summary>
        /// Obteners the correlativo.
        /// </summary>
        /// <returns></returns>
        public int ObtenerCorrelativo()
        {
            return datosVenta.ObtenerCorrelativo();
        }

        /// <summary>
        /// Restars the stock.
        /// </summary>
        /// <param name="idProducto">The identifier producto.</param>
        /// <param name="cantidad">The cantidad.</param>
        /// <returns></returns>
        public bool RestarStock(int idProducto, int cantidad)
        {
            return datosVenta.RestarStock(idProducto, cantidad);
        }

        /// <summary>
        /// Sumars the stock.
        /// </summary>
        /// <param name="idProducto">The identifier producto.</param>
        /// <param name="cantidad">The cantidad.</param>
        /// <returns></returns>
        public bool SumarStock(int idProducto, int cantidad)
        {
            return datosVenta.SumarStock(idProducto, cantidad);
        }

        /// <summary>
        /// Registrars the specified venta.
        /// </summary>
        /// <param name="Venta">The venta.</param>
        /// <param name="detalleVenta">The detalle venta.</param>
        /// <param name="mensaje">The mensaje.</param>
        /// <returns></returns>
        public bool Registrar(Venta Venta, DataTable detalleVenta, out string mensaje)
        {
            return datosVenta.RegistrarVenta(Venta, detalleVenta, out mensaje);
        }

        /// <summary>
        /// Obteners the venta.
        /// </summary>
        /// <param name="numero">The numero.</param>
        /// <returns></returns>
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
