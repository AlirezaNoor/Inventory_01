using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Domin.CategoryAgg;
using InventoryApplication.Categores;
using InventoryApplicationContract.Categores;
using Invetory01.Infrastructure.Reposetory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace inventory.InfrastructureCore
{
    public class CustomConfigurationSource
    {
        public static void configure(IServiceCollection builder)

        {
            builder.AddTransient<IcategoryReposetoory, categoryReposetoory>();
            builder.AddTransient<ICategoresApplictaion, CategoresApplictaion>();
        }


    }
}


