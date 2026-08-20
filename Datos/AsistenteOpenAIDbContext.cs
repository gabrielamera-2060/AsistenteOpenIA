using AsistenteOpenAI.Models;
using Microsoft.EntityFrameworkCore;

namespace AsistenteOpenAI.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<PreguntaIA> PreguntasIA { get; set; }
        public DbSet<RespuestaIA> RespuestasIA { get; set; }

        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=WILLIAM-PC\\SQLEXPRESS;Database=AsistenteOpenAI;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PreguntaIA>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<RespuestaIA>()
                .HasKey(r => r.Id);
        }
    }
}