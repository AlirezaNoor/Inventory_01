using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.GnericReposetory;
using Inventory.Domin.Cities;
using Invetory01.Infrastructure.Db_Context;

namespace Invetory01.Infrastructure.Reposetory
{
    public class CitiesRepostory:GenericReposetores<City,long>, ICitiesReposetory
    {
        private readonly MyContext _context;

        public CitiesRepostory(MyContext context):base(context)
        {
            _context = context;
        }
    }
}
