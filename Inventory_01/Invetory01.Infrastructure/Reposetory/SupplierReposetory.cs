using Framework.GnericReposetory;
using Inventory.Domin.Suplier;
using Inventory.Domin.Supliers;
using Invetory01.Infrastructure.Db_Context;
using Microsoft.EntityFrameworkCore;

namespace Invetory01.Infrastructure.Reposetory
{
    public class SupplierReposetory:GenericReposetores<Supplier,long>,ISupplierReposetory
    {
     private readonly MyContext _context;

     public SupplierReposetory(MyContext context):base(context)
     {
         _context = context;
     }
    }
}
