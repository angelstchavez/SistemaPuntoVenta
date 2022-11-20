using Datos.Datos.Roles;
using Entidad.Roles;
using System.Collections.Generic;

namespace Logica.Logica.Roles
{
    public class LogicaCliente
    {
        private DatosCliente datosCliente = new DatosCliente();

        public List<Cliente> Listar()
        {
            return datosCliente.ListarClientes();
        }

        public int Registrar(Cliente Cliente, out string mensaje)
        {
            mensaje = string.Empty;
            if (Cliente.Documento == "") { mensaje += "El documento no puede quedar vacío."; }
            if (Cliente.NombreCompleto == "") { mensaje += "El nombre no puede quedar vacío."; }
            if (Cliente.Correo == "") { mensaje += "El correo no puede quedar vacía."; }
            if (Cliente.Telefono == "") { mensaje += "El telefono no puede quedar vacía."; }
            if (mensaje != string.Empty) { return 0; }
            else { return datosCliente.RegistrarCliente(Cliente, out mensaje); }
        }

        public bool Editar(Cliente Cliente, out string mensaje)
        {
            mensaje = string.Empty;
            if (Cliente.Documento == "") { mensaje += "El documento no puede quedar vacío."; }
            if (Cliente.NombreCompleto == "") { mensaje += "El nombre no puede quedar vacío."; }
            if (Cliente.Correo == "") { mensaje += "El correo no puede quedar vacía."; }
            if (Cliente.Telefono == "") { mensaje += "El telefono no puede quedar vacía."; }
            if (mensaje != string.Empty) { return false; }
            else { return datosCliente.EditarCliente(Cliente, out mensaje); }

        }

        public bool Eliminar(Cliente Cliente, out string mensaje)
        {
            return datosCliente.EliminarCliente(Cliente, out mensaje);
        }
    }
}
