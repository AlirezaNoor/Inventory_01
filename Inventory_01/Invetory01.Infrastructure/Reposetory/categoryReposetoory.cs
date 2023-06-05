using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.GnericReposetory;
using Inventory.Domin.CategoryAgg;
using InventoryApplicationContract.Categores;
using Invetory01.Infrastructure.Db_Context;
using Microsoft.EntityFrameworkCore;

namespace Invetory01.Infrastructure.Reposetory
{
    public class categoryReposetoory:GenericReposetores<Categores,long>, IcategoryReposetoory
    {
        private MyContext _context;
        public categoryReposetoory( MyContext context1) : base(context1)
        {
            _context = context1;
        }


    }
}
