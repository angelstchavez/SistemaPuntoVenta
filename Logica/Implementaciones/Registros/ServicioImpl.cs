using Datos.Repositorios.Registros;
using Entidad.Registros;
using System.Collections.Generic;
using System;

namespace Logica.Implementaciones.Registros
{
    public class ServicioImpl : Servicios.Registros.IServicioServicio
    {
        List<Servicio> servicios;
        RepositorioServicio repoServicios;

        public ServicioImpl()
        {
            repoServicios = new RepositorioServicio("servicios.dat");
            servicios = repoServicios.GetServicios();
        }

        public bool ActualizarServicio(Servicio servicio)
        {
            try
            {
                foreach (var item in servicios)
                {
                    if (item.Equals(servicio.Nombre))
                    {
                        item.IdServicio = servicio.IdServicio;
                        item.Nombre = servicio.Nombre;
                        item.FechaRegistro = servicio.FechaRegistro;
                        item.Estado = servicio.Estado;
                        break;
                    }
                }
                repoServicios.Update(servicios, true);
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public bool AgregarServicio(Servicio servicio)
        {
            try
            {
                repoServicios.GuardarDatos(servicio);
                servicios = repoServicios.GetServicios();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public bool EliminarServicio(Servicio servicio)
        {
            try
            {
                servicios.Remove(servicio);
                repoServicios.Update(servicios, false);
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public List<Servicio> ListarServicios() { return servicios; }
    }
}
