using Microsoft.Extensions.Logging;

namespace InventoryApplicationContract.FiscalyearApp_Contract
{
    public class CreateFiscalYear
    {
        public string name { get;  set; }
        public string desccription { get;  set; }
        public DateTime SDateTime { get;  set; }
        public DateTime EDateTime { get;  set; }
    }
}
