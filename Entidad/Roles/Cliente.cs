namespace Entidad.Roles
{
    /// <summary>
    /// Esta clase instancia objetos de tipo Cliente.
    /// </summary>
    public class Cliente
    {
        /// <summary>
        /// Obtiene o establece el identificador cliente.
        /// </summary>
        /// <value>
        /// El cliente identificador.
        /// </value>
        public int IdCliente { get; set; }

        /// <summary>
        /// Obtiene o establece el documento.
        /// </summary>
        /// <value>
        /// El documento.
        /// </value>.
        public string Documento { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre completo.
        /// </summary>
        /// <value>
        /// El nombre completo.
        /// </value>
        public string NombreCompleto { get; set; }

        /// <summary>
        /// Obtiene o establece el teléfono.
        /// </summary>
        /// <value>
        /// El teléfono.
        /// </value>
        public string Telefono { get; set; }

        /// <summary>
        /// Obtiene o establece el correo.
        /// </summary>
        /// <value>
        /// El correo.
        /// </value>
        public string Correo { get; set; }

        /// <summary>
        /// Obtiene o establece un valor que indica el estado del <see cref="Cliente"/>.
        /// </summary>
        /// <value>
        ///   <c>true</c> si el estado es activo; De lo contrario, <c>false</c>.
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
