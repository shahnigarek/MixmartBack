using Microsoft.AspNetCore.Authorization;
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
    [Authorize(Roles = "Admin")]

    public class BrandController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public BrandController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Brand> brands = await _context.Brands.Where(i => i.IsDeleted == false).ToListAsync();
            return View(brands);
        }

   
        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return BadRequest("Id can't be null");
            }

            Brand brand = await _context.Brands.FirstOrDefaultAsync(b => b.IsDeleted == false && b.Id == id);

            if (brand == null)
            {
                return NotFound("Id is wrong");
            }

            return View(brand);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Brand brand, int? id)
        {


            if (!ModelState.IsValid)
            {
                return View();
            }
            if (id == null)
            {
                return BadRequest("Id can't be null");
            }

            if (brand.Id != id)
            {
                return BadRequest("Id must be equal");
            }


            Brand existedbrand = await _context.Brands.FirstOrDefaultAsync(b => b.IsDeleted == false && b.Id == id);

            if (existedbrand == null)
            {
                return NotFound("Id is wrong");
            }
            if (brand.File == null)
            {
                ModelState.AddModelError("File", "It is important add image");
                return View(brand);
            }

            if (brand.File.CheckFileSize(10000) == false)
            {
                ModelState.AddModelError("File", "File's size is bigger than required");
                return View(brand);
            }

            if ((brand.File.CheckFileType("image/jpeg")) == false)
            {
                ModelState.AddModelError("File", "Format of image is wrong");
                return View(brand);
            }


            existedbrand.UpdatedAt = DateTime.UtcNow.AddHours(4);
            existedbrand.UpdatedBy = "System";
            existedbrand.Image = brand.File.CreateImage(_env, "assets", "images", "index", "brand");
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

            Brand brand = await _context.Brands.FirstOrDefaultAsync(b => b.IsDeleted == false && b.Id == id);

            if (brand == null)
            {
                return NotFound("no data");
            }

            brand.IsDeleted = true;
            brand.DeletedBy = "";
            brand.DeletedAt = DateTime.UtcNow.AddHours(4);

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }




    }
}
