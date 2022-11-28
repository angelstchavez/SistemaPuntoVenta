using Datos.Datos.Registros;
using Entidad.Roles;
using System.Collections.Generic;

namespace Logica.Logica.Registros
{
    /// <summary>
    /// 
    /// </summary>
    public class LogicaPermiso
    {
        /// <summary>
        /// Los datos de los permisos.
        /// </summary>
        private DatosPermisos datosPermisos = new DatosPermisos();

        /// <summary>
        /// Lista el identificador de usuario especificado.
        /// </summary>
        /// <param name="idUsuario">El identificador usuario.</param>
        /// <returns></returns>
        public List<Permiso> Listar(int idUsuario)
        {
            return datosPermisos.ListarPermisos(idUsuario);
        }
    }
}
