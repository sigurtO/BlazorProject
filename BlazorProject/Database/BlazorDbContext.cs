using Microsoft.EntityFrameworkCore;
using BlazorProject.Tables; // Ensure this namespace matches your project structure

namespace BlazorProject.Database
{
    public class BlazorDbContext : DbContext
    {
        public DbSet<Employe> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer("Data Source = SQL6032.site4now.net; Initial Catalog = db_ab8928_vet; User Id = db_ab8928_vet_admin; Password = Admin1234");
                }
        }

    }
}
