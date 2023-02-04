using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MixmartBackEnd.DAL;
using MixmartBackEnd.Extention;
using MixmartBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Areas.Manage.Controllers
{
    [Area("manage")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public ProductController(AppDbContext context,IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Product> products = await _context.Products
                .Include(p=>p.ProductCategories).ThenInclude(pc=>pc.Category)
                .Include(p => p.ProductTags).ThenInclude(pt => pt.Tag)
                .Where(p => p.IsDeleted == false)
                .ToListAsync();

            return View(products);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Categories = await _context.Categories.Where(c => c.IsDeleted == false).ToListAsync();
            ViewBag.Tags = await _context.Tags.Where(c => c.IsDeleted == false).ToListAsync();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product)
        {
            ViewBag.Categories = await _context.Categories.Where(c => c.IsDeleted == false).ToListAsync();
            ViewBag.Tags = await _context.Tags.Where(c => c.IsDeleted == false).ToListAsync();

            if (!ModelState.IsValid)
            {
                return View(product);
            }
            if (product.Title == null)
            {
                ModelState.AddModelError("Title", "It is important add Title  it can't be empty");
                return View(product);
            }
            
            if (await _context.Products.AnyAsync(p => p.IsDeleted == false && p.Title.ToLower() == product.Title.ToLower().Trim()))
            {
                ModelState.AddModelError("Title", $"This title = {product.Title} already exists ");
                return View(product);
            }

            if (product.File == null)
            {
                ModelState.AddModelError("File", "It is important add image");
                return View(product);
            }

            if (product.File.CheckFileSize(2200) == false)
            {
                ModelState.AddModelError("File", "File's size is bigger than required");
                return View(product);
            }

            if (product.File.CheckFileType("image/jpeg") == false)
            {
                ModelState.AddModelError("File", "Format of image is wrong");
                return View(product);
            }

            List<ProductTag> productTags = new List<ProductTag>();
            List<ProductCategory> productCategories = new List<ProductCategory>();

            foreach (int tagId in product.TagIds)
            {
                if (product.TagIds.Where(t => t == tagId).Count() > 1)
                {
                    ModelState.AddModelError("TagIds", "Bir Tagdan Bir Ddefe Secilmelidir");
                    return View(product);
                }

                if (!await _context.Tags.AnyAsync(c => c.IsDeleted == false && c.Id == tagId))
                {
                    ModelState.AddModelError("TagIds", "Secilen Tag  Yanlisdir");
                    return View(product);
                }

                ProductTag productTag = new ProductTag
                {
                    CreatedAt = DateTime.UtcNow.AddHours(+4),
                    CreatedBy = "System",
                    IsDeleted = false,
                    TagId = tagId
                };

                productTags.Add(productTag);
            }

            foreach (int categoryId in product.CategoryIds)
            {
                

                if (!await _context.Categories.AnyAsync(c => c.IsDeleted == false && c.Id == categoryId))
                {
                    ModelState.AddModelError("CategoryIds", "Choosen Category is wrong");
                    return View(product);
                }

                ProductCategory productCategory = new ProductCategory
                {
                    CreatedAt = DateTime.UtcNow.AddHours(+4),
                    CreatedBy = "System",
                    IsDeleted = false,
                    CategoryId = categoryId
                };

                productCategories.Add(productCategory);
            }
            product.Image = product.File.CreateImage(_env, "assets", "images", "index","shop");

            product.ProductTags = productTags;
            product.ProductCategories = productCategories;
            product.Title = product.Title;
            product.Description1 = product.Description1;
            product.Description2 = product.Description2;
            product.Description3 = product.Description3;

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            Product product = await _context.Products.FirstOrDefaultAsync(p => p.IsDeleted == false && p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            product.TagIds = await _context.ProductTags.Where(pt => pt.ProductId == id).Select(x => x.TagId).ToListAsync();
            product.CategoryIds = await _context.ProductCategories.Where(pc => pc.ProductId == id).Select(x => x.CategoryId).ToListAsync();

            ViewBag.Categories = await _context.Categories.Where(c => c.IsDeleted == false).ToListAsync();
            ViewBag.Tags = await _context.Tags.Where(c => c.IsDeleted == false).ToListAsync();

            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Product product)
        {
            ViewBag.Categories = await _context.Categories.Where(c => c.IsDeleted == false).ToListAsync();
            ViewBag.Tags = await _context.Tags.Where(c => c.IsDeleted == false).ToListAsync();

            if (!ModelState.IsValid)
            {
                return View(product);
            }
            if (product.Title == null)
            {
                ModelState.AddModelError("Title", "It is important add Title  it can't be empty");
                return View(product);
            }

            if (await _context.Products.AnyAsync(p => p.IsDeleted == false && p.Title.ToLower() == product.Title.ToLower().Trim()))
            {
                ModelState.AddModelError("Title", $"This title = {product.Title} already exists ");
                return View(product);
            }

           


            Product existedProduct = await _context.Products.Include(c => c.ProductTags).Include(c=>c.ProductCategories).FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            _context.ProductTags.RemoveRange(existedProduct.ProductTags);
            _context.ProductCategories.RemoveRange(existedProduct.ProductCategories);

            List<ProductTag> productTags = new List<ProductTag>();
            List<ProductCategory> productCategories = new List<ProductCategory>();
            foreach (int tagId in product.TagIds)
            {
               
                if (!await _context.Tags.AnyAsync(c => c.IsDeleted == false && c.Id == tagId))
                {
                    ModelState.AddModelError("TagIds", "Secilen Tag  Yanlisdir");
                    return View(product);
                }

                ProductTag productTag = new ProductTag
                {
                    UpdatedAt = DateTime.UtcNow.AddHours(+4),
                    UpdatedBy = "System",
                    IsDeleted = false,
                    TagId = tagId
                };

                productTags.Add(productTag);
            }

            foreach (int categoryId in product.CategoryIds)
            {
               

                if (!await _context.Categories.AnyAsync(c => c.IsDeleted == false && c.Id == categoryId))
                {
                    ModelState.AddModelError("CategoryIds", "Choosen Catgeory is wrong");
                    return View(product);
                }

                ProductCategory productCategory = new ProductCategory
                {
                    UpdatedAt = DateTime.UtcNow.AddHours(+4),
                    UpdatedBy = "System",
                    IsDeleted = false,
                    CategoryId = categoryId
                };

                productCategories.Add(productCategory);
            }
            if (product.File == null)
            {
                ModelState.AddModelError("File", "It is important add image");
                return View(product);
            }

            if (product.File.CheckFileSize(2200) == false)
            {
                ModelState.AddModelError("File", "File's size is bigger than required");
                return View(product);
            }

            if (product.File.CheckFileType("image/jpeg") == false)
            {
                ModelState.AddModelError("File", "Format of image is wrong");
                return View(product);
            }
            existedProduct.Image = product.File.CreateImage(_env, "assets", "images", "index", "shop");
            existedProduct.Title = product.Title;
            existedProduct.Description1 = product.Description1.Trim();
            existedProduct.Description2 = product.Description2.Trim();
            existedProduct.Description3 = product.Description3;
            existedProduct.DiscountedPrice = product.DiscountedPrice;
            existedProduct.EnvelopeUrl = product.EnvelopeUrl;
            existedProduct.FacebookUrl = product.FacebookUrl;
            existedProduct.GooglePlusUrl = product.GooglePlusUrl;
            existedProduct.LinkedinUrl = product.LinkedinUrl;
            existedProduct.PinterestUrl = product.PinterestUrl;
            existedProduct.Price = product.Price;
            existedProduct.IsBestSeller = product.IsBestSeller;
            existedProduct.IsNewArrival = product.IsNewArrival;
            existedProduct.TumblrUrl = product.TumblrUrl;
            existedProduct.TwitterUrl = product.TwitterUrl;
            existedProduct.ProductTags = productTags;
            existedProduct.ProductCategories = productCategories;

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest("Id can't be null");
            }

            Product product = await _context.Products
                .Include(p=>p.ProductCategories).ThenInclude(pc=>pc.Category)
                .Include(c => c.ProductTags).ThenInclude(c => c.Tag)
                .FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (product == null)
            {
                return NotFound("no data");
            }



            product.IsDeleted = true;
            product.DeletedBy = "";
            product.DeletedAt = DateTime.UtcNow.AddHours(4);

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return BadRequest("Id can't be null");
            }

            ViewBag.Categories = await _context.Categories.Where(c => c.IsDeleted == false).ToListAsync();
            ViewBag.Tags = await _context.Tags.Where(t => t.IsDeleted == false).ToListAsync();
            Product product = await _context.Products
                .Include(c=>c.ProductCategories).ThenInclude(c=>c.Category)
                .Include(c => c.ProductTags).ThenInclude(c => c.Tag)
                .FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (product == null)
            {
                return NotFound("Id is wrong");
            }

            return View(product);
        }
    }
}
