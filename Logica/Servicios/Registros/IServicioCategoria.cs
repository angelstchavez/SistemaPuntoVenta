using Entidad.Registros;
using System.Collections.Generic;

namespace Logica.Servicios.Registros
{
    public interface IServicioCategoria
    {
        bool AgregarCategoria(Categoria categoria);
        bool EliminarCategoria(Categoria categoria);
        bool ActualizarCategoria(Categoria categoria);
        List<Categoria> ListarCategorias();
    }
}
