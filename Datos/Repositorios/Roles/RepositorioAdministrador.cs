using Entidad.Roles;
using Seguridad;
using System;
using System.Collections.Generic;
using System.IO;

namespace Datos.Repositorios.Roles
{
    public class RepositorioAdministrador : Archivos.Roles.ArchivoAdministrador
    {

        public RepositorioAdministrador() : base()
        {
        }

        public RepositorioAdministrador(string ruta) : base(ruta)
        {
        }

        public List<Administrador> GetAdministradores()
        {
            try
            {
                StreamReader sr = new StreamReader(ruta);
                List<Administrador> administrador = new List<Administrador>();
                while (!sr.EndOfStream)
                {
                    administrador.Add(Mappear(sr.ReadLine()));
                }
                sr.Close();
                return administrador;
            }
            catch (Exception e) { throw e; }
        }

        public Administrador Mappear(string cadena)
        {
            try
            {
                Administrador administrador = new Administrador();
                administrador.Id = int.Parse(cadena.Split(';')[0]);
                administrador.Nombres = cadena.Split(';')[1];
                administrador.Apellidos = cadena.Split(';')[2];
                administrador.NumeroDocumento = cadena.Split(';')[3];
                administrador.NomUsuario = cadena.Split(';')[4];
                administrador.FechaRegistro = cadena.Split(';')[5];
                administrador.Estado = bool.Parse(cadena.Split(';')[6]);
                return administrador;
            }
            catch (Exception e) { throw e; }
        }

        public bool Update(List<Administrador> administradores, bool modo)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta, modo);
                foreach (var item in administradores) { sw.WriteLine(item.ToString()); }
                sw.Close();
                return true;
            }
            catch (Exception e) { throw e; }

        }
    }
}
