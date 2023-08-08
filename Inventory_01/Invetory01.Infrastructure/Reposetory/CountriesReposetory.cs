using Framework.GnericReposetory;
using Inventory.Domin.CategoryAgg;
using Inventory.Domin.Country;
using Invetory01.Infrastructure.Db_Context;
using Invetory01.Infrastructure.GnericReposetory;
using Microsoft.EntityFrameworkCore;

namespace Invetory01.Infrastructure.Reposetory
{
    public class CountriesReposetory: GenericReposetores<Countreis, long>,ICountriesReposetory
    {
        private readonly MyContext _myContext;

        public CountriesReposetory(MyContext myContext):base(myContext)
        {
            _myContext = myContext;
        }
    }
}
