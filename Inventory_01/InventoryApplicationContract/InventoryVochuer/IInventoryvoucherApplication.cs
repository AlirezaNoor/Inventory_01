using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryApplicationContract.InventoryVochuer;

namespace Inventory.Domin.InventoryVoucher
{
    public interface IInventoryVoucherApp
    {
        void createVoucher(CreateInventoryVoucher e);
        EditedInventoryvoucher voucher(long id);
        void EdtiedRecoordes (EditedInventoryvoucher e);
        List<ViewInventoryVoucher> getList();
    }
}
