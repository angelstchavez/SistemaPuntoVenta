using Entidad.Roles;
using System.Collections.Generic;
using System.IO;
using System;
using Seguridad;

namespace Datos.Repositorios.Roles
{
    public class RepositorioUsuario : Archivos.Roles.ArchivoUsuario
    {
        public RepositorioUsuario() : base()
        {
        }

        public RepositorioUsuario(string ruta) : base(ruta)
        {
        }

        public List<Usuario> GetUsuarios()
        {
            try
            {
                StreamReader sr = new StreamReader(ruta);
                List<Usuario> usuarios = new List<Usuario>();
                while (!sr.EndOfStream)
                {
                    usuarios.Add(Mappear(Encriptacion.Decrypt(sr.ReadLine())));
                }
                sr.Close();
                return usuarios;
            }
            catch (Exception e) { throw e; }
        }

        public Usuario Mappear(string cadena)
        {
            try
            {
                Usuario usuario = new Usuario();
                usuario.Id = int.Parse(cadena.Split(';')[0]);
                usuario.Nombres = cadena.Split(';')[1];
                usuario.Apellidos = cadena.Split(';')[2];
                usuario.NumeroDocumento = cadena.Split(';')[3];
                usuario.NomUsuario = cadena.Split(';')[4];
                usuario.FechaRegistro = cadena.Split(';')[5];
                usuario.Estado = bool.Parse(cadena.Split(';')[6]);
                return usuario;
            }
            catch (Exception e) { throw e; }
        }

        public bool Update(List<Usuario> usuarios, bool modo)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta, modo);
                foreach (var item in usuarios) { sw.WriteLine(item.ToString()); }
                sw.Close();
                return true;
            }
            catch (Exception e) { throw e; }

        }
    }
}
