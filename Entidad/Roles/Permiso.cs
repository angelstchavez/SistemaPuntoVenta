namespace Entidad.Roles
{
    public class Permiso
    {
        public int IdPermiso { get; set; }
        public Rol objRol { get; set; }
        public string NombreMenu { get; set; }
        public string FechaRegistro { get; set; }
    }
}
