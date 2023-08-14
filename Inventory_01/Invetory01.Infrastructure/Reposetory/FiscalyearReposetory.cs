using Inventory.Domin.FiscalYaers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.GnericReposetory;
using Invetory01.Infrastructure.Db_Context;

namespace Invetory01.Infrastructure.Reposetory
{
    public class FiscalyearReposetory:GenericReposetores<FiscalYaer,long> ,IFiscalyearReposetory
    {
        private readonly MyContext _context;

        public FiscalyearReposetory(MyContext context):base(context)
        {
            _context = context;
        }
    }
}
