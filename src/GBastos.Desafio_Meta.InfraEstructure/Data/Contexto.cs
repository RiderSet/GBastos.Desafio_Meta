using GBastos.Desafio_Meta.ApplicationCore;
using Microsoft.EntityFrameworkCore;

namespace GBastos.Desafio_Meta.InfraEstructure.Data
{
    public class Contexto: DbContext
    {
        public Contexto()
        {
        }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Emissora> Emissoras { get; set; }
        public DbSet<Audiencia> Audiencias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Emissora>().ToTable("Emissora");
            modelBuilder.Entity<Audiencia>().ToTable("Audiencia");

            modelBuilder.Entity<Emissora>().ToTable("Emissora");
            modelBuilder.Entity<Emissora>().ToTable("Audiencia");
        }
    }
}
