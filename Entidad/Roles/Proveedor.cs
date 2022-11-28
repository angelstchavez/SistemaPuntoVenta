namespace Entidad.Roles
{
    /// <summary>
    /// 
    /// </summary>
    public class Proveedor
    {
        /// <summary>
        /// Gets or sets the identifier proveedor.
        /// </summary>
        /// <value>
        /// The identifier proveedor.
        /// </value>
        public int IdProveedor { get; set; }

        /// <summary>
        /// Gets or sets the documento.
        /// </summary>
        /// <value>
        /// The documento.
        /// </value>
        public string Documento { get; set; }

        /// <summary>
        /// Gets or sets the razon social.
        /// </summary>
        /// <value>
        /// The razon social.
        /// </value>
        public string RazonSocial { get; set; }

        /// <summary>
        /// Gets or sets the telefono.
        /// </summary>
        /// <value>
        /// The telefono.
        /// </value>
        public string Telefono { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Proveedor"/> is estado.
        /// </summary>
        /// <value>
        ///   <c>true</c> if estado; otherwise, <c>false</c>.
        /// </value>
        public bool Estado { get; set; }

        /// <summary>
        /// Gets or sets the fecha registro.
        /// </summary>
        /// <value>
        /// The fecha registro.
        /// </value>
        public string FechaRegistro { get; set; }
    }
}
