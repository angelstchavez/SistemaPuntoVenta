using Datos.Datos.Registros;
using Entidad.Roles;
using System.Collections.Generic;

namespace Logica.Logica.Roles
{
    public class LogicaRol
    {

        private DatosRol datosRol = new DatosRol();

        public List<Rol> Listar()
        {
            return datosRol.ListarRoles();
        }
    }
}