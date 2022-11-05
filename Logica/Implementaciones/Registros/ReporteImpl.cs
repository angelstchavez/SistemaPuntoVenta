using Datos.Repositorios.Registros;
using Entidad.Registros;
using System.Collections.Generic;
using System;

namespace Logica.Implementaciones.Registros
{
    public class ReporteImpl : Servicios.Registros.IServicioReporte
    {
        List<Reporte> reportes;
        RepositorioReporte repoReportes;

        public ReporteImpl()
        {
            repoReportes = new RepositorioReporte("reportes.dat");
            reportes = repoReportes.GetReportes();
        }

        public bool ActualizarReporte(Reporte reporte)
        {
            try
            {
                foreach (var item in reportes)
                {
                    if (item.Equals(reporte.IdReporte))
                    {
                        item.IdReporte = reporte.IdReporte;
                        item.FechaRegistro = reporte.FechaRegistro;
                        item.Estado = reporte.Estado;
                        break;
                    }
                }
                repoReportes.Update(reportes, true);
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public bool AgregarReporte(Reporte reporte)
        {
            try
            {
                repoReportes.GuardarDatos(reporte);
                reportes = repoReportes.GetReportes();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public bool EliminarReporte(Reporte reporte)
        {
            try
            {
                reportes.Remove(reporte);
                repoReportes.Update(reportes, false);
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public List<Reporte> ListarReportes() { return reportes; }
    }
}
