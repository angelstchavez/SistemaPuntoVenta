namespace Entidad.Registros
{
    public class Servicio
    {
        public int IdServicio { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string FechaRegistro { get; set; }
        public bool Estado { get; set; }

        public override string ToString()
        {
            return $"{IdServicio};{Nombre};{Precio};{FechaRegistro};{Estado}";
        }
    }
}
