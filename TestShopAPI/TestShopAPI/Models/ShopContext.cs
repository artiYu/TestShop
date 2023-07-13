using Microsoft.EntityFrameworkCore;

namespace TestShopAPI.Models
{
    public class ShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Stock> Stocks { get; set; }

        public ShopContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shop>()
                .HasMany(c => c.Orders)
                .WithOne(e => e.Shop);

            modelBuilder.Entity<ShopStock>()
                .HasKey(key => new { key.ShopId, key.StockId });

            modelBuilder.Entity<ShopStock>()
                .HasOne(s => s.Shop)
                .WithMany(s => s.ShopStocks);

            modelBuilder.Entity<ShopStock>()
                .HasOne(s => s.Stock)
                .WithMany(s => s.ShopStocks);

            modelBuilder.Entity<StockProduct>()
                .HasKey(key => new { key.StockId, key.ProductId });

            modelBuilder.Entity<StockProduct>()
                .HasOne(s => s.Product)
                .WithMany(s => s.StockProducts);

            modelBuilder.Entity<StockProduct>()
                .HasOne(s => s.Stock)
                .WithMany(s => s.StockProducts);

            modelBuilder.Entity<Client>()
                .HasMany(s => s.Orders)
                .WithOne(s => s.Client);

            modelBuilder.Entity<OrderProducts>()
                .HasKey(key => new { key.OrderId, key.ProductId });

            modelBuilder.Entity<OrderProducts>()
                .HasOne(s => s.Order)
                .WithMany(s => s.OrderProducts);

            modelBuilder.Entity<OrderProducts>()
                .HasOne(s => s.Product)
                .WithMany(s => s.OrderProducts);
        }
    }
}
