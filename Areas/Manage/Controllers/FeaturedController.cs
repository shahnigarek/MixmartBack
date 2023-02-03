using Microsoft.AspNetCore.Hosting;
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
    public class FeaturedController : Controller
    {
        private readonly AppDbContext _context;
        public FeaturedController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Featured> featureds = await _context.Featureds.Where(f => f.IsDeleted == false).ToListAsync();
            return View(featureds);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Featured featured)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }
            if (featured.Question == null)
            {
                ModelState.AddModelError("Question", "It is important add Question  it can't be empty");
                return View(featured);
            }
            if (featured.Answer == null)
            {
                ModelState.AddModelError("Answer", "It is important add Answer  it can't be empty");
                return View(featured);
            }
            if (await _context.Featureds.AnyAsync(f => f.IsDeleted == false && f.Question.ToLower() == featured.Question.ToLower().Trim()))
            {
                ModelState.AddModelError("Question", $"This Question = {featured.Question} already exists ");
                return View(featured);
            }

            if (await _context.Featureds.AnyAsync(f => f.IsDeleted == false && f.Answer.ToLower() == featured.Answer.ToLower().Trim()))
            {
                ModelState.AddModelError("Answer", $"This Answer = {featured.Answer} already exists ");
                return View(featured);
            }

         
     
            await _context.Featureds.AddAsync(featured);
            featured.Question = featured.Question.Trim();
            featured.Answer = featured.Answer.Trim();
            featured.IsDeleted = false;
            featured.CreatedAt = DateTime.UtcNow.AddHours(4);
            featured.CreatedBy = "System";


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

            Featured featured = await _context.Featureds.FirstOrDefaultAsync(f => f.IsDeleted == false && f.Id == id);

            if (featured == null)
            {
                return NotFound("Id is wrong");
            }

            return View(featured);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Featured featured, int? id)
        {


            if (!ModelState.IsValid)
            {
                return View();
            }
            if (id == null)
            {
                return BadRequest("Id can't be null");
            }

            if (featured.Id != id)
            {
                return BadRequest("Id must be equal");
            }
            if (featured.Question == null)
            {
                ModelState.AddModelError("Question", "It is important add Question  it can't be empty");
                return View(featured);
            }
            if (featured.Answer == null)
            {
                ModelState.AddModelError("Answer", "It is important add Answer  it can't be empty");
                return View(featured);
            }

            if (await _context.Featureds.AnyAsync(f => f.IsDeleted == false && f.Question.ToLower() == featured.Question.ToLower().Trim()))
            {
                ModelState.AddModelError("Question", $"This Question = {featured.Question} already exists ");
                return View(featured);
            }

            if (await _context.Featureds.AnyAsync(f => f.IsDeleted == false && f.Answer.ToLower() == featured.Answer.ToLower().Trim()))
            {
                ModelState.AddModelError("Answer", $"This Answer = {featured.Answer} already exists ");
                return View(featured);
            }



            Featured existedfeatured = await _context.Featureds.FirstOrDefaultAsync(f => f.IsDeleted == false && f.Id == id);

            if (existedfeatured == null)
            {
                return NotFound("Id is wrong");
            }
         


            existedfeatured.UpdatedAt = DateTime.UtcNow.AddHours(4);
            existedfeatured.UpdatedBy = "System";
            existedfeatured.Question = featured.Question.Trim();
            existedfeatured.Answer = featured.Answer.Trim();
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

            Featured featured = await _context.Featureds.FirstOrDefaultAsync(f => f.IsDeleted == false && f.Id == id);


            if (featured == null)
            {
                return NotFound("no data");
            }

            featured.IsDeleted = true;
            featured.DeletedBy = "";
            featured.DeletedAt = DateTime.UtcNow.AddHours(4);

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}
