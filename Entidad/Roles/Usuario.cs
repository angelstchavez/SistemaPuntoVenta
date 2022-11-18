namespace Entidad.Roles
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Documento { get; set; }
        public string NombreCompleto { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public Rol ObJRol { get; set; }
        public bool Estado { get; set; }
        public string FechaRegistro { get; set; }

        public override string ToString()
        {
            return $"{Documento}"; 
        }
    }
}
