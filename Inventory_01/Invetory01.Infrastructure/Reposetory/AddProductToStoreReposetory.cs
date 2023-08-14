using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.GnericReposetory;
using Inventory.Domin.AddProductsToStore;
using Invetory01.Infrastructure.Db_Context;
using Microsoft.EntityFrameworkCore;

namespace Invetory01.Infrastructure.Reposetory
{
    public class AddProductToStoreReposetory:GenericReposetores<AddProductTostore,long>, IAddProductToStoreReposetory
    {
        private readonly MyContext _context;

        public AddProductToStoreReposetory( MyContext context2) : base(context2)
        {
            _context = context2;
        }
    }
}
