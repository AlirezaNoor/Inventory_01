using Microsoft.AspNetCore.Http;

namespace InventoryApplicationContract.BrandApplicationContract;

public class CreateBrand
{
    public string name { get; set; }
    public string descrption { get; set; }
    public IFormFile  imgge { get; set; }
}