namespace Entidad.Roles
{
    public class Usuario : Persona
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
