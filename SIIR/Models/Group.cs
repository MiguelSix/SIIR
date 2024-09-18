namespace SIIR.Models
{
    public class Group
    {
        public int IdGroup { get; set; }
        public string? Nombre { get; set; }
        public string? Tipo { get; set; }

        // Navigation properties (foreign keys)
        public ICollection<Team>? Teams { get; set; }

    }
}