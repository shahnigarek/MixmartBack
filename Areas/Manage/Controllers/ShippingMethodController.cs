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
    public class ShippingMethodController : Controller
    {
        private readonly AppDbContext _context;
        public ShippingMethodController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<ShippingMethod> shippingMethods = await _context.ShippingMethods.Where(sm => sm.IsDeleted == false).ToListAsync();
            return View(shippingMethods);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(ShippingMethod shippingMethod)
        {

            if (!ModelState.IsValid)
            {
                return View(shippingMethod);
            }
            if (await _context.ShippingMethods.AnyAsync(sm => sm.IsDeleted == false && sm.Title.ToLower() == shippingMethod.Title.ToLower().Trim()))
            {
                ModelState.AddModelError("Title", $"This title = {shippingMethod.Title} already exists ");
                return View(shippingMethod);
            }



            shippingMethod.Title = shippingMethod.Title.Trim();
            shippingMethod.Description = shippingMethod.Description.Trim();
            shippingMethod.IsDeleted = false;
            shippingMethod.CreatedAt = DateTime.UtcNow.AddHours(4);
            shippingMethod.CreatedBy = "System";


            await _context.ShippingMethods.AddAsync(shippingMethod);
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

            ShippingMethod shippingMethod = await _context.ShippingMethods.FirstOrDefaultAsync(sm => sm.IsDeleted == false && sm.Id == id);

            if (shippingMethod == null)
            {
                return NotFound("Id is wrong");
            }

            return View(shippingMethod);
        }

        [HttpPost]
        public async Task<IActionResult> Update(ShippingMethod shippingMethod, int? id)
        {


            if (!ModelState.IsValid)
            {
                return View(shippingMethod);
            }
            if (id == null)
            {
                return BadRequest("Id can't be null");
            }

            if (shippingMethod.Id != id)
            {
                return BadRequest("Id must be equal");
            }
            if (await _context.ShippingMethods.AnyAsync(sm => sm.IsDeleted == false && sm.Title.ToLower() == shippingMethod.Title.ToLower().Trim() && sm.Id != id))
            {
                ModelState.AddModelError("Title", $"This title = {shippingMethod.Title} already exists ");
                return View(shippingMethod);
            }


            ShippingMethod existedshipping = await _context.ShippingMethods.FirstOrDefaultAsync(sm => sm.IsDeleted == false && sm.Id == id);

            if (existedshipping == null)
            {
                return NotFound("Id is wrong");
            }


            existedshipping.Title = shippingMethod.Title.Trim();
            existedshipping.Description = shippingMethod.Description.Trim();
            existedshipping.UpdatedAt = DateTime.UtcNow.AddHours(4);
            existedshipping.UpdatedBy = "System";

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

            ShippingMethod shippingMethod = await _context.ShippingMethods.FirstOrDefaultAsync(sm => sm.IsDeleted == false && sm.Id == id);

            if (shippingMethod == null)
            {
                return NotFound("no data");
            }



            shippingMethod.IsDeleted = true;
            shippingMethod.DeletedBy = "";
            shippingMethod.DeletedAt = DateTime.UtcNow.AddHours(4);

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return BadRequest("Id can't be null");
            }


            ShippingMethod shippingMethod = await _context.ShippingMethods.FirstOrDefaultAsync(sm => sm.IsDeleted == false && sm.Id == id);



            if (shippingMethod == null)
            {
                return NotFound("Id is wrong");
            }

            return View(shippingMethod);
        }
    }

}
