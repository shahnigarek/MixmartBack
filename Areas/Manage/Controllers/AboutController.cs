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
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public AboutController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task< IActionResult> Index()
        {
            IEnumerable<About> abouts = await _context.Abouts.Where(a => a.IsDeleted == false).ToListAsync();
            return View(abouts);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(About about)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }
            if (about.Phrase == null)
            {
                ModelState.AddModelError("Phrase", "It is important add phrase  it can't be empty");
                return View(about);
            }
            if (about.File == null)
            {
                ModelState.AddModelError("File", "It is important add image");
                return View(about);
            }

            if (about.File.CheckFileSize(2200) == false)
            {
                ModelState.AddModelError("File", "File's size is bigger than required");
                return View(about);
            }

            if (about.File.CheckFileType("image/jpeg") == false)
            {
                ModelState.AddModelError("File", "Format of image is wrong");
                return View(about);
            }


            about.Image = about.File.CreateImage(_env, "assets", "images", "index", "blog");
            await _context.Abouts.AddAsync(about);
            about.Phrase = about.Phrase.Trim();
            about.IsDeleted = false;
            about.CreatedAt = DateTime.UtcNow.AddHours(4);
            about.CreatedBy = "System";


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

            About about = await _context.Abouts.FirstOrDefaultAsync(a => a.IsDeleted == false && a.Id == id);

            if (about == null)
            {
                return NotFound("Id is wrong");
            }

            return View(about);
        }

        [HttpPost]
        public async Task<IActionResult> Update(About about, int? id)
        {


            if (!ModelState.IsValid)
            {
                return View();
            }
            if (id == null)
            {
                return BadRequest("Id can't be null");
            }

            if (about.Id != id)
            {
                return BadRequest("Id must be equal");
            }

            if (about.Phrase == null)
            {
                ModelState.AddModelError("Phrase", "It is important add phrase  it can't be empty");
                return View(about);
            }
        
            if (await _context.Abouts.AnyAsync(a => a.IsDeleted == false && a.Phrase.ToLower() == about.Phrase.ToLower().Trim()))
            {
                    ModelState.AddModelError("Phrase", "Phrase is already exist");
                    return View(about);
                


            }
            About existedabout = await _context.Abouts.FirstOrDefaultAsync(a => a.IsDeleted == false && a.Id == id);

            if (existedabout == null)
            {
                return NotFound("Id is wrong");
            }
            if (about.File == null)
            {
                ModelState.AddModelError("File", "It is important add image");
                return View(about);
            }

            if (about.File.CheckFileSize(22000) == false)
            {
                ModelState.AddModelError("File", "File's size is bigger than required");
                return View(about);
            }

            if ((about.File.CheckFileType("image/jpeg")) == false)
            {
                ModelState.AddModelError("File", "Format of image is wrong");
                return View(about);
            }


            existedabout.UpdatedAt = DateTime.UtcNow.AddHours(4);
            existedabout.UpdatedBy = "System";
            existedabout.Image = about.File.CreateImage(_env, "assets", "images", "index", "blog");
            existedabout.Phrase = about.Phrase.Trim();
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

            About about = await _context.Abouts.FirstOrDefaultAsync(a => a.IsDeleted == false && a.Id == id);

            if (about == null)
            {
                return NotFound("no data");
            }

            about.IsDeleted = true;
            about.DeletedBy = "";
            about.DeletedAt = DateTime.UtcNow.AddHours(4);

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}
