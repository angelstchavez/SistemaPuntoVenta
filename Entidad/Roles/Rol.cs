namespace Entidad.Roles
{
    /// <summary>
    /// Esta clase instancia objetos de tipo Rol.
    /// </summary>
    public class Rol
    {
        /// <summary>
        /// Obtiene o establece el identificador rol.
        /// </summary>
        /// <value>
        /// El identificador del rol.
        /// </value>
        public int IdRol { get; set; }

        /// <summary>
        /// Obtiene o establece la descripción.
        /// </summary>
        /// <value>
        /// La descripción.
        /// </value>
        public string Descripcion { get; set; }

        /// <summary>
        /// Obtiene o establece la fecha de registro.
        /// </summary>
        /// <value>
        /// La fecha de registro.
        /// </value>
        public string FechaRegistro { get; set; }
    }
}
