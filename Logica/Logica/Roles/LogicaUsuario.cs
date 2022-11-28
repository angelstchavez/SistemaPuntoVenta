using Datos.Datos.Roles;
using Entidad.Roles;
using System.Collections.Generic;

namespace Logica.Logica.Roles
{
    /// <summary>
    /// 
    /// </summary>
    public class LogicaUsuario
    {
        /// <summary>
        /// The datos usuario
        /// </summary>
        private DatosUsuario datosUsuario = new DatosUsuario();

        /// <summary>
        /// Listars this instance.
        /// </summary>
        /// <returns></returns>
        public List<Usuario> Listar()
        {
            return datosUsuario.ListarUsuarios();
        }

        /// <summary>
        /// Validars this instance.
        /// </summary>
        /// <returns></returns>
        public List<Usuario> Validar()
        {
            return datosUsuario.ValidarUsuarios();
        }

        /// <summary>
        /// Registrars the specified usuario.
        /// </summary>
        /// <param name="usuario">The usuario.</param>
        /// <param name="mensaje">The mensaje.</param>
        /// <returns></returns>
        public int Registrar(Usuario usuario, out string mensaje)
        {
            mensaje = string.Empty;
            if (usuario.Documento == "") { mensaje += "El documento no puede quedar vacío."; }
            if (usuario.NombreCompleto == "") { mensaje += "El nombre no puede quedar vacío."; }
            if (usuario.Contraseña == "") { mensaje += "La contraseña no puede quedar vacía."; }
            if (mensaje != string.Empty) { return 0; }
            else { return datosUsuario.RegistrarUsuario(usuario, out mensaje); }
        }

        /// <summary>
        /// Editars the specified usuario.
        /// </summary>
        /// <param name="usuario">The usuario.</param>
        /// <param name="mensaje">The mensaje.</param>
        /// <returns></returns>
        public bool Editar(Usuario usuario, out string mensaje)
        {
            mensaje = string.Empty;
            if (usuario.Documento == "") { mensaje += "El documento no puede quedar vacío."; }
            if (usuario.NombreCompleto == "") { mensaje += "El nombre no puede quedar vacío."; }
            if (usuario.Contraseña == "") { mensaje += "La contraseña no puede quedar vacía."; }
            if (mensaje != string.Empty) { return false; }
            else { return datosUsuario.EditarUsuario(usuario, out mensaje); }
            
        }

        /// <summary>
        /// Eliminars the specified usuario.
        /// </summary>
        /// <param name="usuario">The usuario.</param>
        /// <param name="mensaje">The mensaje.</param>
        /// <returns></returns>
        public bool Eliminar(Usuario usuario, out string mensaje)
        {
            return datosUsuario.EliminarUsuario(usuario, out mensaje);
        }
    }
}
