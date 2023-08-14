namespace InventoryApplicationContract.FiscalyearApp_Contract;

public class FiscalYearViewModel
{
    public long Id { get; set; }
    public string name { get;  set; }
    public string desccription { get;  set; }

    public DateTime SDateTime { get; set; }
    public DateTime EDateTime { get; set; }
}