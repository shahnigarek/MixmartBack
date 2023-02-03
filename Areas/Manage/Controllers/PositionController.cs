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
    public class PositionController : Controller
    {
        private readonly AppDbContext _context;
        public PositionController(AppDbContext context)
        {
            _context = context;

        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Position> positions = await _context.Positions.Where(p => p.IsDeleted == false).ToListAsync();

            return View(positions);
        }


        [HttpGet]

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Position position)
        {
            if (!ModelState.IsValid)
            {
                return View(position);
            }
            if (position.Name == null)
            {
                ModelState.AddModelError("Name", $"This name = {position.Name} doesn't exists ");
                return View();

            }
            if (await _context.Positions.AnyAsync(c => c.IsDeleted == false && c.Name.ToLower() == position.Name.ToLower().Trim()))
            {
                ModelState.AddModelError("Name", $"This name = {position.Name} already exists ");
                return View(position);
            }



            position.Name = position.Name.Trim();
            position.IsDeleted = false;
            position.CreatedAt = DateTime.UtcNow.AddHours(4);
            position.CreatedBy = "System";
            await _context.Positions.AddAsync(position);
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

            Position position = await _context.Positions.FirstOrDefaultAsync(p => p.IsDeleted == false && p.Id == id);

            if (position == null)
            {
                return NotFound("Id is wrong");
            }

            ViewBag.Position = await _context.Positions
               .Where(p => p.IsDeleted == false)
               .ToListAsync();

            return View(position);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Position position, int? id)
        {


            if (!ModelState.IsValid)
            {
                return View(position);
            }
            if (id == null)
            {
                return BadRequest("Id can't be null");
            }

            if (position.Id != id)
            {
                return BadRequest("Id must be equal");
            }
            if (await _context.Positions.AnyAsync(p => p.IsDeleted == false && p.Name.ToLower() == position.Name.ToLower().Trim() && p.Id != id))
            {
                ModelState.AddModelError("Name", $"This name = {position.Name} already exists ");
                return View(position);
            }


            Position existedposition = await _context.Positions.FirstOrDefaultAsync(p => p.IsDeleted == false && p.Id == id);

            if (existedposition == null)
            {
                return NotFound("Id is wrong");
            }
            if (existedposition.Name == position.Name)
            {

                ModelState.AddModelError("Name", $"This name = {position.Name} already exists ");
                return View(position);
            }

            existedposition.Name = position.Name.Trim();
            existedposition.UpdatedAt = DateTime.UtcNow.AddHours(4);
            existedposition.UpdatedBy = "System";

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

            Position position = await _context.Positions
                .FirstOrDefaultAsync(p => p.IsDeleted == false && p.Id == id);

            if (position == null)
            {
                return NotFound("Id is wrong");
            }


            position.IsDeleted = true;
            position.DeletedBy = "";
            position.DeletedAt = DateTime.UtcNow.AddHours(4);


            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
