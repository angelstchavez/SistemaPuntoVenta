using Entidad.Roles;
using System.Collections.Generic;

namespace Entidad.Registros
{
    /// <summary>
    /// 
    /// </summary>
    public class Venta
    {
        /// <summary>
        /// Obtiene o establece el identificador de venta.
        /// </summary>
        /// <value>
        /// El identificador de venta.
        /// </value>
        public int IdVenta { get; set; }

        /// <summary>
        /// Obtiene o establece el objeto usuario.
        /// </summary>
        /// <value>
        /// El objeto usuario.
        /// </value>
        public Usuario ObjUsuario { get; set; }

        /// <summary>
        /// Obtiene o establece el tipo de documento.
        /// </summary>
        /// <value>
        /// El tipo de documento.
        /// </value>
        public string TipoDocumento { get; set; }

        /// <summary>
        /// Obtiene o establece el número de documento.
        /// </summary>
        /// <value>
        /// El número de documento.
        /// </value>
        public string NumeroDocumento { get; set; }

        /// <summary>
        /// Obtiene o establece el documento del cliente.
        /// </summary>
        /// <value>
        /// El documento del cliente.
        /// </value>
        public string DocumentoCliente { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre del cliente.
        /// </summary>
        /// <value>
        /// El nombre del cliente.
        /// </value>
        public string NombreCliente { get; set; }

        /// <summary>
        /// Obtiene o establece el monto de pago.
        /// </summary>
        /// <value>
        /// El monto de pago.
        /// </value>
        public decimal MontoPago { get; set; }

        /// <summary>
        /// Obtiene o establece el monto de cambio.
        /// </summary>
        /// <value>
        /// El monto del cambio.
        /// </value>
        public decimal MontoCambio { get; set; }

        /// <summary>
        /// Obtiene o establece el monto total.
        /// </summary>
        /// <value>
        /// El monto total.
        /// </value>
        public decimal MontoTotal { get; set; }

        /// <summary>
        /// Obtiene o establece la lista datalle venta.
        /// </summary>
        /// <value>
        /// La lista datalle venta.
        /// </value>
        public List<DetalleVenta> ListDatalleVenta { get; set; }

        /// <summary>
        /// Obtiene o establece la fecha de registro.
        /// </summary>
        /// <value>
        /// La fecha de registro.
        /// </value>
        public string FechaRegistro { get; set; }
    }
}
