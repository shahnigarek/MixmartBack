using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MixmartBackEnd.Areas.Manage.ViewModels.Account;
using MixmartBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Areas.Manage.Controllers
{
    [Area("manage")]
    [Authorize(Roles = "SuperAdmin")]
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public UserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> Index(bool? status)
        {
            List<AppUser> query = await _userManager.Users.Where(u => u.UserName != User.Identity.Name).ToListAsync();

            if (status != null)
            {
                query = query.Where(b => b.IsDeActive == status).ToList();
            }

            ViewBag.Status = status;

            foreach (AppUser item in query)
            {
                var roles = await _userManager.GetRolesAsync(item);
                item.Role = roles[0];
            }

            return View(query);
        }

        [HttpGet]
        public async Task<IActionResult> ResetPassword(string id)
        {
            if (string.IsNullOrWhiteSpace(id)) return BadRequest();

            AppUser appUser = await _userManager.FindByIdAsync(id);

            if (appUser == null) return NotFound();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(string id, ResetPasswordVM resetPasswordVM)
        {
            if (!ModelState.IsValid) return View();

            if (string.IsNullOrWhiteSpace(id)) return BadRequest();

            AppUser appUser = await _userManager.FindByIdAsync(id);

            if (appUser == null) return NotFound();

            string token = await _userManager.GeneratePasswordResetTokenAsync(appUser);

            await _userManager.ResetPasswordAsync(appUser, token, resetPasswordVM.Password);

            return RedirectToAction("index");
        }
        [HttpGet]
        public async Task<IActionResult> Deactivate(string id)
        {
            if (string.IsNullOrWhiteSpace(id)) return BadRequest();

            AppUser appUser = await _userManager.FindByIdAsync(id);

            if (appUser == null) return NotFound();

            appUser.IsDeActive = true;

            await _userManager.UpdateAsync(appUser);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Activate(string id, bool? status)
        {
            if (string.IsNullOrWhiteSpace(id)) return BadRequest();

            AppUser appUser = await _userManager.FindByIdAsync(id);

            if (appUser == null) return NotFound();

            appUser.IsDeActive = false;

            await _userManager.UpdateAsync(appUser);

            return RedirectToAction("Index", new { status });
        }


    }
}
