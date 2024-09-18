namespace SIIR.Models
{
    public class Uniform
    {
        public int IdUniform { get; set; }
        public string? Nombre { get; set; }
        public string? Talla { get; set; }

        // Navigation properties (foreign keys)
        public ICollection<Team>? Teams { get; set; }
    }
}