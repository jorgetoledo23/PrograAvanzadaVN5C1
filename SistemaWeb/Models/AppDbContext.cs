using Microsoft.EntityFrameworkCore;

namespace SistemaWeb.Models
{
    public class AppDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Equipo>()
                .Property(prop => prop.FechaAdquisicion)
                .HasColumnType("date");

            modelBuilder.Entity<Equipo>()
                .Property(prop => prop.Garantia)
                .HasColumnType("date");
        }


        public DbSet<Persona> Personas { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Linea> Lineas { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Procesador> Procesadores { get; set; }
        public DbSet<Imagen> Imagenes { get; set; }
        public DbSet<Clase> Clases { get; set; }



    }
}
