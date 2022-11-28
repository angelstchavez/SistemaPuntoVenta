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
        /// Obtiene o establece el identificador compra.
        /// </summary>
        /// <value>
        /// El identificador compra.
        /// </value>
        public int IdCompra { get; set; }

        /// <summary>
        /// Obtiene o establece el objeto usuario.
        /// </summary>
        /// <value>
        /// el objeto usuario.
        /// </value>
        public Usuario ObjUsuario { get; set; }

        /// <summary>
        /// Obtiene o establece el provedor del objeto.
        /// </summary>
        /// <value>
        /// El objeto provedor.
        /// </value>
        public Proveedor ObjProvedor { get; set; }

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
        /// El numero de documento.
        /// </value>
        public string NumeroDocumento { get; set; }

        /// <summary>
        /// Obtiene o establece el monto total.
        /// </summary>
        /// <value>
        /// El monto total.
        /// </value>
        public decimal MontoTotal { get; set; }

        /// <summary>
        /// Obtiene o establece la lista detalle de compra.
        /// </summary>
        /// <value>
        /// La list detalle de compra.
        /// </value>
        public List<DetalleCompra> ListDetalleCompra { get; set; }

        /// <summary>
        /// Obtiene o establece la fecha de registro.
        /// </summary>
        /// <value>
        /// La fecha de registro.
        /// </value>
        public string FechaRegistro { get; set; }
    }
}
