using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortFolioSewar.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortFolioSewar.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
     
        public AboutController (AppDbContext context)
        {
            _context = context;
        }
  
        public IActionResult Index()
        {
            return View (_context.Owners.ToList()) ;
        }
    }
}
