using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PortFolioSewar.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PortFolioSewar.Controllers
{
    public class HomeController : Controller
    {
      


        public IActionResult Index()
        {
            return View();
        }

       
    }
}
