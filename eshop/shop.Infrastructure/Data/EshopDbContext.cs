using eshop.Domains.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Infrastructure.Data
{
    public class EshopDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public EshopDbContext(DbContextOptions<EshopDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().Property(c => c.Name).IsRequired()
                                                                 .HasMaxLength(60);

            modelBuilder.Entity<Product>().HasOne(p => p.Category)
                                          .WithMany(c => c.Products)
                                          .HasForeignKey(p => p.CategoryId)
                                          .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "Bilgisayar" },
                new Category() { Id = 2, Name = "Kozmetik" },
                new Category() { Id = 3, Name = "Kırtasiye" }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = 1, Name = "Excalibur", Price = 25000, CategoryId = 1, Description = "Oyun..", ImageUrl = "https://productimages.hepsiburada.net/s/379/222-222/110000397669010.jpg" },
                new Product() { Id = 2, Name = "Rimel ve Eyeliner set", Price = 250, CategoryId = 2, Description = "Aksesuar", ImageUrl = "https://productimages.hepsiburada.net/s/379/222-222/110000397669010.jpg" },
                new Product() { Id = 3, Name = "A5 Defter", Price = 75, CategoryId = 3, Description = "Not defteri", ImageUrl = "https://productimages.hepsiburada.net/s/379/222-222/110000397669010.jpg" }
                );

        }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //optionsBuilder.UseSqlServer("Data Source=(localdb)\\Mssqllocaldb;Initial Catalog=BinovistEshop;Integrated Security=True");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
