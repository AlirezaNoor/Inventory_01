using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApplicationContract.BrandApplicationContract
{
    public interface IBrandApplication
    {
        void createsubcategory(CreateBrand comamd);
        EditedBrand EditeSubCategoryGetdtails(long id);

        void EditedSubCategryRecords(EditedBrand comand);

        List<BrandViewModel> showAll();

        void deleteSubcategory(long id);
    }
}
