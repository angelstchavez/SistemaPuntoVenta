using Entidad.Registros;
using Seguridad;
using System;
using System.Collections.Generic;
using System.IO;

namespace Datos.Repositorios.Registros
{
    public class RepositorioCategoria : Archivos.ArchivoCategoria
    {
        public RepositorioCategoria() : base()
        {
        }

        public RepositorioCategoria(string ruta) : base(ruta)
        {
        }

        public List<Categoria> GetCategorias()
        {
            try
            {
                StreamReader sr = new StreamReader(ruta);
                List<Categoria> categorias = new List<Categoria>();
                while (!sr.EndOfStream)
                {
                    categorias.Add(Mappear(sr.ReadLine()));
                }
                sr.Close();
                return categorias;
            }
            catch (Exception e) { throw e; }
        }

        public Categoria Mappear(string cadena)
        {
            try
            {
                Categoria categoria = new Categoria();
                categoria.IdCategoria = int.Parse(cadena.Split(';')[0]);
                categoria.Nombre = cadena.Split(';')[1];
                categoria.FechaRegistro = cadena.Split(';')[2];
                categoria.Estado = bool.Parse(cadena.Split(';')[3]);
                return categoria;
            }
            catch (Exception e) { throw e; }
        }

        public bool Update(List<Categoria> categorias, bool modo)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta, modo);
                foreach (var item in categorias) { sw.WriteLine(item.ToString()); }
                sw.Close();
                return true;
            }
            catch (Exception e) { throw e; }

        }
    }
}
