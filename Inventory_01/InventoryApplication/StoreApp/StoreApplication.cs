using InventoryApplicationContract.StoreCotracct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Domin.Stores;

namespace InventoryApplication.StoreApp
{
    public class StoreApplication : IStoreApplication
    {
        private readonly IStoreReposetory _reposetory;

        public StoreApplication(IStoreReposetory reposetory)
        {
            _reposetory = reposetory;
        }

        public void Ceaate(CreateStore e)
        {
            StoreAgg str = new(e.StoreCode, e.StoreName);
            _reposetory.Insert(str);
            _reposetory.Save();
        }

        public Editedstore getdtailforEditd(long id)
        {
            var x = _reposetory.GetById(id);
            return new Editedstore()
            {
                Id = x.Id,
                StoreCode = x.StoreCode,
                StoreName = x.StoreName,
            };
        }

        public void Edited(Editedstore e)
        {

            var x = _reposetory.GetById(e.Id);
            x.Edited(e.StoreCode,e.StoreName);
            _reposetory.Save();
        }

        public List<StoreViewmodel> getstores()
        {
            return _reposetory.GetAll().Select(x => new StoreViewmodel()
            {
                Id = x.Id,
                StoreCode = x.StoreCode,
                StoreName = x.StoreName,
            }).ToList();
        }
    }
}
