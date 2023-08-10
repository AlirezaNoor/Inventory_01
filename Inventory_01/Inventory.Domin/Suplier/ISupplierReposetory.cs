using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Domin.Suplier;
using Invetory01.Infrastructure.GnericReposetory;

namespace Inventory.Domin.Supliers
{
    public interface ISupplierReposetory:IGenericReposetores<Supplier,long>
    {
    }
}
