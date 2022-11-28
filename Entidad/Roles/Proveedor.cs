namespace Entidad.Roles
{
    /// <summary>
    /// Esta clase instancia objetos de tipo Proveedor.
    /// </summary>
    public class Proveedor
    {
        /// <summary>
        /// Obtiene o establece el identificador del proveedor.
        /// </summary>
        /// <value>
        /// El identificador de proveedor.
        /// </value>
        public int IdProveedor { get; set; }

        /// <summary>
        /// Obtiene o establece el documento.
        /// </summary>
        /// <value>
        /// El documento.
        /// </value>
        public string Documento { get; set; }

        /// <summary>
        /// Obtiene o establece el razonamiento social.
        /// </summary>
        /// <value>
        /// La razón social.
        /// </value>
        public string RazonSocial { get; set; }

        /// <summary>
        /// Obtiene o establece el teléfono.
        /// </summary>
        /// <value>
        /// El teléfono.
        /// </value>
        public string Telefono { get; set; }

        /// <summary>
        /// Obtiene o establece un valor que indica el estado del <see cref="Proveedor"/>.
        /// </summary>
        /// <value>
        ///   <c>true</c> si el estado es activo; de lo contrario, <c>false</c>.
        /// </value>
        public bool Estado { get; set; }

        /// <summary>
        /// Obtiene o establece la fecha de registro.
        /// </summary>
        /// <value>
        /// La fecha de registro.
        /// </value>
        public string FechaRegistro { get; set; }
    }
}
