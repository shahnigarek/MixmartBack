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
    [Authorize(Roles = "Admin")]

    public class CraftedController : Controller
    {
        private readonly AppDbContext _context;
        public CraftedController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {

            IEnumerable<Crafted> crafteds = await _context.Crafteds.Where(c => c.IsDeleted == false).ToListAsync();
            return View(crafteds);
        }



        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest("Id can't be null");
            }

            Crafted crafted = await _context.Crafteds.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (crafted == null)
            {
                return NotFound("no data");
            }



            crafted.IsDeleted = true;
            crafted.DeletedBy = "";
            crafted.DeletedAt = DateTime.UtcNow.AddHours(4);

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


    }
}
