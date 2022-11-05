using Entidad.Registros;
using System.Collections.Generic;

namespace Logica.Servicios.Registros
{
    public interface IServicioVenta
    {
        bool AgregarVenta(Venta venta);
        bool EliminarVenta(Venta venta);
        bool ActualizarVenta(Venta venta);
        List<Venta> ListarVentas();
    }
}
