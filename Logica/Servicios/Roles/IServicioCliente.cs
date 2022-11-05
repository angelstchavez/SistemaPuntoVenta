using Entidad.Roles;
using System.Collections.Generic;

namespace Logica.Servicios.Roles
{
    public interface IServicioCliente
    {
        bool AgregarCliente(Cliente cliente);
        bool EliminarCliente(Cliente cliente);
        bool ActualizarCliente(Cliente cliente);
        List<Cliente> ListaClientes();
    }
}
