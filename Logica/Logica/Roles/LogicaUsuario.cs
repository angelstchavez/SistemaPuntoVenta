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

        public List<Usuario> Validad()
        {
            return datosUsuario.ValidarUsuarios();
        }

        public int Registrar(Usuario usuario, out string mensaje)
        {
            mensaje = string.Empty;
            if (usuario.Documento == "") { mensaje += "El documento no puede quedar vacío."; }
            if (usuario.NombreCompleto == "") { mensaje += "El nombre no puede quedar vacío."; }
            if (usuario.Contraseña == "") { mensaje += "La contraseña no puede quedar vacía."; }
            if (mensaje != string.Empty) { return 0; }
            else { return datosUsuario.RegistrarUsuario(usuario, out mensaje); }
        }

        public bool Editar(Usuario usuario, out string mensaje)
        {
            mensaje = string.Empty;
            if (usuario.Documento == "") { mensaje += "El documento no puede quedar vacío."; }
            if (usuario.NombreCompleto == "") { mensaje += "El nombre no puede quedar vacío."; }
            if (usuario.Contraseña == "") { mensaje += "La contraseña no puede quedar vacía."; }
            if (mensaje != string.Empty) { return false; }
            else { return datosUsuario.EditarUsuario(usuario, out mensaje); }
            
        }

        public bool Eliminar(Usuario usuario, out string mensaje)
        {
            return datosUsuario.EliminarUsuario(usuario, out mensaje);
        }
    }
}
