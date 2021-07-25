using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsSparePartsShop.Controllers
{
    public class CommentsController : Controller
    {
        public IActionResult CreateComment()
        {
            return this.View();
        }

        public IActionResult AllComment()
        {
            return this.View();
        }

        public IActionResult EditComment()
        {
            return this.View();
        }

        public IActionResult DeleteComment()
        {
            return this.View();
        }
    }
}
