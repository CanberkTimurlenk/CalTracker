using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Repository
{
    public class KaloriTakipDbContext : DbContext
    {
        protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=127.0.0.1,11433;Database=KaloriTakipDb;User ID=SA;Password=Ab12345678;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
