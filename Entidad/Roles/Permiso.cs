namespace Entidad.Roles
{
    /// <summary>
    /// 
    /// </summary>
    public class Permiso
    {
        /// <summary>
        /// Gets or sets the identifier permiso.
        /// </summary>
        /// <value>
        /// The identifier permiso.
        /// </value>
        public int IdPermiso { get; set; }

        /// <summary>
        /// Gets or sets the object rol.
        /// </summary>
        /// <value>
        /// The object rol.
        /// </value>
        public Rol objRol { get; set; }

        /// <summary>
        /// Gets or sets the nombre menu.
        /// </summary>
        /// <value>
        /// The nombre menu.
        /// </value>
        public string NombreMenu { get; set; }

        /// <summary>
        /// Gets or sets the fecha registro.
        /// </summary>
        /// <value>
        /// The fecha registro.
        /// </value>
        public string FechaRegistro { get; set; }
    }
}
