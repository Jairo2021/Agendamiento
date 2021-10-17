using Microsoft.EntityFrameworkCore;
using AgendaSIG5.App.Dominio;

namespace AgendaSIG5.App.Persistencia
{
   public class AppContext : DbContext
   {
        public DbSet<Persona> Personas {get;set;}
        public DbSet<Agenda> AgendaCitas {get;set;} 
        public DbSet<Sede> Sedes {get;set;}
        public DbSet<Ciudad> Ciudades {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=tcp:agendamientosig5.database.windows.net,1433; Database=AgendaSIG5Data; User ID=AgendaSIG5; Password=Agendamiento5; Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

  
                //optionsBuilder .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = AgendaSIG5Data");
            }
        }    
    }
}