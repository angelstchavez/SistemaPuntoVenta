using Datos.Datos.Roles;
using Entidad.Roles;
using System.Collections.Generic;

namespace Logica.Logica.Roles
{
    /// <summary>
    /// 
    /// </summary>
    public class LogicaProveedor
    {
        /// <summary>
        /// The datos proveedor
        /// </summary>
        private DatosProveedor datosProveedor = new DatosProveedor();

        /// <summary>
        /// Listars this instance.
        /// </summary>
        /// <returns></returns>
        public List<Proveedor> Listar()
        {
            return datosProveedor.ListarProveedores();
        }

        /// <summary>
        /// Registrars the specified proveedor.
        /// </summary>
        /// <param name="Proveedor">The proveedor.</param>
        /// <param name="mensaje">The mensaje.</param>
        /// <returns></returns>
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
        /// Editars the specified proveedor.
        /// </summary>
        /// <param name="Proveedor">The proveedor.</param>
        /// <param name="mensaje">The mensaje.</param>
        /// <returns></returns>
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
        /// Eliminars the specified proveedor.
        /// </summary>
        /// <param name="Proveedor">The proveedor.</param>
        /// <param name="mensaje">The mensaje.</param>
        /// <returns></returns>
        public bool Eliminar(Proveedor Proveedor, out string mensaje)
        {
            return datosProveedor.EliminarProveedor(Proveedor, out mensaje);
        }
    }
}
