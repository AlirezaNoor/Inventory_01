using Framework;
using Inventory.Domin.Brand;
using Inventory.Domin.CategoryAgg;
using Inventory.Domin.SubCategory;

namespace Inventory.Domin.Product
{
    public class ProductsAgg:GolbalGeneric
    {
        public string  ProductName { get; private set; }
        public long categoriesref { get; private set; }
        public long brand { get; private set; }
        public long unitref { get; private set; }
        public string Sku { get; private set; }
        public decimal Qty { get; private set; }
        public decimal minmuimQty { get; private set; }
        public long Tax { get; private set; }
        public long Discuont { get; private set; }
        public decimal price { get; private set; }
        public long statuse { get; private set; }
        public Categores Category { get; private set; }
        public BrandAgg Brand { get; private set; }


        public ProductsAgg(string productName, long categoriesref,  long brand, long unitref, string sku, decimal qty, decimal minmuimQty, long tax, long discuont, decimal price, long statuse)
        {
            ProductName = productName;
            this.categoriesref = categoriesref;
            this.brand = brand;
            this.unitref = unitref;
            Sku = sku;
            Qty = qty;
            this.minmuimQty = minmuimQty;
            Tax = tax;
            Discuont = discuont;
            this.price = price;
            this.statuse = statuse;
        }

        public void Edited(string productName, long categoryref, long brand, long unitref, string sku, decimal qty, decimal minmuimQty, long tax, long discuont, decimal price, long statuse)
        {
            ProductName = productName;
            this.categoriesref = categoryref;
            this.brand = brand;
            this.unitref = unitref;
            Sku = sku;
            Qty = qty;
            this.minmuimQty = minmuimQty;
            Tax = tax;
            Discuont = discuont;
            this.price = price;
            this.statuse = statuse;
        }
    }
}
