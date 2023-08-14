using InventoryApplicationContract.StoreCotracct;
using Microsoft.AspNetCore.Mvc;

namespace HostService.Controllers.Stores
{
    public class store : Controller
    {
        private readonly IStoreApplication _application;

        public store(IStoreApplication application)
        {
            _application = application;
        }

        public IActionResult Index()
        {
            return View(_application.getstores());
        }
        public IActionResult CreateStore()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateStore(CreateStore e)
        {
            _application.Ceaate(e);
            TempData["successMassege"] = "عملیات با موفقیت انجام شد";
            return RedirectToAction("Index");
        }
    }
}
