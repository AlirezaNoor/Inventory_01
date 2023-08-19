using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invetory01.Infrastructure.GnericReposetory;

namespace Inventory.Domin.InventoryVoucher
{
    public interface IInventoryVocherReposetory:IGenericReposetores<InventoryVoucher_Shopping,long>
    {
    }
}
