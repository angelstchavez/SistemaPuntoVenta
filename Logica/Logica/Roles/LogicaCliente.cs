using Datos.Datos.Roles;
using Entidad.Roles;
using System.Collections.Generic;

namespace Logica.Logica.Roles
{
    /// <summary>
    /// Es una clase que contiene métodos que le permiten agregar, editar, eliminar y listar clientes.
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
        /// Registra el cliente especificado.
        /// </summary>
        /// <param name="Cliente">Un cliente.</param>
        /// <param name="mensaje">Un mensaje.</param>
        /// <returns><c>true</c> si el registro es exitoso; de lo contrario, <c>false</c>.</returns>
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
        /// Edita el cliente especificado.
        /// </summary>
        /// <param name="Cliente">Un cliente.</param>
        /// <param name="mensaje">Un mensaje.</param>
        /// <returns><c>true</c> si la edición es exitosa; de lo contrario, <c>false</c>.</returns>
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
        /// Elimina el cliente especificado.
        /// </summary>
        /// <param name="Cliente">Un cliente.</param>
        /// <param name="mensaje">Un mensaje.</param>
        /// <returns><c>true</c> si la eliminación es exitosa; de lo contrario, <c>false</c>.</returns>
        public bool Eliminar(Cliente Cliente, out string mensaje)
        {
            return datosCliente.EliminarCliente(Cliente, out mensaje);
        }
    }
}
