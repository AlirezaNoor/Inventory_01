using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApplicationContract.Addedproductstostore
{
    public interface IAddProductToStoreApp
    {
        void Create(CreateAddPtoS e);
        EditedAddPtoS etdtials(long id);
        void edited(EditedAddPtoS e);
        List<AddPtoSViewmodel> getall();

    }
}
