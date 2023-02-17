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
    public class StoryController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public StoryController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Story> stories = await _context.Stories.Where(s => s.IsDeleted == false).ToListAsync();
            return View(stories);
        }

   

        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return BadRequest("Id can't be null");
            }

            Story story = await _context.Stories.FirstOrDefaultAsync(s => s.IsDeleted == false && s.Id == id);

            if (story == null)
            {
                return NotFound("Id is wrong");
            }

            return View(story);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Story story, int? id)
        {


            if (!ModelState.IsValid)
            {
                return View();
            }
            if (id == null)
            {
                return BadRequest("Id can't be null");
            }

            if (story.Id != id)
            {
                return BadRequest("Id must be equal");
            }
            if (story.Title == null)
            {
                ModelState.AddModelError("Title", "It is important add Title  it can't be empty");
                return View(story);
            }
            if (story.Description == null)
            {
                ModelState.AddModelError("Description", "It is important add Description  it can't be empty");
                return View(story);
            }
            if (await _context.Stories.AnyAsync(tc => tc.IsDeleted == false && tc.Title.ToLower() == story.Title.ToLower().Trim()))
            {
                ModelState.AddModelError("Title", $"This title = {story.Title} already exists ");
                return View(story);
            }



            Story existedstory = await _context.Stories.FirstOrDefaultAsync(s => s.IsDeleted == false && s.Id == id);

            if (existedstory == null)
            {
                return NotFound("Id is wrong");
            }
            if (story.File == null)
            {
                ModelState.AddModelError("File", "It is important add image");
                return View(story);
            }

            if (story.File.CheckFileSize(22000) == false)
            {
                ModelState.AddModelError("File", "File's size is bigger than required");
                return View(story);
            }

            if ((story.File.CheckFileType("image/jpeg")) == false)
            {
                ModelState.AddModelError("File", "Format of image is wrong");
                return View(story);
            }


         
            existedstory.Image = story.File.CreateImage(_env, "assets", "images", "index", "error");
            existedstory.Title = story.Title.Trim();
            existedstory.Description = story.Description.Trim();
            existedstory.UpdatedAt = DateTime.UtcNow.AddHours(4);
            existedstory.UpdatedBy = "System";

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

            Story story = await _context.Stories.FirstOrDefaultAsync(s => s.IsDeleted == false && s.Id == id);

            if (story == null)
            {
                return NotFound("no data");
            }



            story.IsDeleted = true;
            story.DeletedBy = "";
            story.DeletedAt = DateTime.UtcNow.AddHours(4);

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return BadRequest("Id can't be null");
            }


            Story story = await _context.Stories.FirstOrDefaultAsync(s => s.IsDeleted == false && s.Id == id);


            if (story == null)
            {
                return NotFound("Id is wrong");
            }

            return View(story);
        }
    }

}
