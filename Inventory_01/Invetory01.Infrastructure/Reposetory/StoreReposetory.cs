using Framework.GnericReposetory;
using Inventory.Domin.Stores;
using Invetory01.Infrastructure.Db_Context;

namespace Invetory01.Infrastructure.Reposetory
{
    public class StoreReposetory:GenericReposetores<StoreAgg,long> ,IStoreReposetory
    {
        private readonly MyContext _context;

        public StoreReposetory(MyContext context):base(context)
        {
            _context = context;
        }
    }
}
