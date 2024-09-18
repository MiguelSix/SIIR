namespace SIIR.Models
{
    public class Team
    {
        public int IdTeam { get; set; }
        public int IdUniform { get; set; }
        public int IdGroup { get; set; }
        public string? NombreEquipo { get; set; }
        public string? Categoria { get; set; }

        // Navigation properties (foreign keys)
        public Uniform? Uniforme { get; set; }
        public Group? Representativo { get; set; }
        public ICollection<Student>? Students { get; set; }
        public ICollection<Coach>? Coaches { get; set; }
    }
}