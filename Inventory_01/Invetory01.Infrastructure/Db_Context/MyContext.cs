﻿using Inventory.Domin.Brand;
using Inventory.Domin.CategoryAgg;
using Inventory.Domin.Cities;
using Inventory.Domin.Costumer;
using Inventory.Domin.Country;
using Inventory.Domin.Product;
using Inventory.Domin.SubCategory;
using Inventory.Domin.Units;
using Invetory01.Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Invetory01.Infrastructure.Db_Context
{
    public  class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }

        public DbSet<Categores> categores { get; set; }
        public DbSet<SubCategories> SubCategories { get; set; }
        public DbSet<BrandAgg> brand { get; set; }
        public DbSet<ProductsAgg> Products { get; set; }
        public DbSet<Countreis> country { get; set; }
        public DbSet<Unit> unit { get; set; }
        public DbSet<City> city { get; set; }
        public DbSet<Costmers> costumer { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMapping());
            modelBuilder.ApplyConfiguration(new SubCategoryMapping()); 
            modelBuilder.ApplyConfiguration(new BrandMapping()); 
            modelBuilder.ApplyConfiguration(new ProductMapping());
            modelBuilder.ApplyConfiguration(new UnitMapping());
            modelBuilder.ApplyConfiguration(new CountriesMapping());
            modelBuilder.ApplyConfiguration(new CityMapping());
            modelBuilder.ApplyConfiguration(new CostumerMapping());

        }
    }
}
