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
    public class PaymentMethodController : Controller
    {
        private readonly AppDbContext _context;
        public PaymentMethodController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {

            IEnumerable<PaymentMethod> paymentMethods = await _context.PaymentMethods.Where(pm => pm.IsDeleted == false).ToListAsync();
            return View(paymentMethods);
        }

       
      
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest("Id can't be null");
            }

            PaymentMethod payment = await _context.PaymentMethods.FirstOrDefaultAsync(pm => pm.IsDeleted == false && pm.Id == id);

            if (payment == null)
            {
                return NotFound("no data");
            }



            payment.IsDeleted = true;
            payment.DeletedBy = "";
            payment.DeletedAt = DateTime.UtcNow.AddHours(4);

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

      
    }
}
