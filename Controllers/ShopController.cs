using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MixmartBackEnd.DAL;
using MixmartBackEnd.Models;
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
                Products = await _context.Products.Where(p => p.IsDeleted == false).Include(p => p.ProductCategories).ThenInclude(p => p.Category).ToListAsync(),
                Categories = await _context.Categories.Where(c => c.IsDeleted == false).Include(m => m.ProductCategories).ToListAsync()


            };
            return View(shopVM);
        }

        public async Task<IActionResult> Detail(int? id)
        {


            Product product = await _context.Products.Include(p => p.ProductCategories).ThenInclude(pc => pc.Category).FirstOrDefaultAsync(p => p.Id == id);
            var categoryIds = _context.ProductCategories.Where(pc => pc.ProductId == product.Id).Select(pc => pc.Id);
            ViewBag.Related = _context.Products.Where(p => categoryIds.Contains(p.Id));
            return View(product);
        }
        public IActionResult CategoryProduct(int Id)
        {
            IEnumerable<Product> products = _context.Products.Include(p => p.ProductCategories).ThenInclude(p => p.Category).Include(p => p.ProductTags).ThenInclude(pt => pt.Tag).Where(p => p.ProductCategories.Any(pt => pt.CategoryId == Id)).ToList();
            ViewBag.Categories = _context.Categories.Include(c => c.ProductCategories).ThenInclude(pt => pt.Product).ToList();
            ViewBag.Tags = _context.Tags.Include(t => t.ProductTags).ThenInclude(bt => bt.Product).ToList();
            return View(products);
        }
        public IActionResult TagProduct(int id)
        {
            IEnumerable<Product> products = _context.Products.Include(p => p.ProductCategories).ThenInclude(pt => pt.Category).Include(p => p.ProductTags).ThenInclude(pt => pt.Tag).Where(c => c.ProductTags.Any(pt => pt.TagId == id)).ToList();
            ViewBag.Categories = _context.Categories.Include(c => c.ProductCategories).ThenInclude(pt => pt.Product).ToList();
            ViewBag.Tags = _context.Tags.Include(t => t.ProductTags).ThenInclude(bt => bt.Product).ToList();
            return View(products);
        }
        public async Task<IActionResult> Search(int? id, string search)
        {
            IEnumerable<ProductListVM> products = await _context.Products
     .Where(p => search == null ||
            p.Title.ToLower().Contains(search.ToLower()))
     .OrderByDescending(p => p.Id)
     .Take(3)
     .Select(p => new ProductListVM
     {
         Id = p.Id,
         Title = p.Title,
         Image = p.Image
     })
     .ToListAsync();


            return PartialView("_SearchPartial", products);
        }


    }
}




