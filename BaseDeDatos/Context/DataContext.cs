using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace BaseDeDatos
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
        }

        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<Persona> Personas { get; set; }
    }
}