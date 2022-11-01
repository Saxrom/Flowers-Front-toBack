using System;
using Front_toBack_3.Models;
using Microsoft.EntityFrameworkCore;

namespace Front_toBack_3.DAL
{
    public class AppDbContext : DbContext
    {
        internal Task logos;

        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Slider> Sliders { get; set; }

        public DbSet<SliderImage> SliderImages { get; set; }

        public DbSet<Logo> Logos { get; set; }
    }
}

