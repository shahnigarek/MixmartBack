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
    public class InstagramController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public InstagramController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Instagram> instagrams = await _context.Instagrams.Where(i => i.IsDeleted == false).ToListAsync();
            return View(instagrams);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Instagram instagram)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            if (instagram.File == null)
            {
                ModelState.AddModelError("File", "It is important add image");
                return View(instagram);
            }

            if (instagram.File.CheckFileSize(2200) == false)
            {
                ModelState.AddModelError("File", "File's size is bigger than required");
                return View(instagram);
            }

            if (instagram.File.CheckFileType("image/jpeg") == false)
            {
                ModelState.AddModelError("File", "Format of image is wrong");
                return View(instagram);
            }


            instagram.Image = instagram.File.CreateImage(_env, "assets", "images", "index", "instagram");
            await _context.Instagrams.AddAsync(instagram);
            instagram.IsDeleted = false;
            instagram.CreatedAt = DateTime.UtcNow.AddHours(4);
            instagram.CreatedBy = "System";


            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return BadRequest("Id can't be null");
            }

            Instagram instagram = await _context.Instagrams.FirstOrDefaultAsync(i => i.IsDeleted == false && i.Id == id);

            if (instagram == null)
            {
                return NotFound("Id is wrong");
            }

            return View(instagram);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Instagram instagram, int? id)
        {


            if (!ModelState.IsValid)
            {
                return View(instagram);
            }
            if (id == null)
            {
                return BadRequest("Id can't be null");
            }

            if (instagram.Id != id)
            {
                return BadRequest("Id must be equal");
            }


            Instagram existedinstagram = await _context.Instagrams.FirstOrDefaultAsync(i => i.IsDeleted == false && i.Id == id);

            if (existedinstagram == null)
            {
                return NotFound("Id is wrong");
            }
            if (instagram.File == null)
            {
                ModelState.AddModelError("File", "It is important add image");
                return View(instagram);
            }

            if (instagram.File.CheckFileSize(10000) == false)
            {
                ModelState.AddModelError("File", "File's size is bigger than required");
                return View(instagram);
            }

            if ((instagram.File.CheckFileType("image/jpeg")) == false)
            {
                ModelState.AddModelError("File", "Format of image is wrong");
                return View(instagram);
            }


            existedinstagram.UpdatedAt = DateTime.UtcNow.AddHours(4);
            existedinstagram.UpdatedBy = "System";
            existedinstagram.Image = instagram.File.CreateImage(_env, "assets", "images", "index", "instagram");
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

            Instagram instagram = await _context.Instagrams.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (instagram == null)
            {
                return NotFound("no data");
            }

            instagram.IsDeleted = true;
            instagram.DeletedBy = "";
            instagram.DeletedAt = DateTime.UtcNow.AddHours(4);

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }




    }
}
