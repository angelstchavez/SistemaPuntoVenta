namespace Entidad.Registros
{
    /// <summary>
    /// 
    /// </summary>
    public class DetalleCompra
    {
        /// <summary>
        /// Gets or sets the identifier detalle compra.
        /// </summary>
        /// <value>
        /// The identifier detalle compra.
        /// </value>
        public int IdDetalleCompra { get; set; }

        /// <summary>
        /// Gets or sets the object producto.
        /// </summary>
        /// <value>
        /// The object producto.
        /// </value>
        public Producto ObjProducto { get; set; }

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
        /// Gets or sets the cantidad.
        /// </summary>
        /// <value>
        /// The cantidad.
        /// </value>
        public int Cantidad { get; set; }

        /// <summary>
        /// Gets or sets the monto total.
        /// </summary>
        /// <value>
        /// The monto total.
        /// </value>
        public decimal MontoTotal { get; set; }

        /// <summary>
        /// Gets or sets the fecha registro.
        /// </summary>
        /// <value>
        /// The fecha registro.
        /// </value>
        public string FechaRegistro { get; set; }
    }
}
