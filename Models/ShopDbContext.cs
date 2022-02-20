using Microsoft.EntityFrameworkCore;

namespace EntityEXP02.Models
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options)
        {
        }

        public DbSet<Shop> Shops { get; set; } // Its create table in ssmdb named "Shops"

        public DbSet<Shop2> Shops2 { get; set; }
    }
}
