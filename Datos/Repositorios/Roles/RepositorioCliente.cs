using Entidad.Roles;
using System.Collections.Generic;
using System.IO;
using System;

namespace Datos.Repositorios.Roles
{
    public class RepositorioCliente : Archivos.Roles.ArchivoCliente
    {
        public RepositorioCliente() : base()
        {
        }

        public RepositorioCliente(string ruta) : base(ruta)
        {
        }

        public List<Cliente> GetClientes()
        {
            try
            {
                StreamReader sr = new StreamReader(ruta);
                List<Cliente> clientes = new List<Cliente>();
                while (!sr.EndOfStream)
                {
                    clientes.Add(Mappear(sr.ReadLine()));
                }
                sr.Close();
                return clientes;
            }
            catch (Exception e) { throw e; }
        }

        public Cliente Mappear(string cadena)
        {
            try
            {
                Cliente cliente = new Cliente();
                cliente.Id = int.Parse(cadena.Split(';')[0]);
                cliente.Nombres = cadena.Split(';')[1];
                cliente.Apellidos = cadena.Split(';')[2];
                cliente.NumeroDocumento = cadena.Split(';')[3];
                cliente.Correo = cadena.Split(';')[4];
                cliente.Telefono = cadena.Split(';')[5];
                cliente.FechaRegistro = cadena.Split(';')[6];
                cliente.Estado = bool.Parse(cadena.Split(';')[7]);
                return cliente;
            }
            catch (Exception e) { throw e; }
        }

        public bool Update(List<Cliente> clientes, bool modo)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta, modo);
                foreach (var item in clientes) { sw.WriteLine(item.ToString()); }
                sw.Close();
                return true;
            }
            catch (Exception e) { throw e; }

        }
    }
}
