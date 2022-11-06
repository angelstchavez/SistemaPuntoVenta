using Datos.Repositorios.Roles;
using Entidad.Roles;
using System;
using System.Collections.Generic;

namespace Logica.Implementaciones.Roles
{
    public class ClienteImpl : Servicios.Roles.IServicioCliente
    {
        List<Cliente> clientes;
        RepositorioCliente reposClientes;

        public ClienteImpl()
        {
            reposClientes = new RepositorioCliente("clientes.dat");
            clientes = reposClientes.GetClientes();
        }

        public bool ActualizarCliente(Cliente cliente)
        {
            try
            {
                foreach (var item in clientes)
                {
                    if (item.Equals(cliente.Nombres))
                    {
                        item.Id = cliente.Id;
                        item.Nombres = cliente.Nombres;
                        item.Apellidos = cliente.Apellidos;
                        item.NumeroDocumento = cliente.NumeroDocumento;
                        item.Correo = cliente.Correo;
                        item.Telefono = cliente.Telefono;
                        item.FechaRegistro = cliente.FechaRegistro;
                        item.Estado = cliente.Estado;
                        break;
                    }
                }
                reposClientes.Update(clientes, true);
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public bool AgregarCliente(Cliente cliente)
        {
            try
            {
                reposClientes.GuardarDatos(cliente);
                clientes = reposClientes.GetClientes();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public bool EliminarCliente(Cliente cliente)
        {
            try
            {
                clientes.Remove(cliente);
                reposClientes.Update(clientes, false);
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public List<Cliente> ListarClientes() { return clientes; }
    }
}
