using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Areas.Manage.Controllers
{
    public class DashboardController : Controller
    {
        [Area("manage")]
        public IActionResult Index()
        {
            if (User.IsInRole("Member"))
            {

                return NotFound();

            }
            else
            {
            return View();
            }
        }
    }
}
