using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace mvc_market
{
    public class ProductContext : DbContext
    {
        /*public ProductContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source = database.db");
        }*/
        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
