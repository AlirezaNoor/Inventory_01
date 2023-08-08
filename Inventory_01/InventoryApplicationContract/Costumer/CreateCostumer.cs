using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace InventoryApplicationContract.Costumer
{
    public class CreateCostumer
    {
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public long Countryref { get; set; }
        public long Cityref { get; set; }
        public string Address { get; set; }
        public string Desciption { get; set; }
        public SelectList countrylist { get; set; }
        public SelectList cityeslist  { get; set; }

    }
}
