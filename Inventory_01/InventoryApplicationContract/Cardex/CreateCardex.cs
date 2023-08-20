using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApplicationContract.Cardex
{
    public class CreateCardex
    {
        public long storeref { get; set; }
        public long propductsref { get; set; }
        public DateTime transactiondate { get; set; }
        public long vorodkhoroj { get; set; }
        public long Quantity { get; set; }
    }
}
