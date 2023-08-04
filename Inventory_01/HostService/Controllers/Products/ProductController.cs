using HostService.Models;
using InventoryApplication.Unit;
using InventoryApplicationContract.BrandApplicationContract;
using InventoryApplicationContract.Categores;
using InventoryApplicationContract.ProductContartct;
using InventoryApplicationContract.SubCategoryContract;
using InventoryApplicationContract.UnitCantrat;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HostService.Controllers.Products
{
    public class ProductController : Controller
    {
        private readonly IProdutsApplation _produts;
        private readonly ISubCategoryApplication _subCategory;
        private readonly ICategoresApplictaion _categoresApplictaion;
        private readonly IUnitAplication _aplication;
        private readonly IBrandApplication _brandaplication;

        public ProductController(IProdutsApplation produts, IUnitAplication aplication, ICategoresApplictaion categoresApplictaion, ISubCategoryApplication subCategory, IBrandApplication brandaplication)
        {
            _produts = produts;
            _aplication = aplication;
            _categoresApplictaion = categoresApplictaion;
            _subCategory = subCategory;
            _brandaplication = brandaplication;
        }

        public IActionResult Index()
        {
            var test = _produts.getAll();
            return View(test);
        }
        [HttpGet]
        public IActionResult addproduct()
        {
            var objects = new productModels();
            objects.Category_view_model = new SelectList(_categoresApplictaion.showAll(), "Id", "CategoryName");
            objects.subCategory_view_model = new SelectList(_subCategory.showAll(), "Id", "Name");
            objects.Unit_list = new SelectList(_aplication.getAllUnit(), "id", "name");
            objects.brnd_view_model = new SelectList(_brandaplication.showAll(), "Id", "name");
             return View(objects);
        }
        [HttpPost]
        public IActionResult addproduct(productModels command)
        {
            _produts.create(command.CreatePorducts);
            TempData["successMassege"] = "عملیات با موفقیت انجام شد";

            return RedirectToAction("Index");
        }
}
}
