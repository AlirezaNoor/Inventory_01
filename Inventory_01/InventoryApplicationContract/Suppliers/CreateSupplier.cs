using Microsoft.AspNetCore.Mvc.Rendering;

namespace InventoryApplicationContract.Supplier
{
    public class CreateSupplier
    {
        public string SupplierName { get; set; }
        public string Email { get; set; }
        public string phone { get; set; }
        public long counteryref { get; set; }
        public long Cityref { get; set; }
        public string Addresss { get; set; }
        public string Description { get; set; }
        public SelectList couneries { get; set; }
        public SelectList cities { get; set; }

    }
}
