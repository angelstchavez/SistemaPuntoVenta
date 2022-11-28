namespace Entidad.Roles
{
    /// <summary>
    /// 
    /// </summary>
    public class Permiso
    {
        /// <summary>
        /// Obtiene o establece el permiso del identificador.
        /// </summary>
        /// <value>
        /// El identificador permiso.
        /// </value>
        public int IdPermiso { get; set; }

        /// <summary>
        /// Obtiene o establece el rol del objeto.
        /// </summary>
        /// <value>
        /// El rol del objeto.
        /// </value>
        public Rol objRol { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre del menú.
        /// </summary>
        /// <value>
        /// El nombre del menú.
        /// </value>
        public string NombreMenu { get; set; }

        /// <summary>
        /// Obtiene o establece la fecha de registro.
        /// </summary>
        /// <value>
        /// La fecha de registro.
        /// </value>
        public string FechaRegistro { get; set; }
    }
}
