using Microsoft.AspNetCore.Mvc.Rendering;

namespace InventoryApplicationContract.Cities
{
    public class CreateCity
    {
        public string Name { get; set; }
        public long Countryref { get; set; }
        public string Description { get; set; }

        public SelectList cotries { get; set; }
    }
}
