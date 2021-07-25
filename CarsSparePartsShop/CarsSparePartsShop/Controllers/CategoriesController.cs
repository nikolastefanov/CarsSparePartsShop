using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsSparePartsShop.Controllers
{
    public class CategoriesController:Controller
    {
        public IActionResult AddCategory()
        {
            return this.View();
        }

        public IActionResult AllCategory()
        {
            return this.View();
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
