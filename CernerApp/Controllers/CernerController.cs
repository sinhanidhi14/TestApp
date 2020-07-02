using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CernerApp.Controllers
{
    public class CernerController : Controller
    {
        public IActionResult Launch()
        {
            return View();
        }

        public IActionResult Index() 
        {
            return View();
        }

        public IActionResult Health()
        {
            return View();
        }
    }
}
