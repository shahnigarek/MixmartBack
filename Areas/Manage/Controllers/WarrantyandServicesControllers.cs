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
    public class WarrantyandServicesController : Controller
    {
        private readonly AppDbContext _context;
        public WarrantyandServicesController (AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<WarrantyandService> warrantyandServices = await _context.WarrantyandServices.Where(ws => ws.IsDeleted == false).ToListAsync();
            return View(warrantyandServices);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(WarrantyandService warrantyandService)
        {

            if (!ModelState.IsValid)
            {
                return View(warrantyandService);
            }
            if (await _context.WarrantyandServices.AnyAsync(ws => ws.IsDeleted == false && ws.Title.ToLower() == warrantyandService.Title.ToLower().Trim()))
            {
                ModelState.AddModelError("Title", $"This title = {warrantyandService.Title} already exists ");
                return View(warrantyandService);
            }



            warrantyandService.Title = warrantyandService.Title.Trim();
            warrantyandService.Description = warrantyandService.Description.Trim();
            warrantyandService.IsDeleted = false;
            warrantyandService.CreatedAt = DateTime.UtcNow.AddHours(4);
            warrantyandService.CreatedBy = "System";


            await _context.WarrantyandServices.AddAsync(warrantyandService);
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

            WarrantyandService warrantyandService = await _context.WarrantyandServices.FirstOrDefaultAsync(ws => ws.IsDeleted == false && ws.Id == id);

            if (warrantyandService == null)
            {
                return NotFound("Id is wrong");
            }

            return View(warrantyandService);
        }

        [HttpPost]
        public async Task<IActionResult> Update(WarrantyandService warrantyandService, int? id)
        {


            if (!ModelState.IsValid)
            {
                return View(warrantyandService);
            }
            if (id == null)
            {
                return BadRequest("Id can't be null");
            }

            if (warrantyandService.Id != id)
            {
                return BadRequest("Id must be equal");
            }
            if (await _context. WarrantyandServices.AnyAsync(ws => ws.IsDeleted == false && ws.Title.ToLower() == warrantyandService.Title.ToLower().Trim() && ws.Id != id))
            {
                ModelState.AddModelError("Title", $"This title = {warrantyandService.Title} already exists ");
                return View(warrantyandService);
            }


                WarrantyandService existewarranty = await _context.WarrantyandServices.FirstOrDefaultAsync(ws => ws.IsDeleted == false && ws.Id == id);

            if (existewarranty == null)
            {
                return NotFound("Id is wrong");
            }


            existewarranty.Title = warrantyandService.Title.Trim();
            existewarranty.Description = warrantyandService.Description.Trim();
            existewarranty.UpdatedAt = DateTime.UtcNow.AddHours(4);
            existewarranty.UpdatedBy = "System";

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

            WarrantyandService warrantyandService = await _context.WarrantyandServices.FirstOrDefaultAsync(ws => ws.IsDeleted == false && ws.Id == id);

            if (warrantyandService == null)
            {
                return NotFound("no data");
            }



            warrantyandService.IsDeleted = true;
            warrantyandService.DeletedBy = "";
            warrantyandService.DeletedAt = DateTime.UtcNow.AddHours(4);

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return BadRequest("Id can't be null");
            }


            WarrantyandService warrantyandService = await _context.WarrantyandServices.FirstOrDefaultAsync(ws => ws.IsDeleted == false && ws.Id == id);



            if (warrantyandService == null)
            {
                return NotFound("Id is wrong");
            }

            return View(warrantyandService);
        }
    }

}
