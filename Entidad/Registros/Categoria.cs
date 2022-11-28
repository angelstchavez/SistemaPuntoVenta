using System.Security.Cryptography;

namespace Entidad.Registros
{
    /// <summary>
    /// Esta clase instancia objetos de tipo Categoria.
    /// </summary>
    public class Categoria
    {
        /// <summary>
        /// Obtiene o establece la categoría del identificador.
        /// </summary>
        /// <value>
        /// Las categorías del identificador.
        /// </value>
        public int IdCategoria { get; set; }

        /// <summary>
        /// Obtiene o establece la descripción.
        /// </summary>
        /// <value>
        /// La descripcion.
        /// </value>
        public string Descripcion { get; set; }

        /// <summary>
        /// Obtiene o establece un valor que indica el estado de la <see cref="Categoria"/>.
        /// </summary>
        /// <value>
        ///   <c>true</c> si está activo; de lo contrario, <c>false</c>.
        /// </value>
        public bool Estado { get; set; }

        /// <summary>
        /// Obtiene o establece la fecha de registro.
        /// </summary>
        /// <value>
        /// La fecha registro.
        /// </value>
        public string FechaRegistro { get; set; }
    }
}
