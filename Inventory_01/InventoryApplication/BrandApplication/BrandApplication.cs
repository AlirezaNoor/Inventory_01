using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Domin.Brand;
using InventoryApplicationContract.BrandApplicationContract;

namespace InventoryApplication.BrandApplication
{
    public class BrandApplication : IBrandApplication
    {

        private readonly IBrandReposetory _reposetory;

        public BrandApplication(IBrandReposetory reposetory)
        {
            _reposetory = reposetory;
        }

        public void createsubcategory(CreateBrand comamd)
        {
            var brand = new BrandAgg(comamd.name, comamd.descrption);
            _reposetory.Insert(brand);
            _reposetory.Save();
        }

        public EditedBrand EditeSubCategoryGetdtails(long id)
        {
            var x = _reposetory.GetById(id);
            return new EditedBrand()
            {
                Id = x.Id,
                name = x.name,
                descrption = x.desicription
            };

        }

        public void EditedSubCategryRecords(EditedBrand comand)
        {
            var edited = _reposetory.GetById(comand.Id);
            edited.Edited(comand.name,comand.descrption);
            _reposetory.Save();
        }

        public List<BrandViewModel> showAll()
        {
            return _reposetory.GetAll().Select(x => new BrandViewModel()
            {
                name = x.name,
                Id = x.Id,
                descrption = x.desicription
            }).ToList();
        }

        public void deleteSubcategory(long id)
        {
            _reposetory.Delete(id);
            _reposetory.Save();
        }
    }
}
