﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Products.DataAccess;

namespace Products.DataAccess.Migrations
{
    [DbContext(typeof(ProductsDbContext))]
    partial class ProductsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Products.Entities.Product", b =>
                {
                    b.Property<int>("productId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("productCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("productCreatedAt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("productName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("productPrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("productQuantity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("productTag")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("productId");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
