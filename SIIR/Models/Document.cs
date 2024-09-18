namespace SIIR.Models
{
    public class Document
    {
        public int IdDocument { get; set; }
        public int IdStudent { get; set; }
        public string? Ruta { get; set; }
        public string? FechaDeSubida { get; set; }

        // Navigation properties (foreign keys)
        public Student? Student { get; set; }
    }
}