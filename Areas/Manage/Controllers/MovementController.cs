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
    public class MovementController : Controller
    {
        private readonly AppDbContext _context;
        public MovementController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {

            IEnumerable<Movement> movements = await _context.Movements.Where(m => m.IsDeleted == false).ToListAsync();
            return View(movements);
        }



        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest("Id can't be null");
            }

            Movement movement = await _context.Movements.FirstOrDefaultAsync(m => m.IsDeleted == false && m.Id == id);

            if (movement == null)
            {
                return NotFound("no data");
            }



            movement.IsDeleted = true;
            movement.DeletedBy = "";
            movement.DeletedAt = DateTime.UtcNow.AddHours(4);

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


    }
}
