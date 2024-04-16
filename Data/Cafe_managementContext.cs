using Microsoft.EntityFrameworkCore;
using Cafe_management.Configurations;
using Cafe_management.Models;

namespace Cafe_management.Data
{
    public class Cafe_managementContext : DbContext
    {
        public Cafe_managementContext()
        {
        }

        public Cafe_managementContext(DbContextOptions<Cafe_managementContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        //public DbSet<CartProductMap> CartProductMaps { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfiguration(new CategoriesConfiguration());
            modelBuilder.ApplyConfiguration(new CartsConfiguration());
            modelBuilder.ApplyConfiguration(new ProductsConfiguration());
            modelBuilder.ApplyConfiguration(new CartsConfiguration());
            //modelBuilder.ApplyConfiguration(new CartProductMapConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=(localdb)\\MSSQLLocalDB;initial catalog=Cafe_management;integrated security=True;");
            base.OnConfiguring(optionsBuilder);
        }*/
    }
}
