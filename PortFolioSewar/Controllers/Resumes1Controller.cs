using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PortFolioSewar.Data;
using PortFolioSewar.Models;

namespace PortFolioSewar.Controllers
{
    public class Resumes1Controller : Controller
    {
        private readonly AppDbContext _context;

        public Resumes1Controller(AppDbContext context)
        {
            _context = context;
        }

        // GET: Resumes1
        public async Task<IActionResult> Index()
        {
            return View(await _context.Resumes.ToListAsync());
        }

        // GET: Resumes1/Details/5
      
    }
}
