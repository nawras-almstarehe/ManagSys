using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagmentSystem.Core.Models;

namespace ManagmentSystem.EF
{
    public partial class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<CategoryProduct>().HasKey(cp => new { cp.CategoryId, cp.ProductId });
            modelBuilder.Entity<CategoryProduct>().HasOne(m => m.Category)
                        .WithMany(am => am.CategoryProducts).HasForeignKey(m => m.CategoryId);
            modelBuilder.Entity<CategoryProduct>().HasOne(a => a.Product)
                        .WithMany(at => at.CategoryProducts).HasForeignKey(a => a.ProductId);

            modelBuilder.Entity<Product>()
                        .HasOne(e => e.User)
                        .WithMany(c => c.Products);

            modelBuilder.Entity<Transaction>()
                        .HasOne(e => e.User)
                        .WithMany(c => c.Transactions);

            modelBuilder.Entity<Transaction>()
                        .HasOne(e => e.Product)
                        .WithMany(c => c.Transactions);

            //////////////////////////
            modelBuilder.Entity<Category>()
                        .Property(p => p.LastAccessed)
                        .ValueGeneratedOnAddOrUpdate();
            
            modelBuilder.Entity<Product>()
                        .Property(p => p.LastAccessed)
                        .ValueGeneratedOnAddOrUpdate();

            modelBuilder.Entity<CategoryProduct>()
                        .Property(p => p.LastAccessed)
                        .ValueGeneratedOnAddOrUpdate();

            modelBuilder.Entity<Transaction>()
                        .Property(p => p.LastAccessed)
                        .ValueGeneratedOnAddOrUpdate();

            modelBuilder.Entity<User>()
                        .Property(p => p.LastAccessed)
                        .ValueGeneratedOnAddOrUpdate();
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryProduct> CategoryProductes { get; set; }
        public DbSet<Product> Productes { get; set; }
        public DbSet<Transaction> Transactiones { get; set; }
        public DbSet<User> Users { get; set; }
    
    }
}
