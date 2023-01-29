using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MixmartBackEnd.DAL;
using MixmartBackEnd.ViewModels.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;
        public ShopController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            ShopVM shopVM = new ShopVM
            {

                Tags = await _context.Tags.Where(s => s.IsDeleted == false).ToListAsync(),
                Categories = await _context.Categories.Where(b => b.IsDeleted == false).ToListAsync(),
                Products = await _context.Products.Where(m => m.IsDeleted == false).ToListAsync()


            };
            return View(shopVM);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            ShopVM shopVM = new ShopVM
            {

                Categories = await _context.Categories.Where(c => c.IsDeleted == false).ToListAsync(),
                Products = await _context.Products.Where(p => p.IsDeleted == false && p.Id == id).ToListAsync(),
                Product=await _context.Products.Where(p => p.IsDeleted == false && p.Id == id).FirstOrDefaultAsync()


            };
            return View(shopVM);

        }
    }
}
