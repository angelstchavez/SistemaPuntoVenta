namespace Entidad.Registros
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public int Stock { get; set; }
        public int StockInicial { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public bool Estado { get; set; }
        public string FechaRegistro { get; set; }

        public override string ToString()
        {
            return $"{IdProducto};{Codigo};{Nombre};{Descripcion};{Categoria};" +
                $"{Stock};{StockInicial};{PrecioCompra};{PrecioVenta};{FechaRegistro};{Estado}";
        }
    }
}
