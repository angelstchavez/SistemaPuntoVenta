using Datos.Repositorios.Roles;
using Entidad.Roles;
using Logica.Servicios.Roles;
using System.Collections.Generic;
using System;

namespace Logica.Implementaciones.Roles
{
    public class UsuarioImpl : IServicioUsuario
    {
        List<Usuario> usuarios;
        RepositorioUsuario reposUsuarios;

        public UsuarioImpl()
        {
            reposUsuarios = new RepositorioUsuario("usuarios.dat");
            usuarios = reposUsuarios.GetUsuarios();
        }

        public bool ActualizarUsuario(Usuario usuario)
        {
            try
            {
                foreach (var item in usuarios)
                {
                    if (item.Equals(usuario.Nombres))
                    {
                        item.Id = usuario.Id;
                        item.Nombres = usuario.Nombres;
                        item.Apellidos = usuario.Apellidos;
                        item.NumeroDocumento = usuario.NumeroDocumento;
                        item.NomUsuario = usuario.NomUsuario;
                        item.FechaRegistro = usuario.FechaRegistro;
                        item.Estado = usuario.Estado;
                        break;
                    }
                }
                reposUsuarios.Update(usuarios, true);
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public bool AgregarUsuario(Usuario usuario)
        {
            try
            {
                reposUsuarios.GuardarDatos(usuario);
                usuarios = reposUsuarios.GetUsuarios();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public bool EliminarUsuario(Usuario usuario)
        {
            try
            {
                usuarios.Remove(usuario);
                reposUsuarios.Update(usuarios, false);
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public List<Usuario> ListarUsuarios() { return usuarios; }
    }
}
