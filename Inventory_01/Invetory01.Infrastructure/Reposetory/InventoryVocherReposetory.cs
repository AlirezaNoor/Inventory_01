using Inventory.Domin.InventoryVoucher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.GnericReposetory;
using Invetory01.Infrastructure.Db_Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace Invetory01.Infrastructure.Reposetory
{
    public class InventoryVocherReposetory:GenericReposetores<InventoryVoucher_Shopping,long>, IInventoryVocherReposetory
    {
    private readonly MyContext _context;

    public InventoryVocherReposetory( MyContext context) : base(context)
    {
        _context = context;
    }
    }
}
