using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApplicationContract.Supplier
{
    public interface ISupplierApplicaation
    {
        void createsupp(CreateSupplier e);
        Editedsupplier getdtails(long id);
        void saveeditchanges(Editedsupplier e);
        List<supplierViewModel> getall();
    }
}
