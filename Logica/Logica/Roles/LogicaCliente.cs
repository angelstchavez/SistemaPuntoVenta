using Datos.Datos.Roles;
using Entidad.Roles;
using System.Collections.Generic;

namespace Logica.Logica.Roles
{
    /// <summary>
    /// 
    /// </summary>
    public class LogicaCliente
    {
        /// <summary>
        /// The datos cliente
        /// </summary>
        private DatosCliente datosCliente = new DatosCliente();

        /// <summary>
        /// Listars this instance.
        /// </summary>
        /// <returns></returns>
        public List<Cliente> Listar()
        {
            return datosCliente.ListarClientes();
        }

        /// <summary>
        /// Registrars the specified cliente.
        /// </summary>
        /// <param name="Cliente">The cliente.</param>
        /// <param name="mensaje">The mensaje.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Editars the specified cliente.
        /// </summary>
        /// <param name="Cliente">The cliente.</param>
        /// <param name="mensaje">The mensaje.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Eliminars the specified cliente.
        /// </summary>
        /// <param name="Cliente">The cliente.</param>
        /// <param name="mensaje">The mensaje.</param>
        /// <returns></returns>
        public bool Eliminar(Cliente Cliente, out string mensaje)
        {
            return datosCliente.EliminarCliente(Cliente, out mensaje);
        }
    }
}
