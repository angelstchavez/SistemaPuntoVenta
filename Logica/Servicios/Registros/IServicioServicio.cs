using Entidad.Registros;
using System.Collections.Generic;

namespace Logica.Servicios.Registros
{
    public interface IServicioServicio
    {
        bool AgregarServicio(Servicio rervicio);
        bool EliminarServicio(Servicio rervicio);
        bool ActualizarServicio(Servicio rervicio);
        List<Servicio> ListaServicios();
    }
}
