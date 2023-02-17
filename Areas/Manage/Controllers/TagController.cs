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
    public class TagController : Controller
    {
        private readonly AppDbContext _context;
        public TagController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {

            IEnumerable<Tag> tags = await _context.Tags.Where(t => t.IsDeleted == false).ToListAsync();

            return View(tags);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Tag tag)
        {
            if (!ModelState.IsValid)
            {
                return View(tag);
            }

            if (tag.Name == null)
            {
                ModelState.AddModelError("Name", $"This name = {tag.Name} doesn't exists ");
                return View();

            }
            if (await _context.Tags.AnyAsync(t => t.IsDeleted == false && t.Name.ToLower() == tag.Name.ToLower().Trim()))
            {
                ModelState.AddModelError("Name", $"This name = {tag.Name} already exists ");
                return View(tag);
            }



            tag.Name = tag.Name.Trim();
            tag.IsDeleted = false;
            tag.CreatedAt = DateTime.UtcNow.AddHours(4);
            tag.CreatedBy = "System";
            await _context.Tags.AddAsync(tag);
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

            Tag tag = await _context.Tags.FirstOrDefaultAsync(t => t.IsDeleted == false && t.Id == id);

            if (tag == null)
            {
                return NotFound("Id is wrong");
            }

            return View(tag);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(Tag tag, int? id)
        {
            if (!ModelState.IsValid)
            {
                return View(tag);
            }
            if (id == null)
            {
                return BadRequest("Id can't be null");
            }
            if (tag.Name == null)
            {
                ModelState.AddModelError("Name", $"name can't be null ");
                return View(tag);
            }

            if (tag.Id != id)
            {
                return BadRequest("Id must be equal");
            }
            if (await _context.Tags.AnyAsync(t => t.IsDeleted == false && t.Name.ToLower() == tag.Name.ToLower().Trim() && t.Id != id))
            {
                ModelState.AddModelError("Name", $"This name = {tag.Name} already exists ");
                return View(tag);
            }


            Tag existedtag = await _context.Tags.FirstOrDefaultAsync(t => t.IsDeleted == false && t.Id == id);

            if (existedtag == null)
            {
                return NotFound("Id is wrong");
            }
            if (existedtag.Name == tag.Name)
            {
                ModelState.AddModelError("Name", $"This name = {tag.Name} already exists ");
                return View(tag);
            }

            existedtag.Name = tag.Name.Trim();
            existedtag.UpdatedAt = DateTime.UtcNow.AddHours(4);
            existedtag.UpdatedBy = "System";
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

            Tag tag = await _context.Tags
                .FirstOrDefaultAsync(t => t.IsDeleted == false && t.Id == id);

            if (tag == null)
            {
                return NotFound("Id is wrong");
            }


            tag.IsDeleted = true;
            tag.DeletedBy = "";
            tag.DeletedAt = DateTime.UtcNow.AddHours(4);


            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}
