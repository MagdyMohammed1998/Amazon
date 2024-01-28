﻿// <auto-generated />
using System;
using Amazon.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Amazon.Context.Migrations
{
    [DbContext(typeof(AmazonContext))]
    [Migration("20240128041020_m1")]
    partial class m1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Amazon.Models.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Amazon.Models.Models.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserID")
                        .IsUnique();

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("Amazon.Models.Models.CardItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CardID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CardID");

                    b.HasIndex("ProductID");

                    b.ToTable("CardItems");
                });

            modelBuilder.Entity("Amazon.Models.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AdminID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdminID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Amazon.Models.Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UsertID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UsertID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Amazon.Models.Models.OrderDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderID");

                    b.HasIndex("ProductID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Amazon.Models.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AdminID")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdminID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Amazon.Models.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Amazon.Models.Models.Card", b =>
                {
                    b.HasOne("Amazon.Models.Models.User", "User")
                        .WithOne("Card")
                        .HasForeignKey("Amazon.Models.Models.Card", "UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Amazon.Models.Models.CardItem", b =>
                {
                    b.HasOne("Amazon.Models.Models.Card", "card")
                        .WithMany("cardItems")
                        .HasForeignKey("CardID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Amazon.Models.Models.Product", "product")
                        .WithMany("CardItems")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("card");

                    b.Navigation("product");
                });

            modelBuilder.Entity("Amazon.Models.Models.Category", b =>
                {
                    b.HasOne("Amazon.Models.Models.Admin", "Admin")
                        .WithMany("categories")
                        .HasForeignKey("AdminID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("Amazon.Models.Models.Order", b =>
                {
                    b.HasOne("Amazon.Models.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UsertID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Amazon.Models.Models.OrderDetails", b =>
                {
                    b.HasOne("Amazon.Models.Models.Order", "Order")
                        .WithMany("Details")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Amazon.Models.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Amazon.Models.Models.Product", b =>
                {
                    b.HasOne("Amazon.Models.Models.Admin", "admin")
                        .WithMany("products")
                        .HasForeignKey("AdminID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Amazon.Models.Models.Category", "category")
                        .WithMany("products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("admin");

                    b.Navigation("category");
                });

            modelBuilder.Entity("Amazon.Models.Models.Admin", b =>
                {
                    b.Navigation("categories");

                    b.Navigation("products");
                });

            modelBuilder.Entity("Amazon.Models.Models.Card", b =>
                {
                    b.Navigation("cardItems");
                });

            modelBuilder.Entity("Amazon.Models.Models.Category", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("Amazon.Models.Models.Order", b =>
                {
                    b.Navigation("Details");
                });

            modelBuilder.Entity("Amazon.Models.Models.Product", b =>
                {
                    b.Navigation("CardItems");

                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("Amazon.Models.Models.User", b =>
                {
                    b.Navigation("Card")
                        .IsRequired();

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
