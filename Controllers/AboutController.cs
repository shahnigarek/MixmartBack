using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MixmartBackEnd.DAL;
using MixmartBackEnd.ViewModels.AboutVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            AboutVM aboutVM = new AboutVM()
            {
                About=await _context.Abouts.Where(a=>a.IsDeleted == false).FirstOrDefaultAsync(),
                Services=await _context.Services.Where(a=>a.IsDeleted == false).ToListAsync(),
                Story=await _context.Stories.Where(a=>a.IsDeleted == false).FirstOrDefaultAsync(),
                Brands=await _context.Brands.Where(a=>a.IsDeleted == false).ToListAsync(),
                Teams=await _context.Teams.Include(t=>t.Position).Where(a=>a.IsDeleted == false).ToListAsync(),

            };
            return View(aboutVM);


        }
    }
}
