using Microsoft.EntityFrameworkCore;
using tareaPweb.models;

namespace tareaPweb.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<VideoJuegos> Videojuegos { get; set; }
        public DbSet<Plataforma> Plataformas { get; set; }
        public DbSet<Personaje> Personajes { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VideoJuegos>().HasKey(v => v.VideoJuegoId);
            modelBuilder.Entity<Plataforma>().HasKey(p => p.PlataformaId);
            modelBuilder.Entity<VideoJuegos>().HasOne(v => v.Plataforma).WithMany().HasForeignKey(v => v.PlataformaId);
            modelBuilder.Entity<Personaje>().HasKey(p => p.PersonajeId);
        }
    }
}