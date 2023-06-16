using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApplicationContract.SubCategoryContract
{
    public class SubCategoryViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long CubCategorycode { get; set; }
        public long CategoryRef { get; set; }
        public string Categoryname { get; set; }
    }
}
