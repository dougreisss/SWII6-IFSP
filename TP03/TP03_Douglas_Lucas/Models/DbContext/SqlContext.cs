using Microsoft.EntityFrameworkCore;

namespace TP03_Douglas_Lucas.Models.SqlContext
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {

        }
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData
            (

                new Product
                {
                    Id = 1,
                    Name = "Smartphone",
                    CategoryName = "Electronics",
                    Description = "Smartphone with high-quality display and camera",
                    Price = 2000,
                    Unit = 1
                },
                new Product
                {
                    Id = 2,
                    Name = "Smartphone",
                    CategoryName = "Electronics",
                    Description = "Smartphone with long-lasting battery",
                    Price = 2000,
                    Unit = 1
                },
                new Product
                {
                    Id = 3,
                    Name = "Laptop",
                    CategoryName = "Electronics",
                    Description = "Lightweight laptop with 16GB RAM and 512GB SSD",
                    Price = 1500,
                    Unit = 1
                },
                new Product
                {
                    Id = 4,
                    Name = "Headphones",
                    CategoryName = "Accessories",
                    Description = "Noise-cancelling wireless headphones",
                    Price = 300,
                    Unit = 1
                },
                new Product
                {
                    Id = 5,
                    Name = "Smartwatch",
                    CategoryName = "Wearable",
                    Description = "Water-resistant smartwatch with fitness tracking",
                    Price = 250,
                    Unit = 1
                }

            );
        }

        public DbSet<Product> Product { get; set; }
    }
}
