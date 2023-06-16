using Inventory.Domin.Brand;
using Inventory.Domin.CategoryAgg;
using Inventory.Domin.Product;
using Inventory.Domin.SubCategory;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMapping());
            modelBuilder.ApplyConfiguration(new SubCategoryMapping()); 
            modelBuilder.ApplyConfiguration(new BrandMapping()); 
            modelBuilder.ApplyConfiguration(new ProductMapping());
        }
    }
}
