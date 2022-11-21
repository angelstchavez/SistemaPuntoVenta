using Datos.Datos.Registros;
using Datos.Datos.Roles;
using Entidad.Registros;
using Entidad.Roles;
using System.Collections.Generic;

namespace Logica.Logica.Registros
{
    public class LogicaProducto
    {
        private DatosProducto datosProducto = new DatosProducto();

        public List<Producto> Listar()
        {
            return datosProducto.ListarProductos();
        }

        public int Registrar(Producto Producto, out string mensaje)
        {
            mensaje = string.Empty;
            if (Producto.Codigo == "") { mensaje += "El Codigo no puede quedar vacío."; }
            if (Producto.Nombre == "") { mensaje += "El nombre no puede quedar vacío."; }
            if (Producto.Descripcion == "") { mensaje += "La Descripcion no puede quedar vacía."; }
            if (mensaje != string.Empty) { return 0; }
            else { return datosProducto.RegistrarProducto(Producto, out mensaje); }
        }

        public bool Editar(Producto Producto, out string mensaje)
        {
            mensaje = string.Empty;
            if (Producto.Codigo == "") { mensaje += "El Codigo no puede quedar vacío."; }
            if (Producto.Nombre == "") { mensaje += "El nombre no puede quedar vacío."; }
            if (Producto.Descripcion == "") { mensaje += "La Descripcion no puede quedar vacía."; }
            if (mensaje != string.Empty) { return false; }
            else { return datosProducto.EditarProducto(Producto, out mensaje); }

        }

        public bool Eliminar(Producto Producto, out string mensaje)
        {
            return datosProducto.EliminarProducto(Producto, out mensaje);
        }
    }
}
