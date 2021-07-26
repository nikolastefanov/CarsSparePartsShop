using CarsSparePartsShop.Models.Categories;
using CarsSparePartsShop.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsSparePartsShop.Controllers
{
    public class CategoriesController:Controller
    {
        private readonly ICategoriesService service;

        public CategoriesController(ICategoriesService service)
        {
            this.service = service;
        }

        public IActionResult AddCategory()
        {
           
            return this.View();
        }




        public IActionResult AllCategory()
        {
            var categories = this.service
                .GetAllCategory()
                .Select(x => new AllCategoryViewModel
                {
                    Id=x.Id,
                    Name=x.Name,
                    ImageUrl=x.ImageUrl,

                }).ToList();

            return View(categories);
        }
  

        public IActionResult EditCategory()
        {
            return this.View();
        }

        public IActionResult DeleteCategory()
        {
            return this.View();
        }
    }
}
