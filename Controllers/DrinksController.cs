using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filipan_Dănuț_Proiect.Controllers
{
    public class DrinkSController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
