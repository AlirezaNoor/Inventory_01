namespace InventoryApplicationContract.ProductContartct
{
    public class productlistview
    {
        public long Id { get; set; }
        public string name { get; set; }
        public string cateoryref { get; set; }
        public string subcateoryref { get; set; }
        public string baand { get; set; }
        public string sku { get; set; }
        public decimal price { get; set; }
        public string unit { get; set; }
        public decimal Qty { get; private set; }
        public decimal minmuimQty { get;  set; }
        public long Tax { get;  set; }
        public long Discuont { get;  set; }
        public long statuse { get;  set; }
    }
}
