using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Domin.Units;
using InventoryApplicationContract.UnitCantrat;

namespace InventoryApplication.Unit
{
    public class UnitAplication: IUnitAplication
    {
        private readonly IUnitReposetory _reposetory;

        public UnitAplication(IUnitReposetory reposetory)
        {
            _reposetory = reposetory;
        }

        public List<UnitList> getAllUnit()
        {
            return _reposetory.GetAll().Select(x => new UnitList()
            {
                id = x.ID,
                name = x.Name

            }).ToList();
        }
    }
}
