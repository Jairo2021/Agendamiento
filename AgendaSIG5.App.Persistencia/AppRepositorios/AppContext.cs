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
               optionsBuilder.UseSqlServer("Server=tcp:agendasig5app.database.windows.net,1433;Database=AgendaSIG5Data;User ID=agendasig5;Password=Juand2021*;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
               //optionsBuilder.UseSqlServer("Server=tcp:agendasig5app.database.windows.net,1433; Initial Catalog=AgendaSIG5Data; Integrated Security=true;");
               //OPCION ANTES DE DESPLIEGUE=optionsBuilder.UseSqlServer("Initial Catalog=AgendaSIG5Data; Data Source=(localdb)\\MSSQLLocalDB; Integrated Security=true");
               //OPCION1=optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = AgendaSIG5Data");
            }
        }    
    }
}