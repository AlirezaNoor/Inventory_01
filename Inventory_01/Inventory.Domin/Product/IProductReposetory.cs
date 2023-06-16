using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invetory01.Infrastructure.GnericReposetory;

namespace Inventory.Domin.Product
{
    public interface IProductReposetory:IGenericReposetores<ProductsAgg,long>
    {
    }
}
