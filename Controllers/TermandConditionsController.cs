using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MixmartBackEnd.DAL;
using MixmartBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Controllers
{
    public class TermandConditionsController : Controller
    {
        private readonly AppDbContext _context;
        public TermandConditionsController(AppDbContext context)
        {
            _context = context;
        }
        public async Task< IActionResult> Index()
        {
            IEnumerable<TermandCondition> termandConditions = await _context.TermandConditions.Where(tc => tc.IsDeleted == false).ToListAsync();
            return View(termandConditions);
        }
    }
}
