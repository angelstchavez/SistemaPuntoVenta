using Datos.Datos.Registros;
using Entidad.Registros;
using System.Data;

namespace Logica.Logica.Registros
{
    /// <summary>
    /// 
    /// </summary>
    public class LogicaCompra
    {
        /// <summary>
        /// Los datos de la compra.
        /// </summary>
        private DatosCompra datosCompra = new DatosCompra();

        /// <summary>
        /// Obtenga el correlativo.
        /// </summary>
        /// <returns></returns>
        public int ObtenerCorrelativo()
        {
            return datosCompra.ObtenerCorrelativo();
        }

        /// <summary>
        /// Registra la compra especificada.
        /// </summary>
        /// <param name="compra">Una compra.</param>
        /// <param name="detalleCompra">Un detalle compra.</param>
        /// <param name="mensaje">Un mensaje.</param>
        /// <returns></returns>
        public bool Registrar(Compra compra, DataTable detalleCompra, out string mensaje)
        {
            return datosCompra.RegistrarCompra(compra, detalleCompra, out mensaje);
        }
    }
}
