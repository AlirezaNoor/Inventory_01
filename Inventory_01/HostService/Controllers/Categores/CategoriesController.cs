using InventoryApplicationContract.Categores;
using Microsoft.AspNetCore.Mvc;

namespace HostService.Controllers.Categores
{
    public class CategoresController : Controller
    {
        private readonly ICategoresApplictaion _applictaion;

        public CategoresController(ICategoresApplictaion applictaion)
        {
            _applictaion = applictaion;
        }

        public IActionResult Index()
        {
            return View(_applictaion.showAll().ToList());
        }

        [HttpGet]
        public IActionResult CreateCategories()
        {
            return View();
        }


        [HttpPost]
        public IActionResult CreateCategories(CreateCategores command)
        {
            _applictaion.create(command);

            ViewBag.Message = String.Format("عملیات با موفقیت انجام شد");
            TempData["successMassege"] = "عملیات با موفقیت انجام شد";
            return RedirectToAction("Index");
        }


        public ActionResult DeleteCategory(long Id)
        {
            _applictaion.remove(Id);
            TempData["successMassege"] = "عملیات با موفقیت انجام شد";
            return RedirectToAction("Index");
        }

        public IActionResult Editecategorey(long id)
        {
            var test = _applictaion.edited(id);
            return View(test);
        }

        [HttpPost]
        public IActionResult Editecategorey(EditCategores command)
        {
            _applictaion.EditedRecordes(command);
            TempData["successMassege"] = "عملیات با موفقیت انجام شد";
            return RedirectToAction("Index");
        }
    }
}
