using Inventory.Domin.Brand;
using Inventory.Domin.CategoryAgg;
using Inventory.Domin.SubCategory;
using InventoryApplication.BrandApplication;
using InventoryApplication.Categores;
using InventoryApplication.SubCategory;
using InventoryApplicationContract.BrandApplicationContract;
using InventoryApplicationContract.Categores;
using InventoryApplicationContract.SubCategoryContract;
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
        }


    }
}


