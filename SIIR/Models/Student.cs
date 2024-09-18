namespace SIIR.Models
{
    public class Student
    {
        public int IdStudent { get; set; }
        public int IdCoach { get; set; }
        public int IdTeam { get; set; }
        public string? IdCapitan { get; set; }
        public string? Password { get; set; }
        public string? Nombre { get; set; }
        public string? ApellidoPaterno { get; set; }
        public string? ApellidoMaterno { get; set; }
        public string? NoControl { get; set; }
        public string? FechaNacimiento { get; set; }
        public string? Carrera { get; set; }
        public string? Semestre { get; set; }
        public string? NoCelular { get; set; }
        public string? Correo { get; set; }
        public string? TipoSangre { get; set; }
        public decimal Peso { get; set; }
        public decimal Estatura { get; set; }
        public string? NSS { get; set; }

        // Navigation properties (foreign keys)
        public Coach? Coach { get; set; }
        public Team? Equipo { get; set; }
        public ICollection<Document>? Documentos { get; set; }
    }
}
