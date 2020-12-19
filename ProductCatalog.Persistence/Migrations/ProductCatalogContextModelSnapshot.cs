﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductCatalog.Persistence;

namespace ProductCatalog.Persistence.Migrations
{
    [DbContext(typeof(ProductCatalogContext))]
    partial class ProductCatalogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProductCatalog.Domain.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LastUpdated = new DateTime(2020, 12, 17, 17, 21, 4, 922, DateTimeKind.Local).AddTicks(9337),
                            Name = "Product 1",
                            Photo = "",
                            Price = 10.0
                        },
                        new
                        {
                            Id = 2,
                            LastUpdated = new DateTime(2020, 12, 16, 17, 21, 4, 923, DateTimeKind.Local).AddTicks(6685),
                            Name = "Product 2",
                            Photo = "",
                            Price = 20.0
                        },
                        new
                        {
                            Id = 3,
                            LastUpdated = new DateTime(2020, 12, 15, 17, 21, 4, 923, DateTimeKind.Local).AddTicks(6757),
                            Name = "Product 3",
                            Photo = "",
                            Price = 30.0
                        },
                        new
                        {
                            Id = 4,
                            LastUpdated = new DateTime(2020, 12, 15, 17, 21, 4, 923, DateTimeKind.Local).AddTicks(6761),
                            Name = "Product 4",
                            Photo = "",
                            Price = 40.0
                        },
                        new
                        {
                            Id = 5,
                            LastUpdated = new DateTime(2020, 12, 14, 17, 21, 4, 923, DateTimeKind.Local).AddTicks(6762),
                            Name = "Product 5",
                            Photo = "",
                            Price = 50.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
