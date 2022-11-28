namespace Entidad.Roles
{
    /// <summary>
    /// 
    /// </summary>
    public class Usuario
    {
        /// <summary>
        /// Gets or sets the identifier usuario.
        /// </summary>
        /// <value>
        /// The identifier usuario.
        /// </value>
        public int IdUsuario { get; set; }

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
        /// Gets or sets the correo.
        /// </summary>
        /// <value>
        /// The correo.
        /// </value>
        public string Correo { get; set; }

        /// <summary>
        /// Gets or sets the contraseña.
        /// </summary>
        /// <value>
        /// The contraseña.
        /// </value>
        public string Contraseña { get; set; }

        /// <summary>
        /// Gets or sets the ob j rol.
        /// </summary>
        /// <value>
        /// The ob j rol.
        /// </value>
        public Rol ObJRol { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Usuario"/> is estado.
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

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"{Documento}"; 
        }
    }
}
