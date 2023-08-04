using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.GnericReposetory;
using Inventory.Domin.Units;
using Invetory01.Infrastructure.Db_Context;
using Microsoft.EntityFrameworkCore;

namespace Invetory01.Infrastructure.Reposetory
{
    public class UnitReposetory: GenericReposetores<Unit,long>,IUnitReposetory
    {
        private readonly MyContext _context;

        public UnitReposetory(MyContext context):base(context)
        {
            _context = context;
        }
    }
}
