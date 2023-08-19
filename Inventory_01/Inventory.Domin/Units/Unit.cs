using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Domin.InventoryVoucherItem;

namespace Inventory.Domin.Units
{
    public class Unit
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public List<InventoryVoucheritemShopping> InventoryVoucheritem { get; set; }
    }
}
