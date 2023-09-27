using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Repository.Context
{
    public class KaloriTakipDbContext : DbContext
    {

        public DbSet<Food> Foods { get; set; }
        public DbSet<FoodCategory> FoodCategories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Aim> Aims { get; set; }
        public DbSet<UserData> UserDatas { get; set; }
        public DbSet<UserMeals> UserMeals { get; set; }
        public DbSet<UserVerification> UserVerifications { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=127.0.0.1,11433;Database=KaloriTakipDb;User ID=SA;Password=Ab12345678;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}