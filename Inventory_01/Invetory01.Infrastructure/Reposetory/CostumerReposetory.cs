using Inventory.Domin.Costumer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.GnericReposetory;
using Invetory01.Infrastructure.Db_Context;
using Microsoft.EntityFrameworkCore;

namespace Invetory01.Infrastructure.Reposetory
{
    public class CostumerReposetory:GenericReposetores<Costmers,long> ,ICostumerReposetory
    {
        private readonly MyContext _context;

        public CostumerReposetory(MyContext context) : base(context)
        {
        }
    }
}
