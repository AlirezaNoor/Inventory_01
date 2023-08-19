using InventoryApplicationContract.InventoryVochuer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApplicationContract.InventoryVoucherItem
{
    public interface IInventoryVoucherItemApp
    {
        void createVoucher(List<createInventoryVoucherItem> e);
        EditedInventoryVoucherItem voucher(long id);
        void EdtiedRecoordes(EditedInventoryVoucherItem e);
        List<ViewInventoryVoucherItem> getList();
    }
}
