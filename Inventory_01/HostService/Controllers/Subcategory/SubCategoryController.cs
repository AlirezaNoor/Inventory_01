using InventoryApplicationContract.Categores;
using InventoryApplicationContract.SubCategoryContract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace HostService.Controllers.Subcategory
{
    public class SubCategoryController : Controller
    {

        private readonly ISubCategoryApplication _subCategoryApplication;
        private readonly ICategoresApplictaion _categoresApplictaion;

        public SubCategoryController(ISubCategoryApplication subCategoryApplication, ICategoresApplictaion categoresApplictaion)
        {
            _subCategoryApplication = subCategoryApplication;
            _categoresApplictaion = categoresApplictaion;
        }

        public IActionResult Index()
        {
          var show=  _subCategoryApplication.showAll();
            return View(show);
        }

        public IActionResult CreateSubCategory()
        {
            var created = new CreateSubCategory();
            var test = new SelectList(_categoresApplictaion.categoryseletor(), "Id", "CategoryName");
            created.select = test.ToList();
            return View(created);
        }
        [HttpPost]
        public IActionResult CreateSubCategory(CreateSubCategory command)
        {
            _subCategoryApplication.createsubcategory(command);
            TempData["successMassege"] = "عملیات با موفقیت انجام شد";
            return RedirectToAction("Index");
        }
    }
}
