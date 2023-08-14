using Microsoft.AspNetCore.Mvc.Rendering;

namespace InventoryApplicationContract.Addedproductstostore
{
    public class CreateAddPtoS
    {
        public long StoreRef { get; set; }
        public long ProductRef { get; set; }
        public SelectList Store { get; set; }
        public SelectList Product { get; set; }
    }
}
