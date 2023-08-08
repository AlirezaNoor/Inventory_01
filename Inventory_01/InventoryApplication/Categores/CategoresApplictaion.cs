using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Domin.CategoryAgg;
using InventoryApplicationContract.Categores;

namespace InventoryApplication.Categores
{
    public class CategoresApplictaion : ICategoresApplictaion
    {
        private readonly IcategoryReposetoory _reposetoory;

        public CategoresApplictaion(IcategoryReposetoory reposetoory)
        {
            _reposetoory = reposetoory;
        }

        public void create(CreateCategores commnad)
        {
            var category =
                new Inventory.Domin.CategoryAgg.Categores(commnad.CategoryName, commnad.CategoryCode,
                    commnad.Descirption);
            _reposetoory.Insert(category);
            _reposetoory.Save();
        }

        public List<viewModel> showAll()
        {

            return _reposetoory.GetAll().Select(x => new viewModel()
            {
                CategoryName = x.CategoryName,
                CategoryCode = x.CategoryCode,
                Descirption = x.Descirption,
                Id = x.Id
            }).ToList();
        }

        public void remove(long id)
        {
            _reposetoory.Delete(id);
            _reposetoory.Save();

        }

        public EditCategores edited(long id)
        {
            var editeds = _reposetoory.GetById(id);

            return new EditCategores()
            {
                Id = editeds.Id,
                CategoryCode = editeds.CategoryCode,
                CategoryName = editeds.CategoryName,
                Descirption = editeds.Descirption,
            };
        }

        public void EditedRecordes(EditCategores command)
        {
            var entity = _reposetoory.GetById(command.Id);
            entity.EditCategores(command.CategoryName,command.CategoryCode,command.Descirption);
            _reposetoory.Save();


        }

        public List<viewModel> categoryseletor()
        {

            return _reposetoory.GetAll().Select(x => new viewModel()
            {
                Id = x.Id,
                CategoryName = x.CategoryName
            }).ToList();
        }

        public viewModel caateoryseelected(long id)
        {
            var x= _reposetoory.GetById(id);

            return new viewModel()
            {
                Id = x.Id,
                CategoryName = x.CategoryName,
            };
        }
    }
}
