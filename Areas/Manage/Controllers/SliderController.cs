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

    public class SliderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public SliderController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Slider> sliders = await _context.Sliders.Where(s => s.IsDeleted == false).ToListAsync();
            return View(sliders);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Slider slider)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }
            if (slider.MainTitle == null)
            {
                ModelState.AddModelError("MainTitle", "It is important add MainTitle  it can't be empty");
                return View(slider);
            }
            if (slider.SubTitle == null)
            {
                ModelState.AddModelError("SubTitle", "It is important add SubTitle  it can't be empty");
                return View(slider);
            }
            if (await _context.Sliders.AnyAsync(s => s.IsDeleted == false && s.MainTitle.ToLower() == slider.MainTitle.ToLower().Trim()))
            {
                ModelState.AddModelError("MainTitle", $"This MainTitle = {slider.MainTitle} already exists ");
                return View(slider);
            }

            if (await _context.Sliders.AnyAsync(s => s.IsDeleted == false && s.SubTitle.ToLower() == slider.SubTitle.ToLower().Trim()))
            {
                ModelState.AddModelError("SubTitle", $"This SubTitle = {slider.SubTitle} already exists ");
                return View(slider);
            }

         
            if (slider.File == null)
            {
                ModelState.AddModelError("File", "It is important add image");
                return View(slider);
            }

            if (slider.File.CheckFileSize(2200) == false)
            {
                ModelState.AddModelError("File", "File's size is bigger than required");
                return View(slider);
            }

            if (slider.File.CheckFileType("image/jpeg") == false)
            {
                ModelState.AddModelError("File", "Format of image is wrong");
                return View(slider);
            }


            slider.Image = slider.File.CreateImage(_env, "assets", "images", "index", "slider");
            await _context.Sliders.AddAsync(slider);
            slider.MainTitle = slider.MainTitle.Trim();
            slider.SubTitle = slider.SubTitle.Trim();
            slider.IsDeleted = false;
            slider.CreatedAt = DateTime.UtcNow.AddHours(4);
            slider.CreatedBy = "System";


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

            Slider slider = await _context.Sliders.FirstOrDefaultAsync(s => s.IsDeleted == false && s.Id == id);

            if (slider == null)
            {
                return NotFound("Id is wrong");
            }

            return View(slider);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Slider slider, int? id)
        {


            if (!ModelState.IsValid)
            {
                return View();
            }
            if (id == null)
            {
                return BadRequest("Id can't be null");
            }

            if (slider.Id != id)
            {
                return BadRequest("Id must be equal");
            }

            if (await _context.Sliders.AnyAsync(s => s.IsDeleted == false && s.MainTitle.ToLower() == slider.MainTitle.ToLower().Trim()))
            {
                ModelState.AddModelError("MainTitle", $"This MainTitle = {slider.MainTitle} already exists ");
                return View(slider);
            }

            if (await _context.Sliders.AnyAsync(s => s.IsDeleted == false && s.SubTitle.ToLower() == slider.SubTitle.ToLower().Trim()))
            {
                ModelState.AddModelError("SubTitle", $"This SubTitle = {slider.SubTitle} already exists ");
                return View(slider);
            }


            Slider existedslider = await _context.Sliders.FirstOrDefaultAsync(s => s.IsDeleted == false && s.Id == id);

            if (existedslider == null)
            {
                return NotFound("Id is wrong");
            }
         
            if (slider.File == null)
            {
                ModelState.AddModelError("File", "It is important add image");
                return View(slider);
            }

            if (slider.File.CheckFileSize(22000) == false)
            {
                ModelState.AddModelError("File", "File's size is bigger than required");
                return View(slider);
            }

            if ((slider.File.CheckFileType("image/jpeg")) == false)
            {
                ModelState.AddModelError("File", "Format of image is wrong");
                return View(slider);
            }


            existedslider.UpdatedAt = DateTime.UtcNow.AddHours(4);
            existedslider.UpdatedBy = "System";
            existedslider.Image = slider.File.CreateImage(_env, "assets", "images", "index", "slider");
            existedslider.MainTitle = slider.MainTitle.Trim();
            existedslider.SubTitle = slider.SubTitle.Trim();
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

            Slider slider = await _context.Sliders.FirstOrDefaultAsync(s => s.IsDeleted == false && s.Id == id);

            if (slider == null)
            {
                return NotFound("no data");
            }

            slider.IsDeleted = true;
            slider.DeletedBy = "";
            slider.DeletedAt = DateTime.UtcNow.AddHours(4);

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}
