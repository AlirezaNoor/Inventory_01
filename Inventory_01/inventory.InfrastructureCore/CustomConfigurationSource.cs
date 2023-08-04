using Inventory.Domin.Brand;
using Inventory.Domin.CategoryAgg;
using Inventory.Domin.Product;
using Inventory.Domin.SubCategory;
using Inventory.Domin.Units;
using InventoryApplication.BrandApplication;
using InventoryApplication.Categores;
using InventoryApplication.Produts_Appliaction;
using InventoryApplication.SubCategory;
using InventoryApplication.Unit;
using InventoryApplicationContract.BrandApplicationContract;
using InventoryApplicationContract.Categores;
using InventoryApplicationContract.ProductContartct;
using InventoryApplicationContract.SubCategoryContract;
using InventoryApplicationContract.UnitCantrat;
using Invetory01.Infrastructure.Reposetory;
using Microsoft.Extensions.DependencyInjection;

namespace inventory.InfrastructureCore
{
    public class CustomConfigurationSource
    {
        public static void configure(IServiceCollection builder)

        {
            builder.AddTransient<IcategoryReposetoory, categoryReposetoory>();
            builder.AddTransient<ICategoresApplictaion, CategoresApplictaion>();
            builder.AddTransient<ISubCategoryReposetory, SubCategoryReposetory>();
            builder.AddTransient<ISubCategoryApplication, SubCategoryApplication>();
            builder.AddTransient<IBrandReposetory, BrandReposetory>();
            builder.AddTransient<IBrandApplication, BrandApplication>();
            builder.AddTransient<IProductReposetory, ProductReposetory>();
            builder.AddTransient<IProdutsApplation, ProdutsApplation>();
            builder.AddTransient<IUnitAplication, UnitAplication>();
            builder.AddTransient<IUnitReposetory, UnitReposetory>();
        }


    }
}


