using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MixmartBackEnd.DAL;
using MixmartBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Areas.Manage.Controllers
{
    [Area("manage")]
    [Authorize(Roles = "Admin")]

    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;
        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {

            IEnumerable<Category> categories = await _context.Categories.Where(c => c.IsDeleted == false).ToListAsync();

            return View(categories);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (category.Name == null)
            {
                ModelState.AddModelError("Name", $"This name = {category.Name} doesn't exists ");
                return View();

            }
            if (await _context.Categories.AnyAsync(c => c.IsDeleted == false && c.Name.ToLower() == category.Name.ToLower().Trim()))
            {
                ModelState.AddModelError("Name", $"This name = {category.Name} already exists ");
                return View(category);
            }



            category.Name = category.Name.Trim();
            category.IsDeleted = false;
            category.CreatedAt = DateTime.UtcNow.AddHours(4);
            category.CreatedBy = "System";
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return BadRequest("Id can't be null");
            }

            Category category = await _context.Categories.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (category == null)
            {
                return NotFound("Id is wrong");
            }

            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(Category category, int? id)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (id == null)
            {
                return BadRequest("Id can't be null");
            }
            if (category.Name == null)
            {
                ModelState.AddModelError("Name", $"name can't be null ");
                return View(category);
            }


            if (category.Id != id)
            {
                return BadRequest("Id must be equal");
            }
            if (await _context.Categories.AnyAsync(c => c.IsDeleted == false && c.Name.ToLower() == category.Name.ToLower().Trim() && c.Id != id))
            {
                ModelState.AddModelError("Name", $"This name = {category.Name} already exists ");
                return View(category);
            }


            Category existedcategory = await _context.Categories.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (existedcategory == null)
            {
                return NotFound("Id is wrong");
            }
            if (existedcategory.Name == category.Name)
            {
                ModelState.AddModelError("Name", $"This name = {category.Name} already exists ");
                return View(category);
            }

            existedcategory.Name = category.Name.Trim();
            existedcategory.UpdatedAt = DateTime.UtcNow.AddHours(4);
            existedcategory.UpdatedBy = "System";
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest("Id can't be null");
            }

            Category category = await _context.Categories
                .FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (category == null)
            {
                return NotFound("Id is wrong");
            }


            category.IsDeleted = true;
            category.DeletedBy = "";
            category.DeletedAt = DateTime.UtcNow.AddHours(4);


            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}
