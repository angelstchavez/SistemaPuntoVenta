namespace Entidad.Registros
{
    /// <summary>
    /// 
    /// </summary>
    public class DetalleVenta
    {
        /// <summary>
        /// Obtiene o establece el identificador detalle venta.
        /// </summary>
        /// <value>
        /// El identificador detalle venta.
        /// </value>
        public int IdDetalleVenta { get; set; }

        /// <summary>
        /// Obtiene o establece el objeto producto.
        /// </summary>
        /// <value>
        /// El objeto producto.
        /// </value>
        public Producto ObjProducto { get; set; }

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
        /// Obtiene o establece el subtotal.
        /// </summary>
        /// <value>
        /// El subtotal.
        /// </value>
        public decimal SubTotal { get; set; }

        /// <summary>
        /// Obtiene o establece la fecha de registro.
        /// </summary>
        /// <value>
        /// La fecha de registro.
        /// </value>
        public string FechaRegistro { get; set; }
    }
}
