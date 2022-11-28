namespace Entidad.Registros
{
    /// <summary>
    /// Esta clase instancia objetos de tipo Producto.
    /// </summary>
    public class Producto
    {
        /// <summary>
        /// Obtiene o establece el identificador producto.
        /// </summary>
        /// <value>
        /// El identificador producto.
        /// </value>
        public int IdProducto { get; set; }

        /// <summary>
        /// Obtiene o establece el codigo.
        /// </summary>
        /// <value>
        /// El codigo.
        /// </value>
        public string Codigo { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre.
        /// </summary>
        /// <value>
        /// El nombre.
        /// </value>
        public string Nombre { get; set; }

        /// <summary>
        /// Obtiene o establece la descripcion.
        /// </summary>
        /// <value>
        /// La descripcion.
        /// </value>
        public string Descripcion { get; set; }

        /// <summary>
        /// Obtiene o establece el objeto categoria.
        /// </summary>
        /// <value>
        /// El objeto categoria.
        /// </value>
        public Categoria ObjCategoria { get; set; }

        /// <summary>
        /// Obtiene o establece el stock.
        /// </summary>
        /// <value>
        /// El stock.
        /// </value>
        public int Stock { get; set; }

        /// <summary>
        /// Obtiene o establece el precio de compra.
        /// </summary>
        /// <value>
        /// El precio de compra.
        /// </value>
        public decimal PrecioCompra { get; set; }

        /// <summary>
        /// Obtiene o establece el precio de venta.
        /// </summary>
        /// <value>
        /// El precio de venta.
        /// </value>
        public decimal PrecioVenta { get; set; }

        /// <summary>
        /// Obtiene o establece un valor que indica el estado del <see cref="Producto"/>.
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
