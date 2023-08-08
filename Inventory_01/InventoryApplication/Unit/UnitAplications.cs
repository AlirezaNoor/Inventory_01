using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Domin.Units;
using InventoryApplicationContract.UnitCantrat;

namespace InventoryApplication.Unit
{
    public class UnitAplications: IUnitAplication
    {
        private readonly IUnitReposetory _reposetory;

        public UnitAplications(IUnitReposetory reposetory)
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

        public UnitList selected(long id)
        {
            var x=_reposetory.GetById(id);

            return new UnitList()
            {
                id = x.ID,
                name = x.Name
            };
        }
    }
}
