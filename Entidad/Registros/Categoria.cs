namespace Entidad.Registros
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public string FechaRegistro { get; set; }
        public bool Estado { get; set; }

        public override string ToString()
        {
            return $"{IdCategoria};{Nombre};{FechaRegistro};{Estado}";
        }
    }
}
