using Microsoft.EntityFrameworkCore;

namespace CoffeeShopLab.Models
{
    public class CoffeeShopLabDbContext : DbContext
    {
        public CoffeeShopLabDbContext(DbContextOptions<CoffeeShopLabDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
