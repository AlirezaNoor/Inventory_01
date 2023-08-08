using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework;
using Inventory.Domin.Costumer;
using Inventory.Domin.Country;

namespace Inventory.Domin.Cities
{
    public class City:GolbalGeneric
    {
        public string Name { get; private set; }
        public long Countryref { get; private set; }
        public string Description { get; private set; }
        public Countreis Countreis { get; set; }

        public City(string name, long countryref, string description)
        {
            Name = name;
            Countryref = countryref;
            Description = description;
        }

        public void EditedCity(string name, long countryref, string description)
        {
            Name = name;
            Countryref = countryref;
            Description = description;
        }
    }

}
