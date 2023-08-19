using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Domin.InventoryVoucherItem;
using Invetory01.Infrastructure.GnericReposetory;

namespace Inventory.Domin.InventoryVoucher
{
    public interface IInventoryVocherItemReposetory:IGenericReposetores<InventoryVoucheritemShopping, long>
    {
        void CreateInventoryvoucherRange(List<InventoryVoucheritemShopping> x);
    }
}
