

namespace CarsSparePartsShop.Services
{
    using CarsSparePartsShop.Data;
    using CarsSparePartsShop.Services.Categories;
    using System.Collections.Generic;
    using System.Linq;


    public class CategoriesService : ICategoriesService
    {
        private readonly ApplicationDbContext data;

        public CategoriesService(ApplicationDbContext data)
        {
            this.data = data;
        }
        public IEnumerable<AllCategoryModel> GetAllCategory()
        {
            var category = this.data.Categories
                    .Select(x => new AllCategoryModel
                    {
                        Id = x.Id,
                        Name = x.Name,
                        ImageUrl = x.ImageUrl,
                    })
                    .ToList();

            return category;
        }
    }
}
