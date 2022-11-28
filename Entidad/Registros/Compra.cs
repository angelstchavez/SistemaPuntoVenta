using Entidad.Roles;
using System.Collections.Generic;

namespace Entidad.Registros
{
    /// <summary>
    /// 
    /// </summary>
    public class Compra
    {
        /// <summary>
        /// Gets or sets the identifier compra.
        /// </summary>
        /// <value>
        /// The identifier compra.
        /// </value>
        public int IdCompra { get; set; }

        /// <summary>
        /// Gets or sets the object usuario.
        /// </summary>
        /// <value>
        /// The object usuario.
        /// </value>
        public Usuario ObjUsuario { get; set; }

        /// <summary>
        /// Gets or sets the object provedor.
        /// </summary>
        /// <value>
        /// The object provedor.
        /// </value>
        public Proveedor ObjProvedor { get; set; }

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
        /// Gets or sets the monto total.
        /// </summary>
        /// <value>
        /// The monto total.
        /// </value>
        public decimal MontoTotal { get; set; }

        /// <summary>
        /// Gets or sets the list detalle compra.
        /// </summary>
        /// <value>
        /// The list detalle compra.
        /// </value>
        public List<DetalleCompra> ListDetalleCompra { get; set; }

        /// <summary>
        /// Gets or sets the fecha registro.
        /// </summary>
        /// <value>
        /// The fecha registro.
        /// </value>
        public string FechaRegistro { get; set; }
    }
}
