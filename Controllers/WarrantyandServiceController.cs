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
    public class WarrantyandServiceController : Controller
    {
        private readonly AppDbContext _context;
        public WarrantyandServiceController(AppDbContext context)
        {
            _context = context;
        }
        public async Task< IActionResult> Index()
        {
            IEnumerable<WarrantyandService> warrantyandServices = await _context.WarrantyandServices.Where(ws => ws.IsDeleted == false).ToListAsync();
            return View(warrantyandServices);
        }
    }
}
