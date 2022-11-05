using Entidad.Registros;
using System.Collections.Generic;
using System;
using Datos.Repositorios.Registros;

namespace Logica.Implementaciones.Registros
{
    public class CategoriaImpl : Servicios.Registros.IServicioCategoria
    {
        List<Categoria> categorias;
        RepositorioCategoria reposCategoria;

        public CategoriaImpl()
        {
            reposCategoria = new RepositorioCategoria("categorias.dat");
            categorias = reposCategoria.GetCategorias();
        }

        public bool ActualizarCategoria(Categoria categoria)
        {
            try
            {
                foreach (var item in categorias)
                {
                    if (item.Equals(categoria.Nombre))
                    {
                        item.IdCategoria = categoria.IdCategoria;
                        item.Nombre = categoria.Nombre;
                        item.FechaRegistro = categoria.FechaRegistro;
                        item.Estado = categoria.Estado;
                        break;
                    }
                }
                reposCategoria.Update(categorias, true);
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public bool AgregarCategoria(Categoria categoria)
        {
            try
            {
                reposCategoria.GuardarDatos(categoria);
                categorias = reposCategoria.GetCategorias();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public bool EliminarCategoria(Categoria categoria)
        {
            try
            {
                categorias.Remove(categoria);
                reposCategoria.Update(categorias, false);
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public List<Categoria> ListarCategorias() { return categorias; }
    }
}
