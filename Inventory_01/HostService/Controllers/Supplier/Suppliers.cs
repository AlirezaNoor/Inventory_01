using InventoryApplicationContract.Cities;
using InventoryApplicationContract.Countries;
using InventoryApplicationContract.Supplier;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HostService.Controllers.Supplier
{
    public class Suppliers : Controller
    {
        private readonly ISupplierApplicaation _supplier;
        private readonly IApplicationCountries _countries;
        private readonly ICitiesApplaiction _city;

        public Suppliers(ISupplierApplicaation supplier, IApplicationCountries countries, ICitiesApplaiction city)
        {
            _supplier = supplier;
            _countries = countries;
            _city = city;
        }

        public IActionResult Index()
        {
            return View(_supplier.getall());
        }


        public IActionResult createSupplier()
        {
            CreateSupplier create = new();
            create.cities = new SelectList(_city.getall(), "id", "Name");
            create.couneries = new SelectList(_countries.getcountries(), "Id", "CountryName");
            return View(create);
        }
        [HttpPost]
        public IActionResult createSupplier(CreateSupplier command)
        {
            _supplier.createsupp(command);
            TempData["successMassege"] = "عملیات با موفقیت انجام شد";
            CreateSupplier create =new();
            return RedirectToAction("Index");

        }

    }

}
