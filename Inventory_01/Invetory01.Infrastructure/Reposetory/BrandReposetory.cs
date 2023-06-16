using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.GnericReposetory;
using Inventory.Domin.Brand;
using Invetory01.Infrastructure.Db_Context;
using Microsoft.EntityFrameworkCore;

namespace Invetory01.Infrastructure.Reposetory
{
    public class BrandReposetory:GenericReposetores<BrandAgg,long>, IBrandReposetory
    {
        private readonly MyContext _context;

        public BrandReposetory(MyContext context):base(context)
        {
            _context = context;
        }
    }
}
