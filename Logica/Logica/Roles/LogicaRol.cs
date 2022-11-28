using Datos.Datos.Registros;
using Entidad.Roles;
using System.Collections.Generic;

namespace Logica.Logica.Roles
{
    /// <summary>
    /// Es una clase que contiene métodos que le permiten listar roles.
    /// </summary>
    public class LogicaRol
    {

        /// <summary>
        /// Los datos del los roles.
        /// </summary>
        private DatosRol datosRol = new DatosRol();

        /// <summary>
        /// Enumera esta instancia.
        /// </summary>
        /// <returns>La lista de roles registrados.</returns>
        public List<Rol> Listar()
        {
            return datosRol.ListarRoles();
        }
    }
}