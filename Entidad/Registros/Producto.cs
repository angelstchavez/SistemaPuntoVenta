namespace Entidad.Registros
{
    /// <summary>
    /// 
    /// </summary>
    public class Producto
    {
        /// <summary>
        /// Gets or sets the identifier producto.
        /// </summary>
        /// <value>
        /// The identifier producto.
        /// </value>
        public int IdProducto { get; set; }

        /// <summary>
        /// Gets or sets the codigo.
        /// </summary>
        /// <value>
        /// The codigo.
        /// </value>
        public string Codigo { get; set; }

        /// <summary>
        /// Gets or sets the nombre.
        /// </summary>
        /// <value>
        /// The nombre.
        /// </value>
        public string Nombre { get; set; }

        /// <summary>
        /// Gets or sets the descripcion.
        /// </summary>
        /// <value>
        /// The descripcion.
        /// </value>
        public string Descripcion { get; set; }

        /// <summary>
        /// Gets or sets the object categoria.
        /// </summary>
        /// <value>
        /// The object categoria.
        /// </value>
        public Categoria ObjCategoria { get; set; }

        /// <summary>
        /// Gets or sets the stock.
        /// </summary>
        /// <value>
        /// The stock.
        /// </value>
        public int Stock { get; set; }

        /// <summary>
        /// Gets or sets the precio compra.
        /// </summary>
        /// <value>
        /// The precio compra.
        /// </value>
        public decimal PrecioCompra { get; set; }

        /// <summary>
        /// Gets or sets the precio venta.
        /// </summary>
        /// <value>
        /// The precio venta.
        /// </value>
        public decimal PrecioVenta { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Producto"/> is estado.
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
