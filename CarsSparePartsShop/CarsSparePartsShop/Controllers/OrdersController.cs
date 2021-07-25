using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsSparePartsShop.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult CreateOrder()
        {
            return this.View();
        }

        public IActionResult AllOrder()
        {
            return this.View();
        }

        public IActionResult EditOrder()
        {
            return this.View();
        }

        public IActionResult DeleteOrder()
        {
            return this.View();
        }
    }
}
