namespace Entidad.Registros
{
    /// <summary>
    /// 
    /// </summary>
    public class DetalleVenta
    {
        /// <summary>
        /// Gets or sets the identifier detalle venta.
        /// </summary>
        /// <value>
        /// The identifier detalle venta.
        /// </value>
        public int IdDetalleVenta { get; set; }

        /// <summary>
        /// Gets or sets the object producto.
        /// </summary>
        /// <value>
        /// The object producto.
        /// </value>
        public Producto ObjProducto { get; set; }

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
        /// Gets or sets the sub total.
        /// </summary>
        /// <value>
        /// The sub total.
        /// </value>
        public decimal SubTotal { get; set; }

        /// <summary>
        /// Gets or sets the fecha registro.
        /// </summary>
        /// <value>
        /// The fecha registro.
        /// </value>
        public string FechaRegistro { get; set; }
    }
}
