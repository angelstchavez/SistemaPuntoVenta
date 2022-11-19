using Datos.Datos.Roles;
using Entidad.Roles;
using System.Collections.Generic;

namespace Logica.Logica.Roles
{
    public class LogicaProveedor
    {
        private DatosProveedor datosProveedor = new DatosProveedor();

        public List<Proveedor> Listar()
        {
            return datosProveedor.ListarProveedores();
        }

        public int Registrar(Proveedor Proveedor, out string mensaje)
        {
            mensaje = string.Empty;
            if (Proveedor.Documento == "") { mensaje += "El documento no puede quedar vacío."; }
            if (Proveedor.RazonSocial == "") { mensaje += "La razón social no puede quedar vacío."; }
            if (Proveedor.Telefono == "") { mensaje += "La telefono no puede quedar vacía."; }
            if (mensaje != string.Empty) { return 0; }
            else { return datosProveedor.RegistrarProveedor(Proveedor, out mensaje); }
        }

        public bool Editar(Proveedor Proveedor, out string mensaje)
        {
            mensaje = string.Empty;
            if (Proveedor.Documento == "") { mensaje += "El documento no puede quedar vacío."; }
            if (Proveedor.RazonSocial == "") { mensaje += "La razón social no puede quedar vacío."; }
            if (Proveedor.Telefono == "") { mensaje += "El telefono no puede quedar vacía."; }
            if (mensaje != string.Empty) { return false; }
            else { return datosProveedor.EditarProveedor(Proveedor, out mensaje); }

        }

        public bool Eliminar(Proveedor Proveedor, out string mensaje)
        {
            return datosProveedor.EliminarProveedor(Proveedor, out mensaje);
        }
    }
}
