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
    public class TermandConditionsController : Controller
    {
        private readonly AppDbContext _context;
        public TermandConditionsController(AppDbContext context)
        {
            _context = context;
        }
        public async Task< IActionResult > Index()
        {
            IEnumerable<TermandCondition> termandConditions = await _context.TermandConditions.Where(tc => tc.IsDeleted == false).ToListAsync();
            return View(termandConditions);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(TermandCondition termandCondition)
        {
        
            if (!ModelState.IsValid)
            {
                return View(termandCondition);
            }
            if (await _context.TermandConditions.AnyAsync(tc => tc.IsDeleted == false && tc.Title.ToLower() == termandCondition.Title.ToLower().Trim()))
            {
                ModelState.AddModelError("Title", $"This title = {termandCondition.Title} already exists ");
                return View(termandCondition);
            }
          


            termandCondition.Title = termandCondition.Title.Trim();
            termandCondition.Description = termandCondition.Description.Trim();
            termandCondition.IsDeleted = false;
            termandCondition.CreatedAt = DateTime.UtcNow.AddHours(4);
            termandCondition.CreatedBy = "System";


            await _context.TermandConditions.AddAsync(termandCondition);
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

            TermandCondition termandCondition = await _context.TermandConditions.FirstOrDefaultAsync(tc => tc.IsDeleted == false && tc.Id == id);

            if (termandCondition == null)
            {
                return NotFound("Id is wrong");
            }

            return View(termandCondition);
        }

        [HttpPost]
        public async Task<IActionResult> Update(TermandCondition termandCondition, int? id)
        {


            if (!ModelState.IsValid)
            {
                return View(termandCondition);
            }
            if (id == null)
            {
                return BadRequest("Id can't be null");
            }

            if (termandCondition.Id != id)
            {
                return BadRequest("Id must be equal");
            }
            if (await _context.TermandConditions.AnyAsync(b => b.IsDeleted == false && b.Title.ToLower() == termandCondition.Title.ToLower().Trim() && b.Id != id))
            {
                ModelState.AddModelError("Title", $"This title = {termandCondition.Title} already exists ");
                return View(termandCondition);
            }


            TermandCondition existedterm = await _context.TermandConditions.FirstOrDefaultAsync(tc => tc.IsDeleted == false && tc.Id == id);

            if (existedterm == null)
            {
                return NotFound("Id is wrong");
            }
         

            existedterm.Title = termandCondition.Title.Trim();
            existedterm.Description = termandCondition.Description.Trim();
            existedterm.UpdatedAt = DateTime.UtcNow.AddHours(4);
            existedterm.UpdatedBy = "System";

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

            TermandCondition termandCondition = await _context.TermandConditions.FirstOrDefaultAsync(tc => tc.IsDeleted == false && tc.Id == id);

            if (termandCondition == null)
            {
                return NotFound("no data");
            }



            termandCondition.IsDeleted = true;
            termandCondition.DeletedBy = "";
            termandCondition.DeletedAt = DateTime.UtcNow.AddHours(4);

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return BadRequest("Id can't be null");
            }


            TermandCondition termandCondition = await _context.TermandConditions.FirstOrDefaultAsync(tc => tc.IsDeleted == false && tc.Id == id);


            if (termandCondition == null)
            {
                return NotFound("Id is wrong");
            }

            return View(termandCondition);
        }
    }

}
