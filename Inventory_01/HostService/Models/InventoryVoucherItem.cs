using Microsoft.AspNetCore.Mvc.Rendering;

namespace HostService.Models
{
    public class InventoryVoucherItem
    {
        public long ProductsRef { get; set; }
        public long UnitRef { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public SelectList products { get; set; }
        public SelectList unit { get; set; }
        public SelectList supplier { get; set; }
        public SelectList proandstroe { get; set; }
        public SelectList store { get; set; }
        public long storeref { get; set; }
        public long nummber { get; set; }
        public long SupplierRef { get; set; }
        public string Dates { get; set; }
        public int VoucherType { get; set; }
        public string Descriptionhead { get; set; }
    }
}
