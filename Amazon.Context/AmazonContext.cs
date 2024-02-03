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

        public virtual DbSet<Cart> Cards { get; set; }

        public virtual DbSet<CartDetails> CartDetails { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<OrderDetails> OrderDetails { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=MICHAEL-PC\\SQLEXPRESS;Initial Catalog=AmazonSohage;Integrated Security=True;Trust Server Certificate=True;encrypt=false");

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                 .HasOne(p => p.category)
                 .WithMany(c => c.products)
                 .HasForeignKey(p => p.CategoryID)
                 .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.admin)
                .WithMany(a => a.products)
                .HasForeignKey(p => p.AdminID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OrderDetails>()
                .HasOne(od => od.Order)
                .WithMany(o => o.OrderDetail)
                .HasForeignKey(od => od.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<OrderDetails>()
                .HasOne(od => od.Product)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(od => od.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CartDetails>()
                .HasOne(ci => ci.Cart)
                .WithMany(c => c.CartDetail)
                .HasForeignKey(ci => ci.CartId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CartDetails>()
                .HasOne(ci => ci.Product)
                .WithMany(p => p.CardItems)
                .HasForeignKey(ci => ci.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Cart>()
                .HasOne(c => c.User)
                .WithOne(u => u.Card)
                .HasForeignKey <Cart>(u => u.UserId)
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
