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
    public class TeamController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public TeamController(AppDbContext context,IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task< IActionResult> Index()
        {
            IEnumerable<Team> teams = await _context.Teams.Where(t => t.IsDeleted == false).ToListAsync();
            return View(teams);
        }
        [HttpGet]

        public async Task< IActionResult> Create()
        {
            ViewBag.Position = await _context.Positions.Where(p => p.IsDeleted == false).ToListAsync();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Team team)
        {
            ViewBag.Position = await _context.Positions.Where(p => p.IsDeleted == false).ToListAsync();
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (team == null)
            {
                return BadRequest();
            }

            if (team.File == null)
            {
                ModelState.AddModelError("File", "Please add photo");
                return View(team);
            }
            if (team.File.CheckFileSize(102400) == false)
            {
                ModelState.AddModelError("File", "File size is bigger than required");
                return View(team);
            }

            if (team.File.CheckFileType("image/jpeg") == false)
            {
                ModelState.AddModelError("File", "Format of file is wrong ");
                return View(team);
            }




            team.FullName.Trim();
            team.Image = team.File.CreateImage(_env, "assets", "images", "index","team");
            _context.Teams.Add(team);
            team.IsDeleted = false;
            team.CreatedAt = DateTime.UtcNow.AddHours(4);
            team.CreatedBy = "System";
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            Team team = await _context.Teams.FirstOrDefaultAsync(t => t.Id == id && t.IsDeleted == false);

            ViewBag.Position = await _context.Positions.Where(p => p.IsDeleted == false).ToListAsync();

            if (id == null)
            {
                return NotFound();
            }
            if (team == null)
            {
                return NotFound();
            }

            return View(team);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Team team, int? id)
        {

            ViewBag.Position = await _context.Positions.Where(p => p.IsDeleted == false).ToListAsync();

            if (!ModelState.IsValid)
            {
                return View();
            }
            if (id == null)
            {
                return BadRequest("Id can't be null");
            }

            if (team.Id != id)
            {
                return BadRequest("Id must be equal");
            }
            if (await _context.Teams.AnyAsync(t => t.IsDeleted == false && t.FullName.ToLower() == team.FullName.ToLower().Trim() && t.Id != id))
            {
                ModelState.AddModelError("Name", $"This name = {team.FullName} already exists ");
                return View(team);
            }


            Team existedteam = await _context.Teams.FirstOrDefaultAsync(t => t.IsDeleted == false && t.Id == id);

            if (existedteam == null)
            {
                return NotFound("Id is wrong");
            }
            if ( team.File == null)
            {
                ModelState.AddModelError("File", "It is important add image");
                return View(team);
            }

            if (team.File.CheckFileSize(2048) == false)
            {
                ModelState.AddModelError("File", "File's size is bigger than required");
                return View(team);
            }

            if (team.File.CheckFileType("image/jpeg") == false)
            {
                ModelState.AddModelError("File", "Format of image is wrong");
                return View(team);
            }


            existedteam.FullName = team.FullName.Trim();
       
            existedteam.PositionId = team.PositionId;
            existedteam.Image = team.File.CreateImage(_env, "assets", "images", "index","team");
            existedteam.UpdatedAt = DateTime.UtcNow.AddHours(4);
            existedteam.UpdatedBy = "System";

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Detail(int? id)
        {

            if (id == null)
            {
                return BadRequest();
            }

            Team team = await _context.Teams
                 .Include(t => t.Position)
                 .FirstOrDefaultAsync(t => t.IsDeleted == false && t.Id == id);
            if (team == null)
            {
                return NotFound();
            }


            return View(team);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {

            if (id == null)
            {
                return BadRequest();
            }
            Team team = await _context.Teams.FirstOrDefaultAsync(t => t.IsDeleted == false && t.Id == id);

            if (team == null)
            {
                return NotFound();

            }


            team.IsDeleted = true;
            team.DeletedAt = DateTime.UtcNow.AddHours(4);
            team.DeletedBy = "System";


            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }



    }
}
