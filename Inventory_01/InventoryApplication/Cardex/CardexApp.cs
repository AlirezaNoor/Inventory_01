using InventoryApplicationContract.Cardex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Domin.Cardex;

namespace InventoryApplication.Cardex
{
    public class CardexApp: ICardexApp
    {
        private readonly ICardexReposetory _reposetory;

        public CardexApp(ICardexReposetory reposetory)
        {
            _reposetory = reposetory;
        }

        public void createCardex(CreateCardex cardex)
        {

            List<Cardexes> mycardex = new();

            foreach (var x in mycardex )
            {
                mycardex.Add(new Cardexes(x.storeref,x.propductsref,x.transactiondate,x.vorodkhoroj,x.Quantity));
            }
            _reposetory.Create(mycardex);
            _reposetory.Save();
        }
    }
}
