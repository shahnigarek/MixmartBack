using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MixmartBackEnd.DAL;
using MixmartBackEnd.Models;
using MixmartBackEnd.ViewModels.SupportPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Controllers
{
    public class SupportPageController : Controller
    {
        private readonly AppDbContext _context;
        public SupportPageController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            SupportVM supportVM = new SupportVM
            {

                Supports = await _context.Supports.Where(s => s.IsDeleted == false).ToListAsync(),
                Featureds = await _context.Featureds.Where(s => s.IsDeleted == false).ToListAsync()
            };
            return View(supportVM);
        }

    }

}


