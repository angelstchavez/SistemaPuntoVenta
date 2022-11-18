namespace Entidad.Registros
{
    public class DetalleCompra
    {
        public int IdDetalleCompra { get; set; }
        public Producto ObjProducto { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal MontoTotal { get; set; }
        public string FechaRegistro { get; set; }
    }
}
