using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.GnericReposetory;
using Inventory.Domin.InventoryVoucher;
using Inventory.Domin.InventoryVoucherItem;
using Invetory01.Infrastructure.Db_Context;
using Microsoft.EntityFrameworkCore;

namespace Invetory01.Infrastructure.Reposetory
{
    public  class InventoryVocherItemReposetory:GenericReposetores<InventoryVoucheritemShopping,long>, IInventoryVocherItemReposetory
    {
private readonly MyContext _context;

public InventoryVocherItemReposetory(MyContext context):base(context)
{
    _context = context;
}

public void CreateInventoryvoucherRange(List<InventoryVoucheritemShopping> x)
        {
_context.InventoryVoucheritem.AddRange(x);
        }
    }
}
