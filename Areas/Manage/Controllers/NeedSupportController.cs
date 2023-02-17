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
    public class NeedSupportController : Controller
    {
        private readonly AppDbContext _context;
        public NeedSupportController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<NeedSupport> needSupports = await _context.NeedSupports.Where(ns => ns.IsDeleted == false).ToListAsync();
            return View(needSupports);
        }

      
        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return BadRequest("Id can't be null");
            }

            NeedSupport needSupport = await _context.NeedSupports.FirstOrDefaultAsync(ns => ns.IsDeleted == false && ns.Id == id);

            if (needSupport == null)
            {
                return NotFound("Id is wrong");
            }

            return View(needSupport);
        }

        [HttpPost]
        public async Task<IActionResult> Update(NeedSupport needSupport, int? id)
        {


            if (!ModelState.IsValid)
            {
                return View();
            }
            if (id == null)
            {
                return BadRequest("Id can't be null");
            }

            if (needSupport.Id != id)
            {
                return BadRequest("Id must be equal");
            }
            if (needSupport.Icon == null)
            {
                ModelState.AddModelError("Icon", "It is important add icon  it can't be empty");
                return View(needSupport);
            }
            if (needSupport.Title == null)
            {
                ModelState.AddModelError("Title", "It is important add Title  it can't be empty");
                return View(needSupport);
            }
          
            if (await _context.NeedSupports.AnyAsync(ns => ns.IsDeleted == false && ns.Title.ToLower() == needSupport.Title.ToLower().Trim()))
            {
                ModelState.AddModelError("Title", $"This title = {needSupport.Title} already exists ");
                return View(needSupport);
            }



            NeedSupport existedsupport = await _context.NeedSupports.FirstOrDefaultAsync(ns => ns.IsDeleted == false && ns.Id == id);

            if (existedsupport == null)
            {
                return NotFound("Id is wrong");
            }

            existedsupport.Icon = needSupport.Icon.Trim();
            existedsupport.Title = needSupport.Title.Trim();
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

            NeedSupport needSupport = await _context.NeedSupports.FirstOrDefaultAsync(ns => ns.IsDeleted == false && ns.Id == id);

            if (needSupport == null)
            {
                return NotFound("no data");
            }



            needSupport.IsDeleted = true;
            needSupport.DeletedBy = "";
            needSupport.DeletedAt = DateTime.UtcNow.AddHours(4);

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


    }
}
