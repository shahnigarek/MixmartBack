using Microsoft.AspNetCore.Mvc;
using MixmartBackEnd.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Areas.Manage.Controllers
{
    [Area("manage")]
    public class InstagramController : Controller
    {
        private readonly AppDbContext _context;
        public InstagramController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
