using InventoryApplicationContract.InventoryVochuer;
using InventoryApplicationContract.InventoryVoucherItem;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HostService.Models
{
    public class VoucherViewModel
    {
        public long storeref { get; set; }
        public long nummber { get; set; }
        public long SupplierRef { get; set; }
        public DateTime Dates { get; set; }
        public int VoucherType { get; set; }
        public string Description { get; set; }
        public long fisicalyearref { get; set; }
        public List<createInventoryVoucherItem> Tyinvetoryvoucher { get; set; }
        public SelectList products { get; set; }
        public SelectList unit { get; set; }
        public SelectList supplier { get; set; }
        public SelectList proandstroe { get; set; }
        public SelectList store { get; set; }
    }
}
