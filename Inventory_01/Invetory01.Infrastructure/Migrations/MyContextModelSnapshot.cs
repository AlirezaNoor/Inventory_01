﻿// <auto-generated />
using System;
using Invetory01.Infrastructure.Db_Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Invetory01.Infrastructure.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Inventory.Domin.AddProductsToStore.AddProductTostore", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<long>("productRef")
                        .HasColumnType("bigint");

                    b.Property<long>("storeRef")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("productRef");

                    b.HasIndex("storeRef");

                    b.ToTable("AddProductsToStore", (string)null);
                });

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

            modelBuilder.Entity("Inventory.Domin.Cardex.Cardexes", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("Quantity")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<long>("productsId")
                        .HasColumnType("bigint");

                    b.Property<long>("propductsref")
                        .HasColumnType("bigint");

                    b.Property<long>("storeId")
                        .HasColumnType("bigint");

                    b.Property<long>("storeref")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("transactiondate")
                        .HasColumnType("datetime2");

                    b.Property<long>("vorodkhoroj")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("productsId");

                    b.HasIndex("storeId");

                    b.ToTable("cardex");
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

            modelBuilder.Entity("Inventory.Domin.Cities.City", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("Countryref")
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

                    b.HasIndex("Countryref");

                    b.ToTable("City", (string)null);
                });

            modelBuilder.Entity("Inventory.Domin.Costumer.Costmers", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Cityref")
                        .HasColumnType("bigint");

                    b.Property<long>("Countryref")
                        .HasColumnType("bigint");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desciption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Countryref");

                    b.ToTable("Costumer", (string)null);
                });

            modelBuilder.Entity("Inventory.Domin.Country.Countreis", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegionRegion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Counnty", (string)null);
                });

            modelBuilder.Entity("Inventory.Domin.FiscalYaers.FiscalYaer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("SDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<string>("desccription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("eDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Fiscalyear", (string)null);
                });

            modelBuilder.Entity("Inventory.Domin.InventoryVoucher.InventoryVoucher_Shopping", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("Dates")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Fisicalyearref")
                        .HasColumnType("bigint");

                    b.Property<long>("SupplierRef")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<int>("VoucherType")
                        .HasColumnType("int");

                    b.Property<long>("nummber")
                        .HasColumnType("bigint");

                    b.Property<long>("storeref")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("Fisicalyearref");

                    b.HasIndex("SupplierRef");

                    b.HasIndex("storeref");

                    b.ToTable("InventoryVoucher", (string)null);
                });

            modelBuilder.Entity("Inventory.Domin.InventoryVoucherItem.InventoryVoucheritemShopping", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Inventoryoucherref")
                        .HasColumnType("bigint");

                    b.Property<long>("Quntity")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<long>("productsref")
                        .HasColumnType("bigint");

                    b.Property<long>("unitref")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("Inventoryoucherref");

                    b.HasIndex("productsref");

                    b.HasIndex("unitref");

                    b.ToTable("inventoryVoucherItem", (string)null);
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

                    b.Property<long>("subcategoriesref")
                        .HasColumnType("bigint");

                    b.Property<long>("unitref")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("brand");

                    b.HasIndex("categoriesref");

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("Inventory.Domin.Stores.StoreAgg", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("StoreCode")
                        .HasColumnType("bigint");

                    b.Property<string>("StoreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("store", (string)null);
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

            modelBuilder.Entity("Inventory.Domin.Suplier.Supplier", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Addresss")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Cityref")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<long>("counteryref")
                        .HasColumnType("bigint");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Supplier", (string)null);
                });

            modelBuilder.Entity("Inventory.Domin.Units.Unit", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("unit");
                });

            modelBuilder.Entity("Inventory.Domin.AddProductsToStore.AddProductTostore", b =>
                {
                    b.HasOne("Inventory.Domin.Product.ProductsAgg", "produccts")
                        .WithMany("AddProductTostores")
                        .HasForeignKey("productRef")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inventory.Domin.Stores.StoreAgg", "Store")
                        .WithMany("AddProductTostores")
                        .HasForeignKey("storeRef")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Store");

                    b.Navigation("produccts");
                });

            modelBuilder.Entity("Inventory.Domin.Cardex.Cardexes", b =>
                {
                    b.HasOne("Inventory.Domin.Product.ProductsAgg", "products")
                        .WithMany("Cardexes")
                        .HasForeignKey("productsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inventory.Domin.Stores.StoreAgg", "store")
                        .WithMany("Cardexes")
                        .HasForeignKey("storeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("products");

                    b.Navigation("store");
                });

            modelBuilder.Entity("Inventory.Domin.Cities.City", b =>
                {
                    b.HasOne("Inventory.Domin.Country.Countreis", "Countreis")
                        .WithMany("Cities")
                        .HasForeignKey("Countryref")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Countreis");
                });

            modelBuilder.Entity("Inventory.Domin.Costumer.Costmers", b =>
                {
                    b.HasOne("Inventory.Domin.Country.Countreis", "Countreis")
                        .WithMany("Costmers")
                        .HasForeignKey("Countryref")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Countreis");
                });

            modelBuilder.Entity("Inventory.Domin.InventoryVoucher.InventoryVoucher_Shopping", b =>
                {
                    b.HasOne("Inventory.Domin.FiscalYaers.FiscalYaer", "Fiscalyearref")
                        .WithMany("inventory")
                        .HasForeignKey("Fisicalyearref")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inventory.Domin.Suplier.Supplier", "Supplier")
                        .WithMany("inventory")
                        .HasForeignKey("SupplierRef")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inventory.Domin.Stores.StoreAgg", "Store")
                        .WithMany("inventory")
                        .HasForeignKey("storeref")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fiscalyearref");

                    b.Navigation("Store");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("Inventory.Domin.InventoryVoucherItem.InventoryVoucheritemShopping", b =>
                {
                    b.HasOne("Inventory.Domin.InventoryVoucher.InventoryVoucher_Shopping", "InventoryVoucherShopping")
                        .WithMany("InventoryVoucheritem")
                        .HasForeignKey("Inventoryoucherref")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inventory.Domin.Product.ProductsAgg", "prdoucts")
                        .WithMany("InventoryVoucheritem")
                        .HasForeignKey("productsref")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inventory.Domin.Units.Unit", "unit")
                        .WithMany("InventoryVoucheritem")
                        .HasForeignKey("unitref")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InventoryVoucherShopping");

                    b.Navigation("prdoucts");

                    b.Navigation("unit");
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

            modelBuilder.Entity("Inventory.Domin.Country.Countreis", b =>
                {
                    b.Navigation("Cities");

                    b.Navigation("Costmers");
                });

            modelBuilder.Entity("Inventory.Domin.FiscalYaers.FiscalYaer", b =>
                {
                    b.Navigation("inventory");
                });

            modelBuilder.Entity("Inventory.Domin.InventoryVoucher.InventoryVoucher_Shopping", b =>
                {
                    b.Navigation("InventoryVoucheritem");
                });

            modelBuilder.Entity("Inventory.Domin.Product.ProductsAgg", b =>
                {
                    b.Navigation("AddProductTostores");

                    b.Navigation("Cardexes");

                    b.Navigation("InventoryVoucheritem");
                });

            modelBuilder.Entity("Inventory.Domin.Stores.StoreAgg", b =>
                {
                    b.Navigation("AddProductTostores");

                    b.Navigation("Cardexes");

                    b.Navigation("inventory");
                });

            modelBuilder.Entity("Inventory.Domin.Suplier.Supplier", b =>
                {
                    b.Navigation("inventory");
                });

            modelBuilder.Entity("Inventory.Domin.Units.Unit", b =>
                {
                    b.Navigation("InventoryVoucheritem");
                });
#pragma warning restore 612, 618
        }
    }
}
