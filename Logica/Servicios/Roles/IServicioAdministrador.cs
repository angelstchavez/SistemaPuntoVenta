using Entidad.Roles;
using System.Collections.Generic;

namespace Logica.Servicios.Roles
{
    public interface IServicioAdministrador
    {
        bool AgregarAdministrador(Administrador administrador);
        bool EliminarAdministrador(Administrador administrador);
        bool ActualizarAdministrador(Administrador administrador);
        List<Administrador> ListaAdministradores();
    }
}
