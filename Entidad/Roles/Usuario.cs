namespace Entidad.Roles
{
    /// <summary>
    /// Esta clase instancia objetos de tipo Usuario.
    /// </summary>
    public class Usuario
    {
        /// <summary>
        /// Obtiene o establece el identificador usuario.
        /// </summary>
        /// <value>
        /// El identificador usuario.
        /// </value>
        public int IdUsuario { get; set; }

        /// <summary>
        /// Obtiene o establece el documento.
        /// </summary>
        /// <value>
        /// El documento.
        /// </value>
        public string Documento { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre completo.
        /// </summary>
        /// <value>
        /// El nombre completo.
        /// </value>
        public string NombreCompleto { get; set; }

        /// <summary>
        /// Obtiene o establece el correo.
        /// </summary>
        /// <value>
        /// El correo.
        /// </value>
        public string Correo { get; set; }

        /// <summary>
        /// Obtiene o establece la contraseña.
        /// </summary>
        /// <value>
        /// La contraseña.
        /// </value>
        public string Contraseña { get; set; }

        /// <summary>
        /// Obtiene o establece el objeto rol.
        /// </summary>
        /// <value>
        /// The objeto rol.
        /// </value>
        public Rol ObJRol { get; set; }

        /// <summary>
        /// Obtiene o establece un valor que indica el estado del <see cref="Usuario"/>.
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

        /// <summary>
        /// Convierte en cadena.
        /// </summary>
        /// <returns>
        /// una <see cref="System.String" /> que representa esta instancia.
        /// </returns>
        public override string ToString()
        {
            return $"{Documento}"; 
        }
    }
}
