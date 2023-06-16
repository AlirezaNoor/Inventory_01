﻿// <auto-generated />
using System;
using Invetory01.Infrastructure.Db_Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Invetory01.Infrastructure.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20230616165620_la55s")]
    partial class la55s
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Inventory.Domin.Brand.BrandAgg", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<string>("desicription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands", (string)null);
                });

            modelBuilder.Entity("Inventory.Domin.CategoryAgg.Categores", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("CategoryCode")
                        .HasColumnType("bigint");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Descirption")
                        .IsRequired()
                        .HasMaxLength(999)
                        .HasColumnType("nvarchar(999)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categores", (string)null);
                });

            modelBuilder.Entity("Inventory.Domin.Product.ProductsAgg", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("Discuont")
                        .HasColumnType("bigint");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Qty")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Sku")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Tax")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<long>("brand")
                        .HasColumnType("bigint");

                    b.Property<long>("categoriesref")
                        .HasColumnType("bigint");

                    b.Property<decimal>("minmuimQty")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("statuse")
                        .HasColumnType("bigint");

                    b.Property<long>("unitref")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("brand");

                    b.HasIndex("categoriesref");

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("Inventory.Domin.SubCategory.SubCategories", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("CategoryRef")
                        .HasColumnType("bigint");

                    b.Property<long>("CubCategorycode")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryRef");

                    b.ToTable("SubCategories", (string)null);
                });

            modelBuilder.Entity("Inventory.Domin.Product.ProductsAgg", b =>
                {
                    b.HasOne("Inventory.Domin.Brand.BrandAgg", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("brand")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inventory.Domin.CategoryAgg.Categores", "Category")
                        .WithMany("Products")
                        .HasForeignKey("categoriesref")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Inventory.Domin.SubCategory.SubCategories", b =>
                {
                    b.HasOne("Inventory.Domin.CategoryAgg.Categores", "Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryRef")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Inventory.Domin.Brand.BrandAgg", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Inventory.Domin.CategoryAgg.Categores", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("SubCategories");
                });
#pragma warning restore 612, 618
        }
    }
}