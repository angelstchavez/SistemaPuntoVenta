using Entidad.Registros;
using System.Collections.Generic;
using System.IO;
using System;
using Seguridad;

namespace Datos.Repositorios.Registros
{
    public class RepositorioProducto : Archivos.ArchivoProducto
    {
        public RepositorioProducto() : base()
        {
        }

        public RepositorioProducto(string ruta) : base(ruta)
        {
        }

        public List<Producto> GetProductos()
        {
            try
            {
                StreamReader sr = new StreamReader(ruta);
                List<Producto> productos = new List<Producto>();
                while (!sr.EndOfStream)
                {
                    productos.Add(Mappear(sr.ReadLine()));
                }
                sr.Close();
                return productos;
            }
            catch (Exception e) { throw e; }
        }

        public Producto Mappear(string cadena)
        {
            try
            {
                Producto producto = new Producto();
                producto.IdProducto = int.Parse(cadena.Split(';')[0]);
                producto.Codigo = cadena.Split(';')[1];
                producto.Nombre = cadena.Split(';')[2];
                producto.Descripcion = cadena.Split(';')[3];
                producto.Categoria = cadena.Split(';')[4];
                producto.Stock = int.Parse(cadena.Split(';')[5]);
                producto.StockInicial = int.Parse(cadena.Split(';')[6]);
                producto.PrecioCompra = decimal.Parse(cadena.Split(';')[7]);
                producto.PrecioVenta = decimal.Parse(cadena.Split(';')[8]);
                producto.FechaRegistro = cadena.Split(';')[9];
                producto.Estado = bool.Parse(cadena.Split(';')[10]);
                return producto;
            }
            catch (Exception e) { throw e; }
        }

        public bool Update(List<Producto> productos, bool modo)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta, modo);
                foreach (var item in productos) { sw.WriteLine(item.ToString()); }
                sw.Close();
                return true;
            }
            catch (Exception e) { throw e; }

        }
    }
}
