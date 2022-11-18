using Entidad.Roles;
using System.Collections.Generic;

namespace Entidad.Registros
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public Usuario ObjUsuario { get; set; }
        public Proveedor ObjProvedor { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public decimal MontoTotal { get; set; }
        public List<DetalleCompra> ListDetalleCompra { get; set; }
        public string FechaRegistro { get; set; }
    }
}
