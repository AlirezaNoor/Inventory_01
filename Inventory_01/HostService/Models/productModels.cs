using InventoryApplicationContract.BrandApplicationContract;
using InventoryApplicationContract.Categores;
using InventoryApplicationContract.ProductContartct;
using InventoryApplicationContract.SubCategoryContract;
using InventoryApplicationContract.UnitCantrat;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HostService.Models
{
    public class productModels
    {
        public  createPorducts  CreatePorducts { get; set; }
        public  Productsedited  dtailsPorducts { get; set; }
        public  productlistview  products { get; set; }
        public SelectList product_list { get; set; }
        public SelectList Unit_list { get; set; }
        public SelectList brnd_view_model { get; set; }
        public SelectList Category_view_model { get; set; }
        public SelectList subCategory_view_model { get; set; }
    }
}
 
