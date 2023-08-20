using Framework;
using Inventory.Domin.InventoryVoucher;

namespace Inventory.Domin.FiscalYaers
{
    public class FiscalYaer:GolbalGeneric
    {
        public string name { get; private set; }
        public string desccription { get; private set; }
        public DateTime SDateTime { get; private set; }
        public DateTime eDateTime { get; private set; }
        public List<InventoryVoucher_Shopping> inventory { get; set; }
        public FiscalYaer(string name, string desccription, DateTime sDateTime, DateTime eDateTime)
        {
            this.name = name;
            this.desccription = desccription;
            SDateTime = sDateTime;
            this.eDateTime = eDateTime;
        }

 

        public void ediited(string name, string desccription, DateTime sDateTime, DateTime eDateTime)
        {
            this.name = name;
            this.desccription = desccription;
            SDateTime = sDateTime;
            this.eDateTime = eDateTime;
        }

    }
}
