using System.Security.Cryptography.Xml;
using Inventory.Domin.Cities;
using Inventory.Domin.Costumer;
using Inventory.Domin.Country;
using InventoryApplicationContract.Costumer;

namespace InventoryApplication.Costumer
{
    public class CostumerAppliation: ICostumerAppliation
    {
        private readonly ICostumerReposetory _reposetory;
        private readonly ICountriesReposetory _countries;
        private readonly ICitiesReposetory _city;


        public CostumerAppliation(ICostumerReposetory reposetory, ICountriesReposetory countries, ICitiesReposetory city)
        {
            _reposetory = reposetory;
            _countries = countries;
            _city = city;
        }

        public void create(CreateCostumer e)
        {
            var costumer = new Costmers(e.CustomerName,e.Email,e.Phone,e.Countryref,e.Cityref,e.Address,e.Desciption);
            _reposetory.Insert(costumer);
            _reposetory.Save();
        }

        public EditCostomer getdtials(long id)
        {

            var x = _reposetory.GetById(id);
            return new EditCostomer()
            {
             Id   = x.Id,
             Countryref = x.Countryref,
             Cityref = x.Cityref,
             Address = x.Address,
             Desciption = x.Desciption,
             CustomerName = x.CustomerName,
             Email = x.Email,
             Phone = x.Phone,
             
            };
        }

        public void saverecoredchange(EditCostomer e)
        {
            var x = _reposetory.GetById(e.Id);
            x.Edited(e.CustomerName, e.Email, e.Phone, e.Countryref, e.Cityref, e.Address, e.Desciption);
            _reposetory.Save();
        }

        public List<Costmerview> getall()
        {
            return _reposetory.GetAll().Select(x => new Costmerview()
            {
                Id = x.Id,
                Countryref = coutry(x.Countryref),
                Cityref = ccity(x.Cityref),
                CustomerName = x.CustomerName,
                Email = x.Email,
                Phone = x.Phone,

            } ).ToList();
        }

        public string coutry(long id)
        {
            return _countries.GetById(id).CountryName;
        }
        public string ccity(long id)
        {
            return _city.GetById(id).Name;
        }

    }
}
