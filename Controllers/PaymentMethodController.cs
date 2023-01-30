using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MixmartBackEnd.DAL;
using MixmartBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Controllers
{
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
    }
}
