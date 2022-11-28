using Datos.Datos.Roles;
using Entidad.Roles;
using System.Collections.Generic;

namespace Logica.Logica.Roles
{
    /// <summary>
    /// Es una clase que contiene métodos que le permiten agregar, editar, eliminar y listar usuarios.
    /// </summary>
    public class LogicaUsuario
    {
        /// <summary>
        /// Los datos del usuario
        /// </summary>
        private DatosUsuario datosUsuario = new DatosUsuario();

        /// <summary>
        /// Enumera esta instancia.
        /// </summary>
        /// <returns>La lista de usuarios.</returns>
        public List<Usuario> Listar()
        {
            return datosUsuario.ListarUsuarios();
        }

        /// <summary>
        /// Valida esta instancia.
        /// </summary>
        /// <returns>La lista de usuarios registrados.</returns>
        public List<Usuario> Validar()
        {
            return datosUsuario.ValidarUsuarios();
        }

        /// <summary>
        /// Registra el usuario especificado.
        /// </summary>
        /// <param name="usuario">Un usuario.</param>
        /// <param name="mensaje">Un mensaje.</param>
        /// <returns><c>true</c> si el registro es exitoso; de lo contrario, <c>false</c>.</returns>
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
        /// <returns><c>true</c> si la edición es exitosa; de lo contrario, <c>false</c>.</returns>
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
        /// <returns><c>true</c> si la eliminación es exitosa; de lo contrario, <c>false</c>.</returns>
        public bool Eliminar(Usuario usuario, out string mensaje)
        {
            return datosUsuario.EliminarUsuario(usuario, out mensaje);
        }
    }
}
