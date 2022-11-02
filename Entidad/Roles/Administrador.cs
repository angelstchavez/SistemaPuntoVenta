namespace Entidad.Roles
{
    public class Administrador : Persona
    {
        public string NomUsuario { get; set; }
        private string Contraseña { get; set; }

        public override string ToString()
        {
            return $"{Id};{Nombres};{Apellidos};{NumeroDocumento};" +
                $"{NomUsuario};{Contraseña};{Estado};{FechaRegistro}";
        }
    }
}
