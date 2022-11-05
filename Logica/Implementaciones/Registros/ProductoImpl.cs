using Datos.Repositorios.Registros;
using Entidad.Registros;
using System.Collections.Generic;
using System;

namespace Logica.Implementaciones.Registros
{
    public class ProductoImpl : Servicios.Registros.IServicioProducto
    {
        List<Producto> productos;
        RepositorioProducto repoProductos;

        public ProductoImpl()
        {
            repoProductos = new RepositorioProducto("productos.dat");
            productos = repoProductos.GetProductos();
        }

        public bool ActualizarProducto(Producto producto)
        {
            try
            {
                foreach (var item in productos)
                {
                    if (item.Equals(producto.Nombre))
                    {
                        item.IdProducto = producto.IdProducto;
                        item.Codigo = producto.Codigo;
                        item.Nombre = producto.Nombre;
                        item.Descripcion = producto.Descripcion;
                        item.Categoria = producto.Categoria;
                        item.Stock = producto.Stock;
                        item.StockInicial = producto.StockInicial;
                        item.PrecioCompra = producto.PrecioCompra;
                        item.PrecioVenta = producto.PrecioVenta;
                        item.FechaRegistro = producto.FechaRegistro;
                        item.Estado = producto.Estado;
                        break;
                    }
                }
                repoProductos.Update(productos, true);
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public bool AgregarProducto(Producto producto)
        {
            try
            {
                repoProductos.GuardarDatos(producto);
                productos = repoProductos.GetProductos();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public bool EliminarProducto(Producto producto)
        {
            try
            {
                productos.Remove(producto);
                repoProductos.Update(productos, false);
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public List<Producto> ListarProductos() { return productos; }
    }
}
