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
        /// Los datos de la venta.
        /// </summary>
        private DatosVenta datosVenta = new DatosVenta();

        /// <summary>
        /// Obtenga el correlativo.
        /// </summary>
        /// <returns></returns>
        public int ObtenerCorrelativo()
        {
            return datosVenta.ObtenerCorrelativo();
        }

        /// <summary>
        /// Resta stock de un producto especifico.
        /// </summary>
        /// <param name="idProducto">El identificador producto.</param>
        /// <param name="cantidad">Una cantidad.</param>
        /// <returns><c>true</c> si la resta es exitosa; de lo contrario, <c>false</c>.</returns>
        public bool RestarStock(int idProducto, int cantidad)
        {
            return datosVenta.RestarStock(idProducto, cantidad);
        }

        /// <summary>
        /// Suma stock de un producto especifico.
        /// </summary>
        /// <param name="idProducto">El identificador producto.</param>
        /// <param name="cantidad">Una cantidad.</param>
        /// <returns>><c>true</c> si la suma es exitosa; de lo contrario, <c>false</c>.</returns>
        public bool SumarStock(int idProducto, int cantidad)
        {
            return datosVenta.SumarStock(idProducto, cantidad);
        }

        /// <summary>
        /// Registra la venta especificada.
        /// </summary>
        /// <param name="Venta">Una venta.</param>
        /// <param name="detalleVenta">Un detalle de venta.</param>
        /// <param name="mensaje">Un mensaje.</param>
        /// <returns></returns>
        public bool Registrar(Venta Venta, DataTable detalleVenta, out string mensaje)
        {
            return datosVenta.RegistrarVenta(Venta, detalleVenta, out mensaje);
        }

        /// <summary>
        /// Obtenga la venta.
        /// </summary>
        /// <param name="numero">El numero de venta.</param>
        /// <returns>La venta encontrada.</returns>
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
