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
    public class SupportController : Controller
    {
        private readonly AppDbContext _context;
        public SupportController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Support> supports = await _context.Supports.Where(s => s.IsDeleted == false).ToListAsync();
            return View(supports);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Support support)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }
            if (support.Icon == null)
            {
                ModelState.AddModelError("Icon", "It is important add ICON  it can't be empty");
                return View(support);
            }
            if (support.Title == null)
            {
                ModelState.AddModelError("Title", "It is important add Title  it can't be empty");
                return View(support);
            }
            if (support.Description == null)
            {
                ModelState.AddModelError("Description", "It is important add Description  it can't be empty");
                return View(support);
            }
            if (await _context.Supports.AnyAsync(s => s.IsDeleted == false && s.Title.ToLower() == support.Title.ToLower().Trim()))
            {
                ModelState.AddModelError("Title", $"This title = {support.Title} already exists ");
                return View(support);
            }



            support.Title = support.Title.Trim();
            support.Description = support.Description.Trim();
            support.Icon = support.Icon.Trim();
            support.IsDeleted = false;
            support.CreatedAt = DateTime.UtcNow.AddHours(4);
            support.CreatedBy = "System";


            await _context.Supports.AddAsync(support);
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

            Support support = await _context.Supports.FirstOrDefaultAsync(s => s.IsDeleted == false && s.Id == id);

            if (support == null)
            {
                return NotFound("Id is wrong");
            }

            return View(support);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Support support, int? id)
        {


            if (!ModelState.IsValid)
            {
                return View();
            }
            if (id == null)
            {
                return BadRequest("Id can't be null");
            }

            if (support.Id != id)
            {
                return BadRequest("Id must be equal");
            }
            if (support.Icon == null)
            {
                ModelState.AddModelError("Icon", "It is important add icon  it can't be empty");
                return View(support);
            }   if (support.Title == null)
            {
                ModelState.AddModelError("Title", "It is important add Title  it can't be empty");
                return View(support);
            }
            if (support.Description == null)
            {
                ModelState.AddModelError("Description", "It is important add Description  it can't be empty");
                return View(support);
            }
            if (await _context.Supports.AnyAsync(s => s.IsDeleted == false && s.Title.ToLower() == support.Title.ToLower().Trim()))
            {
                ModelState.AddModelError("Title", $"This title = {support.Title} already exists ");
                return View(support);
            }



            Support existedsupport = await _context.Supports.FirstOrDefaultAsync(s => s.IsDeleted == false && s.Id == id);

            if (existedsupport == null)
            {
                return NotFound("Id is wrong");
            }

            existedsupport.Icon = support.Icon.Trim();
            existedsupport.Title = support.Title.Trim();
            existedsupport.Description = support.Description.Trim();
            existedsupport.UpdatedAt = DateTime.UtcNow.AddHours(4);
            existedsupport.UpdatedBy = "System";

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

            Support support = await _context.Supports.FirstOrDefaultAsync(s => s.IsDeleted == false && s.Id == id);

            if (support == null)
            {
                return NotFound("no data");
            }



            support.IsDeleted = true;
            support.DeletedBy = "";
            support.DeletedAt = DateTime.UtcNow.AddHours(4);

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

       
    }
}
