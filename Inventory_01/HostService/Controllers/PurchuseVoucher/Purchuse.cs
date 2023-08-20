using Microsoft.AspNetCore.Mvc;

namespace HostService.Controllers.PurchuseVoucher
{
    public class Purchuse : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
