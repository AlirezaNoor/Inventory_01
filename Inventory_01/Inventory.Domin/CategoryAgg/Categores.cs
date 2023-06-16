using Framework;
using Inventory.Domin.SubCategory;

namespace Inventory.Domin.CategoryAgg
{
    public class Categores:GolbalGeneric
    {
        public string CategoryName { get; private set; }
        public long CategoryCode { get; private set; }
        public string Descirption { get; private set; }
        public List<SubCategories> SubCategories { get; private set; }


        public Categores(string categoryName, long categoryCode, string descirption)
        {
            CategoryName = categoryName;
            CategoryCode = categoryCode;
            Descirption = descirption;
        }

        public void EditCategores(string categoryName, long categoryCode, string descirption)
        {
            CategoryName = categoryName;
            CategoryCode = categoryCode;
            Descirption = descirption;
        }
    }
}
