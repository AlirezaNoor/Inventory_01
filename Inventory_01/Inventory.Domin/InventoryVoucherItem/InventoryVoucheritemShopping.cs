using Framework;
using Inventory.Domin.InventoryVoucher;
using Inventory.Domin.Product;
using Inventory.Domin.Units;

namespace Inventory.Domin.InventoryVoucherItem;

public class InventoryVoucheritemShopping : GolbalGeneric
{
    public long productsref { get; private set; }
    public long unitref { get; private set; }
    public long Quntity { get; private set; }
    public long Inventoryoucherref { get; private set; }
    public string Description { get; private set; }
    public InventoryVoucher_Shopping InventoryVoucherShopping { get; set; }
    public ProductsAgg prdoucts { get; set; }
    public Unit unit { get; set; }

    public InventoryVoucheritemShopping(long productsref, long unitref, long quntity, long inventoryoucherref, string description)
    {
        this.productsref = productsref;
        this.unitref = unitref;
        Quntity = quntity;
        Inventoryoucherref = inventoryoucherref;
        Description = description;
    }
    public void Edited(long productsref, long unitref, long quntity, long inventoryoucherref, string description)
    {
        this.productsref = productsref;
        this.unitref = unitref;
        Quntity = quntity;
        Inventoryoucherref = inventoryoucherref;
        Description = description;
    }
}