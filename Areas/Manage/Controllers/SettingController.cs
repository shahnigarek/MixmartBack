using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MixmartBackEnd.DAL;
using MixmartBackEnd.Extention;
using MixmartBackEnd.Helpers;
using MixmartBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Areas.Manage.Controllers
{
    [Area("manage")]
    public class SettingController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SettingController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Setting> setting = await _context.Settings.ToListAsync();
            return View(setting);
        }
        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            Setting setting = await _context.Settings.FirstOrDefaultAsync(s => s.Id == id);
            if (setting == null)
            {
                return NotFound();
            }

            return View(setting);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Setting setting, int? id)
        {
            if (!ModelState.IsValid)
            {
                return View(setting);
            }

            if (id == null)
            {
                return BadRequest("Id can't be null !");

            };

            var existedsettings = await _context.Settings.FirstOrDefaultAsync(s => s.Id == id && s.Key == setting.Key);

            if (existedsettings == null)
            {

                return NotFound("Included Id is wrong !");
            }


            if (setting.Key == "Logo")
            {
                if (setting.File != null)
                {
                    if (!setting.File.CheckFileSize(2000))
                    {
                        ModelState.AddModelError("File", "The size of the image should not be more than 2mb.");
                        return View();
                    }
                    if (!setting.File.CheckFileType("image/jpeg"))
                    {
                        ModelState.AddModelError("File", "Select image jpeg type file ! ");
                        return View();
                    }
                    FileHelper.DeleteFile(_env, setting.Value, "assets", "img", "Logo");
                    existedsettings.Value = setting.File.CreateImage(_env, "assets", "img", "Logo");
                }
            }

            if (setting.Key == "Logo1")
            {
                if (setting.File != null)
                {
                    if (!setting.File.CheckFileSize(2000))
                    {
                        ModelState.AddModelError("File", "The size of the image should not be more than 2mb.");
                        return View();
                    }
                    if (!setting.File.CheckFileType("image/jpeg"))
                    {
                        ModelState.AddModelError("File", "Select image jpeg type file ! ");
                        return View();
                    }
                    FileHelper.DeleteFile(_env, setting.Value, "assets", "img", "footer-logo");
                    existedsettings.Value = setting.File.CreateImage(_env, "assets", "img", "footer-logo");
                }
            }

            existedsettings.Value = setting.Value;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }

}
