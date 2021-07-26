

namespace CarsSparePartsShop.Services
{
    using CarsSparePartsShop.Services.Categories;
    using System.Collections.Generic;
    public interface ICategoriesService
    {
        IEnumerable<AllCategoryModel> GetAllCategory();
    }
}
