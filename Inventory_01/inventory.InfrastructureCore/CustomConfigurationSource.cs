using Inventory.Domin.AddProductsToStore;
using Inventory.Domin.Brand;
using Inventory.Domin.CategoryAgg;
using Inventory.Domin.Cities;
using Inventory.Domin.Costumer;
using Inventory.Domin.Country;
using Inventory.Domin.FiscalYaers;
using Inventory.Domin.InventoryVoucher;
using Inventory.Domin.Product;
using Inventory.Domin.Stores;
using Inventory.Domin.SubCategory;
using Inventory.Domin.Supliers;
using Inventory.Domin.Units;
using InventoryApplication.AddproductToStore;
using InventoryApplication.BrandApplication;
using InventoryApplication.Categores;
using InventoryApplication.Cities;
using InventoryApplication.Costumer;
using InventoryApplication.CountryApplication;
using InventoryApplication.FiscalYearApp;
using InventoryApplication.inventoryVoucher;
using InventoryApplication.InventoryVoucherItemapp;
using InventoryApplication.Produts_Appliaction;
using InventoryApplication.StoreApp;
using InventoryApplication.SubCategory;
using InventoryApplication.SupplierApp;
using InventoryApplication.Unit;
using InventoryApplicationContract.Addedproductstostore;
using InventoryApplicationContract.BrandApplicationContract;
using InventoryApplicationContract.Categores;
using InventoryApplicationContract.Cities;
using InventoryApplicationContract.Costumer;
using InventoryApplicationContract.Countries;
using InventoryApplicationContract.FiscalyearApp_Contract;
using InventoryApplicationContract.InventoryVoucherItem;
using InventoryApplicationContract.ProductContartct;
using InventoryApplicationContract.StoreCotracct;
using InventoryApplicationContract.SubCategoryContract;
using InventoryApplicationContract.Supplier;
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
            builder.AddTransient<IUnitAplication, UnitAplications>();
            builder.AddTransient<IUnitReposetory, UnitReposetory>();
            builder.AddTransient<ICountriesReposetory, CountriesReposetory>();
            builder.AddTransient<IApplicationCountries, CountryApplication>();
            builder.AddTransient<ICitiesApplaiction, CtiesAppliccation>();
            builder.AddTransient<ICitiesReposetory, CitiesRepostory>();
            builder.AddTransient<ICostumerReposetory, CostumerReposetory>();
            builder.AddTransient<ICostumerAppliation, CostumerAppliation>();
            builder.AddTransient<ISupplierReposetory, SupplierReposetory>();
            builder.AddTransient<ISupplierApplicaation, SupplierApplication>();
            builder.AddTransient<IFiscalyearReposetory, FiscalyearReposetory>();
            builder.AddTransient<IFiscalYearApplication, FiscalYearApplication>();
            builder.AddTransient<IStoreReposetory, StoreReposetory>();
            builder.AddTransient<IStoreApplication, StoreApplication>();
            builder.AddTransient<IAddProductToStoreReposetory, AddProductToStoreReposetory>();
            builder.AddTransient<IAddProductToStoreApp, AddProductToStoreApp>();
            builder.AddTransient<IInventoryVocherReposetory, InventoryVocherReposetory>();
            builder.AddTransient<IInventoryVoucherApp, inventoryvoucherApp>();
            builder.AddTransient<IInventoryVocherItemReposetory, InventoryVocherItemReposetory>();
            builder.AddTransient<IInventoryVoucherItemApp, InventoryVoucherItemApp>();
        }


    }
}


