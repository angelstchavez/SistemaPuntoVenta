namespace Entidad.Registros
{
    /// <summary>
    /// 
    /// </summary>
    public class DetalleCompra
    {
        /// <summary>
        /// Obtiene o establece el identificador detalle compra.
        /// </summary>
        /// <value>
        /// El identificador detalle compra.
        /// </value>
        public int IdDetalleCompra { get; set; }

        /// <summary>
        /// Obtiene o establece el objeto producto.
        /// </summary>
        /// <value>
        /// El objeto producto.
        /// </value>
        public Producto ObjProducto { get; set; }

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
        /// Obtiene o establece la cantidad.
        /// </summary>
        /// <value>
        /// La cantidad.
        /// </value>
        public int Cantidad { get; set; }

        /// <summary>
        /// Obtiene o establece el monto total de la compra.
        /// </summary>
        /// <value>
        /// El monto total.
        /// </value>
        public decimal MontoTotal { get; set; }

        /// <summary>
        /// Obtiene o establece la fecha de registro.
        /// </summary>
        /// <value>
        /// La fecha registro.
        /// </value>
        public string FechaRegistro { get; set; }
    }
}
