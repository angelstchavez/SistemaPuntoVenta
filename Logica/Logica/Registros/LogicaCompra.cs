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
        /// The datos compra
        /// </summary>
        private DatosCompra datosCompra = new DatosCompra();

        /// <summary>
        /// Obteners the correlativo.
        /// </summary>
        /// <returns></returns>
        public int ObtenerCorrelativo()
        {
            return datosCompra.ObtenerCorrelativo();
        }

        /// <summary>
        /// Registrars the specified compra.
        /// </summary>
        /// <param name="compra">The compra.</param>
        /// <param name="detalleCompra">The detalle compra.</param>
        /// <param name="mensaje">The mensaje.</param>
        /// <returns></returns>
        public bool Registrar(Compra compra, DataTable detalleCompra, out string mensaje)
        {
            return datosCompra.RegistrarCompra(compra, detalleCompra, out mensaje);
        }
    }
}
