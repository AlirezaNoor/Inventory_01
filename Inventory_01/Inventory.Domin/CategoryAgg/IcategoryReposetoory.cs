using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryApplicationContract.Categores;
using Invetory01.Infrastructure.GnericReposetory;

namespace Inventory.Domin.CategoryAgg
{
    public interface IcategoryReposetoory:IGenericReposetores<Categores,long>
    {
      
    }
}
