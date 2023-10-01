using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Repositories.Context
{
    public class KaloriTakipDbContext : DbContext
    {

        public DbSet<Food> Foods { get; set; }
        public DbSet<FoodCategory> FoodCategories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Aim> Aims { get; set; }
        public DbSet<UserData> UserDatas { get; set; }
        public DbSet<UserMeal> UserMeals { get; set; }
        public DbSet<UserVerification> UserVerifications { get; set; }
        public DbSet<FoodAmount> FoodAmounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-O5VMPQK\\SQLEXPRESS;Initial Catalog=KaloriSeedDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}