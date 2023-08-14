using InventoryApplicationContract.Addedproductstostore;
using InventoryApplicationContract.BrandApplicationContract;
using InventoryApplicationContract.Categores;
using InventoryApplicationContract.ProductContartct;
using InventoryApplicationContract.StoreCotracct;
using InventoryApplicationContract.SubCategoryContract;
using InventoryApplicationContract.UnitCantrat;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HostService.Controllers.Addproduct_to_store
{
    public class ProductsToStore : Controller
    {
        private readonly IAddProductToStoreApp _AddPtS;
        private readonly IProdutsApplation _produts;
        private readonly IStoreApplication _store;
        public ProductsToStore(IAddProductToStoreApp addPtS, IStoreApplication store, IProdutsApplation produts)
        {
            _AddPtS = addPtS;
            _store = store;
            _produts = produts;
        }

        public IActionResult Index()
        {
            return View(_AddPtS.getall());
        }

        public IActionResult Create()
        {

            CreateAddPtoS addPto = new CreateAddPtoS();
            addPto.Product = new SelectList(_produts.selectdtaiils(), "Id", "name");
            addPto.Store = new SelectList(_store.getstores(), "Id", "StoreName");
            return View(addPto);

        }
        [HttpPost]
        public IActionResult Create(CreateAddPtoS addPto)
        {
            _AddPtS.Create(addPto);
            TempData["successMassege"] = "عملیات با موفقیت انجام شد";
            return RedirectToAction("Index");
        }
    }
}
