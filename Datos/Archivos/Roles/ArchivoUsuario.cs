using Entidad.Roles;
using System;
using System.Collections.Generic;
using System.IO;

namespace Datos.Archivos.Roles
{
    public class ArchivoUsuario
    {
        protected string ruta = "usuarios.dat";

        public ArchivoUsuario()
        {
            this.ruta = "usuarios.dat";
        }

        public ArchivoUsuario(string ruta)
        {
            this.ruta = ruta;
        }

        public bool GuardarDatos(Usuario usuario)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta, true);
                sw.WriteLine(usuario.ToString());
                sw.Close();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public bool update(List<Usuario> usuario)
        {
            try
            {
                StreamWriter sw = new StreamWriter("temporal", true);
                foreach (var item in usuario) { sw.WriteLine(item); }
                sw.Close();
                File.Delete(ruta);
                File.Move("temporal", ruta);
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public void vaciar()
        {
            StreamWriter sw = new StreamWriter(ruta, false);
            sw.Write("");
            sw.Close();
        }
    }
}
