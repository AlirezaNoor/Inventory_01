using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework;
using Inventory.Domin.Cities;
using Inventory.Domin.Country;

namespace Inventory.Domin.Costumer
{
    public class Costmers:GolbalGeneric
    {
        public string CustomerName { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public long Countryref { get; private set; }
        public long Cityref { get; private set; }
        public string Address { get; private set; }
        public string Desciption { get; private set; }
        public Countreis Countreis { get; set; }
        public Costmers(string customerName, string email, string phone, long countryref, long cityref, string address, string desciption)
        {
            CustomerName = customerName;
            Email = email;
            Phone = phone;
            Countryref = countryref;
            Cityref = cityref;
            Address = address;
            Desciption = desciption;
        }

        public void Edited(string customerName, string email, string phone, long countryref, long cityref, string address, string desciption)
        {
            CustomerName = customerName;
            Email = email;
            Phone = phone;
            Countryref = countryref;
            Cityref = cityref;
            Address = address;
            Desciption = desciption;
        }
    }
}
