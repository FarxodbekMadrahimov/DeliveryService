﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Request.Infrastructure.Persistance;

#nullable disable

namespace Request.Infrastructure.Migrations
{
    [DbContext(typeof(DeliveryDbContext))]
    partial class DeliveryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Request.Domain.Entitites.Products.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Price = 100L,
                            ProductName = "Product1"
                        },
                        new
                        {
                            ProductId = 2,
                            Price = 150L,
                            ProductName = "Product2"
                        },
                        new
                        {
                            ProductId = 3,
                            Price = 120L,
                            ProductName = "Product3"
                        },
                        new
                        {
                            ProductId = 4,
                            Price = 80L,
                            ProductName = "Product4"
                        },
                        new
                        {
                            ProductId = 5,
                            Price = 190L,
                            ProductName = "Product5"
                        },
                        new
                        {
                            ProductId = 6,
                            Price = 60L,
                            ProductName = "Product6"
                        },
                        new
                        {
                            ProductId = 7,
                            Price = 130L,
                            ProductName = "Product7"
                        },
                        new
                        {
                            ProductId = 8,
                            Price = 170L,
                            ProductName = "Product8"
                        },
                        new
                        {
                            ProductId = 9,
                            Price = 90L,
                            ProductName = "Product9"
                        },
                        new
                        {
                            ProductId = 10,
                            Price = 110L,
                            ProductName = "Product10"
                        },
                        new
                        {
                            ProductId = 11,
                            Price = 200L,
                            ProductName = "Product11"
                        },
                        new
                        {
                            ProductId = 12,
                            Price = 75L,
                            ProductName = "Product12"
                        },
                        new
                        {
                            ProductId = 13,
                            Price = 140L,
                            ProductName = "Product13"
                        },
                        new
                        {
                            ProductId = 14,
                            Price = 160L,
                            ProductName = "Product14"
                        });
                });

            modelBuilder.Entity("Request.Domain.Entitites.Request.Requesting", b =>
                {
                    b.Property<int>("RequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RequestId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RequestId");

                    b.ToTable("requests");
                });

            modelBuilder.Entity("Request.Domain.Entitites.Users.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("ProductId");

                    b.ToTable("user");
                });

            modelBuilder.Entity("Request.Domain.Entitites.deliver.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("order");
                });

            modelBuilder.Entity("Request.Domain.Entitites.Products.Product", b =>
                {
                    b.HasOne("Request.Domain.Entitites.Users.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Request.Domain.Entitites.Users.User", b =>
                {
                    b.HasOne("Request.Domain.Entitites.Products.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Request.Domain.Entitites.deliver.Order", b =>
                {
                    b.HasOne("Request.Domain.Entitites.Products.Product", "Product")
                        .WithMany("Orders")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Request.Domain.Entitites.Users.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Request.Domain.Entitites.Products.Product", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Request.Domain.Entitites.Users.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
