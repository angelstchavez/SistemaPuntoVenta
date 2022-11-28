using Datos.Datos.Registros;
using Entidad.Registros;
using System.Collections.Generic;

namespace Logica.Logica.Registros
{
    /// <summary>
    /// 
    /// </summary>
    public class LogicaCategoria
    {
        /// <summary>
        /// The datos categoria
        /// </summary>
        private DatosCategoria datosCategoria = new DatosCategoria();

        /// <summary>
        /// Listars this instance.
        /// </summary>
        /// <returns></returns>
        public List<Categoria> Listar()
        {
            return datosCategoria.ListarCategorias();
        }

        /// <summary>
        /// Registrars the specified categoria.
        /// </summary>
        /// <param name="Categoria">The categoria.</param>
        /// <param name="mensaje">The mensaje.</param>
        /// <returns></returns>
        public int Registrar(Categoria Categoria, out string mensaje)
        {
            mensaje = string.Empty;
            if (Categoria.Descripcion == "") { mensaje += "La categoría no puede quedar vacía."; } 
            if (mensaje != string.Empty) { return 0; }
            else { return datosCategoria.RegistrarCategoria(Categoria, out mensaje); }
        }

        /// <summary>
        /// Editars the specified categoria.
        /// </summary>
        /// <param name="Categoria">The categoria.</param>
        /// <param name="mensaje">The mensaje.</param>
        /// <returns></returns>
        public bool Editar(Categoria Categoria, out string mensaje)
        {
            mensaje = string.Empty;
            if (Categoria.Descripcion == "") { mensaje += "La categoría no puede quedar vacía."; }
            if (mensaje != string.Empty) { return false; }
            else { return datosCategoria.EditarCategoria(Categoria, out mensaje); }

        }

        /// <summary>
        /// Eliminars the specified categoria.
        /// </summary>
        /// <param name="Categoria">The categoria.</param>
        /// <param name="mensaje">The mensaje.</param>
        /// <returns></returns>
        public bool Eliminar(Categoria Categoria, out string mensaje)
        {
            return datosCategoria.EliminarCategoria(Categoria, out mensaje);
        }
    }
}

