using Datos.Datos.Registros;
using Entidad.Registros;
using System.Collections.Generic;

namespace Logica.Logica.Registros
{
    /// <summary>
    /// Es una clase que contiene métodos que le permiten agregar, editar, eliminar y listar categorías.
    /// </summary>
    public class LogicaCategoria
    {
        /// <summary>
        /// Los datos de las categorias.
        /// </summary>
        private DatosCategoria datosCategoria = new DatosCategoria();

        /// <summary>
        /// Enumera esta instancia.
        /// </summary>
        /// <returns>la lista de categorias</returns>
        public List<Categoria> Listar()
        {
            return datosCategoria.ListarCategorias();
        }

        /// <summary>
        /// Registra la categoría especificada.
        /// </summary>
        /// <param name="Categoria">Una categoria.</param>
        /// <param name="mensaje">Un mensaje.</param>
        /// <returns><c>true</c> si el registro es exitoso; de lo contrario, <c>false</c>.</returns>
        public int Registrar(Categoria Categoria, out string mensaje)
        {
            mensaje = string.Empty;
            if (Categoria.Descripcion == "") { mensaje += "La categoría no puede quedar vacía."; } 
            if (mensaje != string.Empty) { return 0; }
            else { return datosCategoria.RegistrarCategoria(Categoria, out mensaje); }
        }

        /// <summary>
        /// Edita la categoría especificada.
        /// </summary>
        /// <param name="Categoria">La categoria.</param>
        /// <param name="mensaje">Un mensaje.</param>
        /// <returns><c>true</c> si la edición es exitosa; de lo contrario, <c>false</c>.</returns>
        public bool Editar(Categoria Categoria, out string mensaje)
        {
            mensaje = string.Empty;
            if (Categoria.Descripcion == "") { mensaje += "La categoría no puede quedar vacía."; }
            if (mensaje != string.Empty) { return false; }
            else { return datosCategoria.EditarCategoria(Categoria, out mensaje); }

        }

        /// <summary>
        /// Elimina la categoría especificada.
        /// </summary>
        /// <param name="Categoria">La categoria.</param>
        /// <param name="mensaje">Un mensaje.</param>
        /// <returns><c>true</c> si la eliminación es exitosa; de lo contrario, <c>false</c>.</returns>
        public bool Eliminar(Categoria Categoria, out string mensaje)
        {
            return datosCategoria.EliminarCategoria(Categoria, out mensaje);
        }
    }
}

