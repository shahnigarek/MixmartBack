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
    public class CeramicController : Controller
    {
        private readonly AppDbContext _context;
        public CeramicController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {

            IEnumerable<Ceramic> ceramics = await _context.Ceramics.Where(c => c.IsDeleted == false).ToListAsync();
            return View(ceramics);
        }



        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest("Id can't be null");
            }

            Ceramic ceramic = await _context.Ceramics.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (ceramic == null)
            {
                return NotFound("no data");
            }



            ceramic.IsDeleted = true;
            ceramic.DeletedBy = "";
            ceramic.DeletedAt = DateTime.UtcNow.AddHours(4);

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


    }
}
