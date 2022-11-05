using Entidad.Roles;
using System.Collections.Generic;

namespace Logica.Servicios.Roles
{
    public interface IServicioUsuario
    {
        bool AgregarUsuario(Usuario usuario);
        bool EliminarUsuario(Usuario usuario);
        bool ActualizarUsuario(Usuario usuario);
        List<Usuario> ListaUsuarios();
    }
}
