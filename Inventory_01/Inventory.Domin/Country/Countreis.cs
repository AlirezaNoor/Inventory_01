using Framework;
using Inventory.Domin.Cities;
using Inventory.Domin.Costumer;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Inventory.Domin.Country
{
    public class Countreis:GolbalGeneric
    {
        public string CountryName { get; private set; }
        public string RegionRegion { get; private set; }
        public string Description { get; private set; }

        public List<City> Cities { get; set; }
        public List<Costmers> Costmers { get; set; }
        //CountryName
        //Region
        //    Description
        public Countreis(string countryName, string regionRegion, string description)
        {
            CountryName = countryName;
            RegionRegion = regionRegion;
            Description = description;
        }

        public void Edted(string countryName, string regionRegion, string description)
        {
            CountryName = countryName;
            RegionRegion = regionRegion;
            this.Description = description;
        }

    }

}
