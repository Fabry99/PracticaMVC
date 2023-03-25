using Microsoft.EntityFrameworkCore;

namespace PracticaMVC.Models
{
    public class equiposDbContext : DbContext
    {
        public equiposDbContext(DbContextOptions options) : base (options) { 
        
            
        }

        public DbSet<marcas> marcas { get; set; }

        public DbSet<estados_equipo>estados_equipo { get; set; }

        public DbSet<estados_reservas>estados_reserva {get; set; }

        public DbSet<facultades> facultades { get; set;}

        public DbSet<tipo_equipo> tipo_equipo { get;set; }


    }
}
