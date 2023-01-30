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
    public class ShippingMethodController : Controller
    {
        private readonly AppDbContext _context;
        public ShippingMethodController(AppDbContext context )
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable <ShippingMethod> shippingMethods= await _context.ShippingMethods.Where(sm => sm.IsDeleted == false).ToListAsync();
            return View(shippingMethods);
        }
    }
}
