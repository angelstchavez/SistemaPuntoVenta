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
        /// The datos permisos
        /// </summary>
        private DatosPermisos datosPermisos = new DatosPermisos();

        /// <summary>
        /// Listars the specified identifier usuario.
        /// </summary>
        /// <param name="idUsuario">The identifier usuario.</param>
        /// <returns></returns>
        public List<Permiso> Listar(int idUsuario)
        {
            return datosPermisos.ListarPermisos(idUsuario);
        }
    }
}
