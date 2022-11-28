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
        /// Gets or sets the identifier venta.
        /// </summary>
        /// <value>
        /// The identifier venta.
        /// </value>
        public int IdVenta { get; set; }

        /// <summary>
        /// Gets or sets the object usuario.
        /// </summary>
        /// <value>
        /// The object usuario.
        /// </value>
        public Usuario ObjUsuario { get; set; }

        /// <summary>
        /// Gets or sets the tipo documento.
        /// </summary>
        /// <value>
        /// The tipo documento.
        /// </value>
        public string TipoDocumento { get; set; }

        /// <summary>
        /// Gets or sets the numero documento.
        /// </summary>
        /// <value>
        /// The numero documento.
        /// </value>
        public string NumeroDocumento { get; set; }

        /// <summary>
        /// Gets or sets the documento cliente.
        /// </summary>
        /// <value>
        /// The documento cliente.
        /// </value>
        public string DocumentoCliente { get; set; }

        /// <summary>
        /// Gets or sets the nombre cliente.
        /// </summary>
        /// <value>
        /// The nombre cliente.
        /// </value>
        public string NombreCliente { get; set; }

        /// <summary>
        /// Gets or sets the monto pago.
        /// </summary>
        /// <value>
        /// The monto pago.
        /// </value>
        public decimal MontoPago { get; set; }

        /// <summary>
        /// Gets or sets the monto cambio.
        /// </summary>
        /// <value>
        /// The monto cambio.
        /// </value>
        public decimal MontoCambio { get; set; }

        /// <summary>
        /// Gets or sets the monto total.
        /// </summary>
        /// <value>
        /// The monto total.
        /// </value>
        public decimal MontoTotal { get; set; }

        /// <summary>
        /// Gets or sets the list datalle venta.
        /// </summary>
        /// <value>
        /// The list datalle venta.
        /// </value>
        public List<DetalleVenta> ListDatalleVenta { get; set; }

        /// <summary>
        /// Gets or sets the fecha registro.
        /// </summary>
        /// <value>
        /// The fecha registro.
        /// </value>
        public string FechaRegistro { get; set; }
    }
}
