namespace Entidad.Roles
{
    public class Cliente : Persona
    {
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public override string ToString()
        {
            return $"{Id};{Nombres};{Apellidos};{NumeroDocumento};" +
                $"{Correo};{Telefono};{FechaRegistro};{Estado}";
        }
    }
}
