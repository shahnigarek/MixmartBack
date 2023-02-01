using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MixmartBackEnd.DAL;
using MixmartBackEnd.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public  async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM
            {

                Sliders = await _context.Sliders.Where(s => s.IsDeleted == false).ToListAsync(),
                Blogs = await _context.Blogs.Where(b => b.IsDeleted == false ).Include(b=>b.BlogCategories).ThenInclude(b=>b.BCategory).ToListAsync(),
                Blog = await _context.Blogs.Where(b => b.IsDeleted == false).Include(b=>b.BlogCategories).ThenInclude(b=>b.BCategory).FirstOrDefaultAsync(),
                IsBestSeller = await _context.Products.Where(p => p.IsDeleted==false && p.IsBestSeller==true).ToListAsync(),
                IsNewArrival = await _context.Products.Where(p => p.IsDeleted==false && p.IsNewArrival==true).ToListAsync(),
                Ceramics = await _context.Ceramics.Where(c => c.IsDeleted == false).FirstOrDefaultAsync(),
                Crafted= await _context.Crafteds.Where(c=>c.IsDeleted == false).FirstOrDefaultAsync(),
                Instagrams= await _context.Instagrams.Where(i=>i.IsDeleted == false ).ToListAsync(),
                Movements= await _context.Movements.Where(m=>m.IsDeleted == false).ToListAsync()


            };
            return View(homeVM);
        }
    }
}
