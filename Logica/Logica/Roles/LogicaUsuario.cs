using Datos.Datos.Roles;
using Entidad.Roles;
using System.Collections.Generic;

namespace Logica.Logica.Roles
{
    public class LogicaUsuario
    {
        private DatosUsuario datosUsuario = new DatosUsuario();

        public List<Usuario> Listar()
        {
            return datosUsuario.ListarUsuarios();
        }
    }
}
