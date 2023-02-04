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
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public BlogController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Blog> blogs = await _context.Blogs
                .Include(b => b.BlogCategories).ThenInclude(bc => bc.BCategory)
                .Where(p => p.IsDeleted == false)
                .ToListAsync();

            return View(blogs);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.BCategories = await _context.BCategories.Where(c => c.IsDeleted == false).ToListAsync();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Blog blog)
        {
            ViewBag.BCategories = await _context.BCategories.Where(c => c.IsDeleted == false).ToListAsync();

            if (!ModelState.IsValid)
            {
                return View(blog);
            }
            if (blog.Title == null)
            {
                ModelState.AddModelError("Title", "It is important add Title  it can't be empty");
                return View(blog);
            }

            if (blog.Author == null)
            {
                ModelState.AddModelError("Author", "It is important add author  it can't be empty");
                return View(blog);
            }

            if (await _context.Blogs.AnyAsync(p => p.IsDeleted == false && p.Title.ToLower() == blog.Title.ToLower().Trim()))
            {
                ModelState.AddModelError("Title", $"This title = {blog.Title} already exists ");
                return View(blog);
            }

            if (blog.File == null)
            {
                ModelState.AddModelError("File", "It is important add image");
                return View(blog);
            }

            if (blog.File.CheckFileSize(2200) == false)
            {
                ModelState.AddModelError("File", "File's size is bigger than required");
                return View(blog);
            }

            if (blog.File.CheckFileType("image/jpeg") == false)
            {
                ModelState.AddModelError("File", "Format of image is wrong");
                return View(blog);
            }

            List<BlogCategory> blogCategories = new List<BlogCategory>();

           
            foreach (int bcategoryId in blog.BCategoryIds)
            {


                if (!await _context.BCategories.AnyAsync(c => c.IsDeleted == false && c.Id == bcategoryId))
                {
                    ModelState.AddModelError("BCategoryIds", "Choosen BCategory is wrong");
                    return View(blog);
                }

                BlogCategory blogCategory = new BlogCategory
                {
                    CreatedAt = DateTime.UtcNow.AddHours(+4),
                    CreatedBy = "System",
                    IsDeleted = false,
                    BCategoryId = bcategoryId
                };

                blogCategories.Add(blogCategory);
            }
            blog.Image = blog.File.CreateImage(_env, "assets", "images", "index", "blog");

            blog.BlogCategories = blogCategories;
            blog.Title = blog.Title;
            blog.Description1 = blog.Description1;
            blog.Description2 = blog.Description2;
            blog.Author = blog.Author;

            await _context.Blogs.AddAsync(blog);
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

            Blog blog = await _context.Blogs.FirstOrDefaultAsync(b => b.IsDeleted == false && b.Id == id);

            if (blog == null)
            {
                return NotFound();
            }

            blog.BCategoryIds = await _context.BlogCategories.Where(bc => bc.BlogId == id).Select(x => x.BCategoryId).ToListAsync();

            ViewBag.BCategories = await _context.BCategories.Where(c => c.IsDeleted == false).ToListAsync();

            return View(blog);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Blog blog)
        {
            ViewBag.BCategories = await _context.BCategories.Where(c => c.IsDeleted == false).ToListAsync();

            if (!ModelState.IsValid)
            {
                return View(blog);
            }
            if (blog.Title == null)
            {
                ModelState.AddModelError("Title", "It is important add Title  it can't be empty");
                return View(blog);
            }
            if (blog.Author == null)
            {
                ModelState.AddModelError("Author", "It is important add author  it can't be empty");
                return View(blog);
            }

            if (await _context.Blogs.AnyAsync(b => b.IsDeleted == false && b.Title.ToLower() == blog.Title.ToLower().Trim()))
            {
                ModelState.AddModelError("Title", $"This title = {blog.Title} already exists ");
                return View(blog);
            }




            Blog existedblog = await _context.Blogs.Include(b => b.BlogCategories).FirstOrDefaultAsync(b => b.IsDeleted == false && b.Id == id);

            _context.BlogCategories.RemoveRange(existedblog.BlogCategories);

            List<BlogCategory> blogCategories = new List<BlogCategory>();
          
            foreach (int bcategoryId in blog.BCategoryIds)
            {


                if (!await _context.BCategories.AnyAsync(b => b.IsDeleted == false && b.Id == bcategoryId))
                {
                    ModelState.AddModelError("BCategoryIds", "Choosen bCategory is wrong");
                    return View(blog);
                }

                BlogCategory blogCategory = new BlogCategory
                {
                    UpdatedAt = DateTime.UtcNow.AddHours(+4),
                    UpdatedBy = "System",
                    IsDeleted = false,
                    BCategoryId = bcategoryId
                };

                blogCategories.Add(blogCategory);
            }
            if (blog.File == null)
            {
                ModelState.AddModelError("File", "It is important add image");
                return View(blog);
            }

            if (blog.File.CheckFileSize(2200) == false)
            {
                ModelState.AddModelError("File", "File's size is bigger than required");
                return View(blog);
            }

            if (blog.File.CheckFileType("image/jpeg") == false)
            {
                ModelState.AddModelError("File", "Format of image is wrong");
                return View(blog);
            }
            existedblog.Image = blog.File.CreateImage(_env, "assets", "images", "index", "blog");
            existedblog.Title = blog.Title;
            existedblog.Description1 = blog.Description1.Trim();
            existedblog.Description2 = blog.Description2.Trim();
            existedblog.Author = blog.Author;
            existedblog.Date = blog.Date;
            existedblog.EnvelopeUrl = blog.EnvelopeUrl;
            existedblog.FacebookUrl = blog.FacebookUrl;
            existedblog.GooglePlusUrl = blog.GooglePlusUrl;
            existedblog.LinkedinUrl = blog.LinkedinUrl;
            existedblog.PinterestUrl = blog.PinterestUrl;
            existedblog.TumblrUrl = blog.TumblrUrl;
            existedblog.TwitterUrl = blog.TwitterUrl;
            existedblog.BlogCategories = blogCategories;

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

            Blog blog = await _context.Blogs
                     .Include(c => c.BlogCategories).ThenInclude(c => c.BCategory)
                     .FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (blog == null)
            {
                return NotFound("no data");
            }



            blog.IsDeleted = true;
            blog.DeletedBy = "";
            blog.DeletedAt = DateTime.UtcNow.AddHours(4);

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return BadRequest("Id can't be null");
            }

            ViewBag.BCategories = await _context.BCategories.Where(c => c.IsDeleted == false).ToListAsync();
            Blog blog = await _context.Blogs
                .Include(c => c.BlogCategories).ThenInclude(c => c.BCategory)
                .FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (blog == null)
            {
                return NotFound("Id is wrong");
            }

            return View(blog);
        }
    }
}
