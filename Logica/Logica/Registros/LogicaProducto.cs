using Datos.Datos.Registros;
using Datos.Datos.Roles;
using Entidad.Registros;
using Entidad.Roles;
using System.Collections.Generic;

namespace Logica.Logica.Registros
{
    /// <summary>
    /// 
    /// </summary>
    public class LogicaProducto
    {
        /// <summary>
        /// Los datos de los productos.
        /// </summary>
        private DatosProducto datosProducto = new DatosProducto();

        /// <summary>
        /// Enumera esta instancia.
        /// </summary>
        /// <returns>La lista de productos.</returns>
        public List<Producto> Listar()
        {
            return datosProducto.ListarProductos();
        }

        /// <summary>
        /// Registra el producto especificado.
        /// </summary>
        /// <param name="Producto">Un producto.</param>
        /// <param name="mensaje">Un mensaje.</param>
        /// <returns></returns>
        public int Registrar(Producto Producto, out string mensaje)
        {
            mensaje = string.Empty;
            if (Producto.Codigo == "") { mensaje += "El Codigo no puede quedar vacío."; }
            if (Producto.Nombre == "") { mensaje += "El nombre no puede quedar vacío."; }
            if (Producto.Descripcion == "") { mensaje += "La Descripcion no puede quedar vacía."; }
            if (mensaje != string.Empty) { return 0; }
            else { return datosProducto.RegistrarProducto(Producto, out mensaje); }
        }

        /// <summary>
        /// Edita el producto especificado.
        /// </summary>
        /// <param name="Producto">El producto.</param>
        /// <param name="mensaje">Un mensaje.</param>
        /// <returns><c>true</c> si la edición es exitosa; de lo contrario, <c>false</c>.</returns>
        public bool Editar(Producto Producto, out string mensaje)
        {
            mensaje = string.Empty;
            if (Producto.Codigo == "") { mensaje += "El Codigo no puede quedar vacío."; }
            if (Producto.Nombre == "") { mensaje += "El nombre no puede quedar vacío."; }
            if (Producto.Descripcion == "") { mensaje += "La Descripcion no puede quedar vacía."; }
            if (mensaje != string.Empty) { return false; }
            else { return datosProducto.EditarProducto(Producto, out mensaje); }

        }

        /// <summary>
        /// Elimina el producto especificado.
        /// </summary>
        /// <param name="Producto">El producto.</param>
        /// <param name="mensaje">Un mensaje.</param>
        /// <returns><c>true</c> si la eliminación es exitosa; de lo contrario, <c>false</c>.</returns>
        public bool Eliminar(Producto Producto, out string mensaje)
        {
            return datosProducto.EliminarProducto(Producto, out mensaje);
        }
    }
}
