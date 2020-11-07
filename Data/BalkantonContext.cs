using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class BalkantonContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Rating> Ratings { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Comments> Comments { get; set; }

        public DbSet<Store> Stores { get; set; }

        public DbSet<ProductStoreQuantity> ProductsStoreQuantities { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<OrderStatus> OrderStatuses { get; set; }

        public DbSet<Address> Addresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=BalkantonDb;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductStoreQuantity>()
                .HasKey(psq => new { psq.ProductId, psq.StoreId });

            modelBuilder.Entity<DigitalProducts>();
            modelBuilder.Entity<PhysicalProduct>();
        }
    }
}
