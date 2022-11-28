namespace Entidad.Registros
{
    /// <summary>
    /// 
    /// </summary>
    public class Categoria
    {
        /// <summary>
        /// Gets or sets the identifier categoria.
        /// </summary>
        /// <value>
        /// The identifier categoria.
        /// </value>
        public int IdCategoria { get; set; }
        
        /// <summary>
        /// Gets or sets the descripcion.
        /// </summary>
        /// <value>
        /// The descripcion.
        /// </value>
        public string Descripcion { get; set; }
        
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Categoria"/> is estado.
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
