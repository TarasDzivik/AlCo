using AlCollection.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AlCollection.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options) { }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Country> Counties { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<DrinkType> DrinkTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserCollection> UserCollections { get; set; }
        public DbSet<UserDrink> UserDrinks { get; set; }
        public DbSet<UserFeedback> UserFeedbacks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            {
                modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            }
        }
    }
}
