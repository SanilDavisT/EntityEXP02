﻿using Microsoft.EntityFrameworkCore;

namespace EntityEXP02.Models
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Shop> Shops { get; set; }
    }
}
