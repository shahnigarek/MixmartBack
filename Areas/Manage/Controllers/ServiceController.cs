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
    public class ServiceController : Controller
    {
        private readonly AppDbContext _context;
        public ServiceController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Service> services = await _context.Services.Where(s => s.IsDeleted == false).ToListAsync();
            return View(services);
        }

     

        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return BadRequest("Id can't be null");
            }

            Service service = await _context.Services.FirstOrDefaultAsync(s => s.IsDeleted == false && s.Id == id);

            if (service == null)
            {
                return NotFound("Id is wrong");
            }

            return View(service);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Service service, int? id)
        {


            if (!ModelState.IsValid)
            {
                return View();
            }
            if (id == null)
            {
                return BadRequest("Id can't be null");
            }

            if (service.Id != id)
            {
                return BadRequest("Id must be equal");
            }
            if (service.Icon == null)
            {
                ModelState.AddModelError("Icon", "It is important add icon  it can't be empty");
                return View(service);
            }
            if (service.Title == null)
            {
                ModelState.AddModelError("Title", "It is important add Title  it can't be empty");
                return View(service);
            }
            if (service.Description == null)
            {
                ModelState.AddModelError("Description", "It is important add Description  it can't be empty");
                return View(service);
            }
            if (await _context.Services.AnyAsync(s => s.IsDeleted == false && s.Title.ToLower() == service.Title.ToLower().Trim()))
            {
                ModelState.AddModelError("Title", $"This title = {service.Title} already exists ");
                return View(service);
            }



            Service existedservice = await _context.Services.FirstOrDefaultAsync(s => s.IsDeleted == false && s.Id == id);

            if (existedservice == null)
            {
                return NotFound("Id is wrong");
            }

            existedservice.Icon = service.Icon.Trim();
            existedservice.Title = service.Title.Trim();
            existedservice.Description = service.Description.Trim();
            existedservice.UpdatedAt = DateTime.UtcNow.AddHours(4);
            existedservice.UpdatedBy = "System";

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

            Service service = await _context.Services.FirstOrDefaultAsync(s => s.IsDeleted == false && s.Id == id);

            if (service == null)
            {
                return NotFound("no data");
            }



            service.IsDeleted = true;
            service.DeletedBy = "";
            service.DeletedAt = DateTime.UtcNow.AddHours(4);

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


    }
}
