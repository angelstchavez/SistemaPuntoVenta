using Datos.Datos.Registros;
using Entidad.Roles;
using System.Collections.Generic;

namespace Logica.Logica.Registros
{
    public class LogicaPermiso
    {
        private DatosPermisos datosPermisos = new DatosPermisos();

        public List<Permiso> Listar(int idUsuario)
        {
            return datosPermisos.ListarPermisos(idUsuario);
        }
    }
}
