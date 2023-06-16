using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.GnericReposetory;
using Inventory.Domin.SubCategory;
using Invetory01.Infrastructure.Db_Context;
using Microsoft.EntityFrameworkCore;

namespace Invetory01.Infrastructure.Reposetory
{
    public class SubCategoryReposetory:GenericReposetores<SubCategories,long>, ISubCategoryReposetory
    {
        private readonly MyContext _context;

        public SubCategoryReposetory( MyContext context2) : base(context2)
        {
            _context = context2;
        }
    }
}
