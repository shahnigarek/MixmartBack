using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MixmartBackEnd.DAL;
using MixmartBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Areas.Manage.Controllers
{
    [Area("manage")]
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        public ContactController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            IEnumerable<Contact> contact = _context.Contacts.ToList();
            return View(contact);
        }

        public IActionResult Delete(int id)
        {
            Contact contact = _context.Contacts.SingleOrDefault(c => c.Id == id);
            if (contact == null) return Json(new { status = 404 });

            _context.Contacts.Remove(contact);
            _context.SaveChanges();

            return Json(new { status = 200 });

        }
    }
}
