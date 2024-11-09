﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TP03_Douglas_Lucas.Models.SqlContext;

#nullable disable

namespace TP03_Douglas_Lucas.Migrations
{
    [DbContext(typeof(SqlContext))]
    [Migration("20241109154047_RenameColumn")]
    partial class RenameColumn
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TP03_Douglas_Lucas.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("CategoryName");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Description");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Price");

                    b.Property<int>("Unit")
                        .HasColumnType("int")
                        .HasColumnName("Unit");

                    b.HasKey("Id");

                    b.ToTable("Produto");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Electronics",
                            Description = "Smartphone with high-quality display and camera",
                            Name = "Smartphone",
                            Price = 2000m,
                            Unit = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Electronics",
                            Description = "Smartphone with long-lasting battery",
                            Name = "Smartphone",
                            Price = 2000m,
                            Unit = 1
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Electronics",
                            Description = "Lightweight laptop with 16GB RAM and 512GB SSD",
                            Name = "Laptop",
                            Price = 1500m,
                            Unit = 1
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Accessories",
                            Description = "Noise-cancelling wireless headphones",
                            Name = "Headphones",
                            Price = 300m,
                            Unit = 1
                        },
                        new
                        {
                            Id = 5,
                            CategoryName = "Wearable",
                            Description = "Water-resistant smartwatch with fitness tracking",
                            Name = "Smartwatch",
                            Price = 250m,
                            Unit = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
