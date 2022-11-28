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
        /// The datos producto
        /// </summary>
        private DatosProducto datosProducto = new DatosProducto();

        /// <summary>
        /// Listars this instance.
        /// </summary>
        /// <returns></returns>
        public List<Producto> Listar()
        {
            return datosProducto.ListarProductos();
        }

        /// <summary>
        /// Registrars the specified producto.
        /// </summary>
        /// <param name="Producto">The producto.</param>
        /// <param name="mensaje">The mensaje.</param>
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
        /// Editars the specified producto.
        /// </summary>
        /// <param name="Producto">The producto.</param>
        /// <param name="mensaje">The mensaje.</param>
        /// <returns></returns>
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
        /// Eliminars the specified producto.
        /// </summary>
        /// <param name="Producto">The producto.</param>
        /// <param name="mensaje">The mensaje.</param>
        /// <returns></returns>
        public bool Eliminar(Producto Producto, out string mensaje)
        {
            return datosProducto.EliminarProducto(Producto, out mensaje);
        }
    }
}
