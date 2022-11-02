using System.Collections.Generic;

namespace Entidad.Registros
{
    public class Venta
    {
        public string IdVenta { get; set; }
        public string Usuario { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string DocumentoCliente { get; set; }
        public string NombreCliente { get; set; }
        public decimal MontoPago { get; set; }
        public decimal MontoCambio { get; set; }
        public decimal MontoTotal { get; set; }
        public List<Producto> Productos { get; set; }
        public string FechaRegistro { get; set; }

        public override string ToString()
        {
            return $"{IdVenta};{Usuario};{TipoDocumento};{NumeroDocumento};{DocumentoCliente};" +
                $"{NombreCliente};{MontoPago};{MontoCambio};{MontoTotal};{Productos};{FechaRegistro}";
        }
    }
}
