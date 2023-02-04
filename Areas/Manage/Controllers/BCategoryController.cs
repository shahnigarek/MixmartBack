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
    public class BCategoryController : Controller
    {
        private readonly AppDbContext _context;
        public BCategoryController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {

            IEnumerable<BCategory> bcategories = await _context.BCategories.Where(c => c.IsDeleted == false).ToListAsync();

            return View(bcategories);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(BCategory bcategory)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (bcategory.Name == null)
            {
                ModelState.AddModelError("Name", $"This name = {bcategory.Name} doesn't exists ");
                return View(bcategory);

            }
            if (await _context.BCategories.AnyAsync(bc => bc.IsDeleted == false && bc.Name.ToLower() == bcategory.Name.ToLower().Trim()))
            {
                ModelState.AddModelError("Name", $"This name = {bcategory.Name} already exists ");
                return View(bcategory);
            }



            bcategory.Name = bcategory.Name.Trim();
            bcategory.IsDeleted = false;
            bcategory.CreatedAt = DateTime.UtcNow.AddHours(4);
            bcategory.CreatedBy = "System";
            await _context.BCategories.AddAsync(bcategory);
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

            BCategory bcategory = await _context.BCategories.FirstOrDefaultAsync(bc => bc.IsDeleted == false && bc.Id == id);

            if (bcategory == null)
            {
                return NotFound("Id is wrong");
            }

            return View(bcategory);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(BCategory bcategory, int? id)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (id == null)
            {
                return BadRequest("Id can't be null");
            }
            if (bcategory.Name == null)
            {
                ModelState.AddModelError("Name", $"name can't be null ");
                return View(bcategory);
            }


            if (bcategory.Id != id)
            {
                return BadRequest("Id must be equal");
            }
            if (await _context.BCategories.AnyAsync(bc => bc.IsDeleted == false && bc.Name.ToLower() == bcategory.Name.ToLower().Trim() && bc.Id != id))
            {
                ModelState.AddModelError("Name", $"This name = {bcategory.Name} already exists ");
                return View(bcategory);
            }


            BCategory existedbcategory = await _context.BCategories.FirstOrDefaultAsync(bc => bc.IsDeleted == false && bc.Id == id);

            if (existedbcategory == null)
            {
                return NotFound("Id is wrong");
            }
            if (existedbcategory.Name == bcategory.Name)
            {
                ModelState.AddModelError("Name", $"This name = {bcategory.Name} already exists ");
                return View(bcategory);
            }

            existedbcategory.Name = bcategory.Name.Trim();
            existedbcategory.UpdatedAt = DateTime.UtcNow.AddHours(4);
            existedbcategory.UpdatedBy = "System";
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

            BCategory bcategory = await _context.BCategories
                .FirstOrDefaultAsync(bc => bc.IsDeleted == false && bc.Id == id);

            if (bcategory == null)
            {
                return NotFound("Id is wrong");
            }


            bcategory.IsDeleted = true;
            bcategory.DeletedBy = "";
            bcategory.DeletedAt = DateTime.UtcNow.AddHours(4);


            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}
