using Datos.Datos.Registros;
using Entidad.Roles;
using System.Collections.Generic;

namespace Logica.Logica.Roles
{
    /// <summary>
    /// 
    /// </summary>
    public class LogicaRol
    {

        /// <summary>
        /// The datos rol
        /// </summary>
        private DatosRol datosRol = new DatosRol();

        /// <summary>
        /// Listars this instance.
        /// </summary>
        /// <returns></returns>
        public List<Rol> Listar()
        {
            return datosRol.ListarRoles();
        }
    }
}