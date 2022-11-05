using Entidad.Registros;
using System.Collections.Generic;

namespace Logica.Servicios.Registros
{
    public interface IServicioProducto
    {
        bool AgregarProducto(Producto producto);
        bool EliminarProducto(Producto producto);
        bool ActualizarProducto(Producto producto);
        List<Producto> ListarProductos();
    }
}
