using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MixmartBackEnd.Models;
using MixmartBackEnd.ViewModels.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task< IActionResult> Register(RegisterVM registerVM)
        {
            if (ModelState.IsValid)
            {
                return View();
            }

            AppUser appUser = new AppUser
            {
                Name = registerVM.Name,
                Surname =registerVM.Surname,
                Age =registerVM.Age,
                Email = registerVM.Email,
                UserName = registerVM.UserName
            };
            IdentityResult identityResult=await _userManager.CreateAsync(appUser, registerVM.Password);
            if (!identityResult.Succeeded)
            {
                foreach (var item in identityResult.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View();
            }
            await _userManager.AddToRoleAsync(appUser, "Member");

            return RedirectToAction("login");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            AppUser appUser = await _userManager.FindByEmailAsync(loginVM.Email);

            if (appUser == null)
            {
                ModelState.AddModelError("", "Daxil Etdiyniz Email ve ya Sifre Yanlisdir");
                return View(loginVM);
            }

            Microsoft.AspNetCore.Identity.SignInResult signInResult=  await _signInManager.PasswordSignInAsync(appUser, loginVM.Password,loginVM.RemindMe,true);

            if (signInResult.IsLockedOut)
            {
                ModelState.AddModelError("", "Your account blocked");
                return View(loginVM);
            }
            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Daxil Etdiyniz Email ve ya Sifre Yanlisdir");
                return View(loginVM);
            }


            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        [Authorize(Roles = "Member")]
        public async Task<IActionResult> Profile()
        {
            AppUser appUser = await _userManager.Users
                .FirstOrDefaultAsync(u => u.UserName == User.Identity.Name);

            ProfileVM profileVM = new ProfileVM
            {
                Name = appUser.Name,
                Surname = appUser.Surname,
                Age = appUser.Age,
                UserName = appUser.UserName,
                Email = appUser.Email
            };

       
            return View(profileVM);
        }

        [HttpPost]
        [Authorize(Roles = "Member")]
        public async Task<IActionResult> Update(ProfileVM profileVM)
        {
            if (!ModelState.IsValid) return View("Profile");

            AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);

            appUser.Name = profileVM.Name;
            appUser.Surname = profileVM.Surname;
            appUser.UserName = profileVM.UserName;
            appUser.Email = profileVM.Email;
            appUser.Age = profileVM.Age;

            IdentityResult identityResult = await _userManager.UpdateAsync(appUser);

            if (!identityResult.Succeeded)
            {
                foreach (var item in identityResult.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }

                return View("Profile");
            }

            if (profileVM.CurrentPassword != null)
            {
                if (profileVM.NewPassword == null)
                {
                    ModelState.AddModelError("NewPassword", "Is Requered");
                    ModelState.AddModelError("ConfirmPassword", "Is Requered");

                    return View("Profile");
                }

                if (!await _userManager.CheckPasswordAsync(appUser, profileVM.CurrentPassword))
                {
                    ModelState.AddModelError("CurrentPassword", "Current Password Is InCorrect");
                    return View("Profile");
                }

                identityResult = await _userManager.ChangePasswordAsync(appUser, profileVM.CurrentPassword, profileVM.NewPassword);

                if (!identityResult.Succeeded)
                {
                    foreach (var item in identityResult.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }

                    return View("Profile");
                }
            }

            return RedirectToAction("Profile");
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
        //public async Task<IActionResult> CreateRole()
        //{
        //    await _roleManager.CreateAsync(new IdentityRole { Name = "Member" });

        //     return Ok();
        //}
        public async Task<IActionResult> CreateMember()
        {
            AppUser appUser = new AppUser
            {
                Email = "shahnigarek@code.edu.az",
                Name = "Nigar",
                Surname = "Kazimli",
                Age = 20,
                UserName = "Nigarek"
            };

            await _userManager.CreateAsync(appUser, "Nigar19@@@123");
            await _userManager.AddToRoleAsync(appUser, "Member");

            return Ok();
        }
    }
}
