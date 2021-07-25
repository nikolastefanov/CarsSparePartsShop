using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsSparePartsShop.Controllers
{
    public class PartsController :Controller
    {
        public IActionResult AddPart()
        {
            return this.View();
        }

        public IActionResult AllPart()
        {
            return this.View();
        }

        public IActionResult EditPart()
        {
            return this.View();
        }

        public IActionResult DeletePart()
        {
            return this.View();
        }
    }
}
