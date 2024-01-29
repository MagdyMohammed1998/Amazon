using Amazon.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Context
{
    public class AmazonContext : DbContext
    {
       public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Admin> Admins { get; set; }

        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<Card> Cards { get; set; }

        public virtual DbSet<CardItem> CardItems { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<OrderDetails> OrderDetails { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=OMNIA-EZZ\\SQLEXPRESS;Initial Catalog=AmazonDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                 .HasOne(p => p.Category)
                 .WithMany(c => c.products)
                 .HasForeignKey(p => p.CategoryID)
                 .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Admin)
                .WithMany(a => a.products)
                .HasForeignKey(p => p.AdminID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OrderDetails>()
                .HasOne(od => od.Order)
                .WithMany(o => o.Details)
                .HasForeignKey(od => od.OrderID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<OrderDetails>()
                .HasOne(od => od.Product)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(od => od.ProductID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UsertID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CardItem>()
                .HasOne(ci => ci.card)
                .WithMany(c => c.cardItems)
                .HasForeignKey(ci => ci.CardID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CardItem>()
                .HasOne(ci => ci.product)
                .WithMany(p => p.CardItems)
                .HasForeignKey(ci => ci.ProductID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Card>()
                .HasOne(c => c.User)
                .WithOne(u => u.Card)
                .HasForeignKey <Card>(u => u.UserID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Category>()
                .HasOne(c => c.Admin)
                .WithMany(a => a.categories)
                .HasForeignKey(c => c.AdminID)
                .OnDelete(DeleteBehavior.Restrict);



















            base.OnModelCreating(modelBuilder);
        }




    }
}
