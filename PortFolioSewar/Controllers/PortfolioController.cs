using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortFolioSewar.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortFolioSewar.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly AppDbContext _context;

        public PortfolioController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Resumes1
        public async Task<IActionResult> Index()
        {
            return View(await _context.Portfolios.ToListAsync());
        }
        //[HttpGet]
        //public  IActionResult Detail()
        //{

        //}

        public IActionResult Portfoliodetails(int id)
        {
            {


                var res = _context.Portfolios.FirstOrDefault(m => m.PortfolioId == id);


                if (res == null)
                {
                    return NotFound();
                }

                return View(res);
            }
        }
    }
}
