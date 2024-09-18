using Microsoft.EntityFrameworkCore;
using SIIR.Models;

namespace SIIR.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Team> Equipos { get; set; }
        public DbSet<Student> Estudiantes { get; set; }
        public DbSet<Uniform> Uniformes { get; set; }
        public DbSet<Group> Representativos { get; set; }
        public DbSet<Document> Documentos { get; set; }
        public DbSet<Administrator> Administradores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Coach>()
                .HasOne(c => c.Equipo)
                .WithMany(e => e.Coaches)
                .HasForeignKey(c => c.IdTeam);

            modelBuilder.Entity<Team>()
                .HasOne(e => e.Uniforme)
                .WithMany(u => u.Teams)
                .HasForeignKey(e => e.IdUniform);

            modelBuilder.Entity<Team>()
                .HasOne(e => e.Representativo)
                .WithMany(r => r.Teams)
                .HasForeignKey(e => e.IdGroup);

            modelBuilder.Entity<Student>()
                .HasOne(e => e.Coach)
                .WithMany(c => c.Students)
                .HasForeignKey(e => e.IdCoach);

            modelBuilder.Entity<Student>()
                .HasOne(e => e.Equipo)
                .WithMany(eq => eq.Students)
                .HasForeignKey(e => e.IdTeam);

            modelBuilder.Entity<Document>()
                .HasOne(d => d.Student)
                .WithMany(e => e.Documentos)
                .HasForeignKey(d => d.IdStudent);
        }
    }
}
