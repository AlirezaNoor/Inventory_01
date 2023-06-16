using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Domin.CategoryAgg;
using Inventory.Domin.SubCategory;
using InventoryApplicationContract.SubCategoryContract;

namespace InventoryApplication.SubCategory
{
    public class SubCategoryApplication: ISubCategoryApplication
    {
        private readonly ISubCategoryReposetory _subcategory;
        private readonly IcategoryReposetoory _category;
        public SubCategoryApplication(ISubCategoryReposetory subcategory, IcategoryReposetoory category)
        {
            _subcategory = subcategory;
            _category = category;
        }

        public void createsubcategory(CreateSubCategory comamd)
        {
            var mysubcategory = new SubCategories(comamd.Name, comamd.Description, comamd.CubCategorycode,
                comamd.CategoryRef);
            _subcategory.Insert(mysubcategory);
            _subcategory.Save();
        }

        public EditedSubCategory EditeSubCategoryGetdtails(long id)
        {
            var x = _subcategory.GetById(id);
            return new EditedSubCategory()
            {
                CategoryRef = x.CategoryRef,
                CubCategorycode = x.CubCategorycode,
                Description = x.Description,
                Id = x.Id,
                Name = x.Name,
                
            };
        }

        public void EditedSubCategryRecords(EditedSubCategory comand)
        {
            var subcategory = _subcategory.GetById(comand.Id);
            subcategory.EditedSubCategory(comand.Name, comand.Description, comand.CubCategorycode,
                comand.CategoryRef);
            _subcategory.Save();
        }

        public List<SubCategoryViewModel> showAll()
        {
            return _subcategory.GetAll().Select(x => new SubCategoryViewModel()
            {
                CategoryRef = x.CategoryRef,
                //Categoryname = x.Category.CategoryName,
                Categoryname = _category.GetById(x.CategoryRef).CategoryName,
                CubCategorycode = x.CubCategorycode,
                Description = x.Description,
                Name = x.Name,
                Id = x.Id
            }).ToList();
        }

        public void deleteSubcategory(long id)
        {
            _subcategory.Delete(id);
            _subcategory.Save();
        }
    }
}
