using Entidad.Registros;
using System.Collections.Generic;

namespace Logica.Servicios.Registros
{
    public interface IServicioReporte
    {
        bool AgregarReporte(Reporte reporte);
        bool EliminarReporte(Reporte reporte);
        bool ActualizarReporte(Reporte reporte);
        List<Reporte> ListaReportes();
    }
}
