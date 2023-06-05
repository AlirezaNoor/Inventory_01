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
    }
}
