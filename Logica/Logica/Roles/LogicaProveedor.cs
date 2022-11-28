using Datos.Datos.Roles;
using Entidad.Roles;
using System.Collections.Generic;

namespace Logica.Logica.Roles
{
    /// <summary>
    /// Es una clase que contiene métodos que le permiten agregar, editar, eliminar y listar proveedores.
    /// </summary>
    public class LogicaProveedor
    {
        /// <summary>
        /// Los datos de los provedoores.
        /// </summary>
        private DatosProveedor datosProveedor = new DatosProveedor();

        /// <summary>
        /// Enumera esta instancia.
        /// </summary>
        /// <returns>La lista de proveedores.</returns>
        public List<Proveedor> Listar()
        {
            return datosProveedor.ListarProveedores();
        }

        /// <summary>
        /// Registra al proveedor especificado.
        /// </summary>
        /// <param name="Proveedor">Un proveedor.</param>
        /// <param name="mensaje">Un mensaje.</param>
        /// <returns><c>true</c> si el registro es exitoso; de lo contrario, <c>false</c>.</returns>
        public int Registrar(Proveedor Proveedor, out string mensaje)
        {
            mensaje = string.Empty;
            if (Proveedor.Documento == "") { mensaje += "El documento no puede quedar vacío."; }
            if (Proveedor.RazonSocial == "") { mensaje += "La razón social no puede quedar vacío."; }
            if (Proveedor.Telefono == "") { mensaje += "La telefono no puede quedar vacía."; }
            if (mensaje != string.Empty) { return 0; }
            else { return datosProveedor.RegistrarProveedor(Proveedor, out mensaje); }
        }

        /// <summary>
        /// Edita el proveedor especificado.
        /// </summary>
        /// <param name="Proveedor">Un proveedor.</param>
        /// <param name="mensaje">Un mensaje.</param>
        /// <returns><c>true</c> si la edición es exitosa; de lo contrario, <c>false</c>.</returns>
        public bool Editar(Proveedor Proveedor, out string mensaje)
        {
            mensaje = string.Empty;
            if (Proveedor.Documento == "") { mensaje += "El documento no puede quedar vacío."; }
            if (Proveedor.RazonSocial == "") { mensaje += "La razón social no puede quedar vacío."; }
            if (Proveedor.Telefono == "") { mensaje += "El telefono no puede quedar vacía."; }
            if (mensaje != string.Empty) { return false; }
            else { return datosProveedor.EditarProveedor(Proveedor, out mensaje); }

        }

        /// <summary>
        /// Elimina el proveedor especificado.
        /// </summary>
        /// <param name="Proveedor">Un proveedor.</param>
        /// <param name="mensaje">Un mensaje.</param>
        /// <returns><c>true</c> si la eliminación es exitosa; de lo contrario, <c>false</c>.</returns>
        public bool Eliminar(Proveedor Proveedor, out string mensaje)
        {
            return datosProveedor.EliminarProveedor(Proveedor, out mensaje);
        }
    }
}
