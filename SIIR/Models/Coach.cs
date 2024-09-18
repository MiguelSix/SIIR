namespace SIIR.Models
{
    public class Coach
    {
        public int IdCoach { get; set; }
        public int IdTeam { get; set; }
        public string? Nombre { get; set; }
        public string? ApellidoPaterno { get; set; }
        public string? ApellidoMaterno { get; set; }
        public string? Password { get; set; }

        // Navigation properties (foreign keys)
        public Team? Equipo { get; set; }
        public ICollection<Student>? Students { get; set; }
    }
}