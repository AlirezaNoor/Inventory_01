using Microsoft.AspNetCore.Mvc.Rendering;



namespace InventoryApplicationContract.SubCategoryContract;

public class CreateSubCategory
{
    public string Name { get; set; }
    public string Description { get; set; }
    public long CubCategorycode { get; set; }
    public long CategoryRef { get; set; }

    public List<SelectListItem> select { get; set; }
}