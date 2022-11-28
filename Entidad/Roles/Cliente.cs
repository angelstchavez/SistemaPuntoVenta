namespace Entidad.Roles
{
    /// <summary>
    /// 
    /// </summary>
    public class Cliente
    {
        /// <summary>
        /// Gets or sets the identifier cliente.
        /// </summary>
        /// <value>
        /// The identifier cliente.
        /// </value>
        public int IdCliente { get; set; }

        /// <summary>
        /// Gets or sets the documento.
        /// </summary>
        /// <value>
        /// The documento.
        /// </value>
        public string Documento { get; set; }

        /// <summary>
        /// Gets or sets the nombre completo.
        /// </summary>
        /// <value>
        /// The nombre completo.
        /// </value>
        public string NombreCompleto { get; set; }

        /// <summary>
        /// Gets or sets the telefono.
        /// </summary>
        /// <value>
        /// The telefono.
        /// </value>
        public string Telefono { get; set; }

        /// <summary>
        /// Gets or sets the correo.
        /// </summary>
        /// <value>
        /// The correo.
        /// </value>
        public string Correo { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Cliente"/> is estado.
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
