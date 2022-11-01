using Entidad.Roles;
using System;
using System.Collections.Generic;
using System.IO;

namespace Datos.Archivos.Roles
{
    public class ArchivoAdministrador
    {
        protected string ruta = "administradores.dat";

        public ArchivoAdministrador()
        {
            this.ruta = "administradores.dat";
        }

        public ArchivoAdministrador(string ruta)
        {
            this.ruta = ruta;
        }

        public bool GuardarDatos(Administrador administrador)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta, true);
                sw.WriteLine(administrador.ToString());
                sw.Close();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public bool update(List<Administrador> administrador)
        {
            try
            {
                StreamWriter sw = new StreamWriter("temporal", true);
                foreach (var item in administrador) { sw.WriteLine(item); }
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
