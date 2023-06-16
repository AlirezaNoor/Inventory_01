using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework;
using Inventory.Domin.CategoryAgg;

namespace Inventory.Domin.SubCategory
{
    public class SubCategories : GolbalGeneric
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public long CubCategorycode { get; private set; }
        public long CategoryRef { get; private set; }
        public Categores Category { get; private set; }

        protected SubCategories(Categores category)
        {
            Category = category;
        }

        public SubCategories(string name, string description, long cubCategorycode, long categoryRef)
        {
            Name = name;
            Description = description;
            CubCategorycode = cubCategorycode;
            CategoryRef = categoryRef;
        }

        public void EditedSubCategory(string name, string description, long cubCategorycode, long categoryRef)
        {
            Name = name;
            Description = description;
            CubCategorycode = cubCategorycode;
            CategoryRef = categoryRef;
        }
    }

}
