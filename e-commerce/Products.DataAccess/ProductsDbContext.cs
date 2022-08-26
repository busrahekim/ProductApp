using Microsoft.EntityFrameworkCore;
using Products.Entities;
using System;

namespace Products.DataAccess
{
    public class ProductsDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.; Database=ProductsDb; Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }
    }
}
