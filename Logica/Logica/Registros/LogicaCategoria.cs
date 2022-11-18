using Datos.Datos.Registros;
using Entidad.Registros;
using System.Collections.Generic;

namespace Logica.Logica.Registros
{
    public class LogicaCategoria
    {
        private DatosCategoria datosCategoria = new DatosCategoria();

        public List<Categoria> Listar()
        {
            return datosCategoria.ListarCategorias();
        }

        public int Registrar(Categoria Categoria, out string mensaje)
        {
            mensaje = string.Empty;
            if (Categoria.Descripcion == "") { mensaje += "La categoría no puede quedar vacía."; } 
            if (mensaje != string.Empty) { return 0; }
            else { return datosCategoria.RegistrarCategoria(Categoria, out mensaje); }
        }

        public bool Editar(Categoria Categoria, out string mensaje)
        {
            mensaje = string.Empty;
            if (Categoria.Descripcion == "") { mensaje += "La categoría no puede quedar vacía."; }
            if (mensaje != string.Empty) { return false; }
            else { return datosCategoria.EditarCategoria(Categoria, out mensaje); }

        }

        public bool Eliminar(Categoria Categoria, out string mensaje)
        {
            return datosCategoria.EliminarCategoria(Categoria, out mensaje);
        }
    }
}

