using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Domin.Cities;
using Inventory.Domin.Country;
using Inventory.Domin.Suplier;
using Inventory.Domin.Supliers;
using InventoryApplicationContract.Supplier;

namespace InventoryApplication.SupplierApp
{
    public class SupplierApplication:ISupplierApplicaation
    {
        private readonly ISupplierReposetory _supplier;
        private readonly ICitiesReposetory _cities;
        private readonly ICountriesReposetory _countries;

        public SupplierApplication(ISupplierReposetory supplier, ICitiesReposetory cities, ICountriesReposetory countries)
        {
            _supplier = supplier;
            _cities = cities;
            _countries = countries;
        }

        public void createsupp(CreateSupplier e)
        {
           var sup =  new Supplier(e.SupplierName, e.Email, e.counteryref, e.Cityref, e.phone,
                e.Addresss, e.Description);
            _supplier.Insert(sup);
            _supplier.Save();
        }

        public Editedsupplier getdtails(long id)
        {

            var x = _supplier.GetById(id);
            return new Editedsupplier()
            {
                Addresss = x.Addresss,
                Description = x.Description,
                Cityref = x.Cityref,
                Email = x.Email,
                Id = x.Id,
                SupplierName = x.SupplierName,
                counteryref = x.counteryref,
                phone = x.phone,
                
            };
        }

        public void saveeditchanges(Editedsupplier e)
        {
            var sup = _supplier.GetById(e.Id);
            sup.EditedSupplierr(e.SupplierName, e.Email, e.counteryref, e.Cityref, e.phone,
                e.Addresss, e.Description);
            _supplier.Save();
        }

        public List<supplierViewModel> getall()
        {
            return _supplier.GetAll().Select(x => new supplierViewModel()
            {
                Email = x.Email,
                Id = x.Id,
                phone = x.phone,
                SupplierName = x.SupplierName,
                counteryref = _countries.GetById(x.counteryref).CountryName,
            }).ToList();

        }
    }
}
