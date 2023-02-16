using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MixmartBackEnd.Areas.Manage.ViewModels.Account;
using MixmartBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class AccountController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(RoleManager<IdentityRole> roleManager,
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid)
            {
                return View(registerVM);
            }

            AppUser appUser = new AppUser
            {
                Name = registerVM.Name,
                Email = registerVM.Email,
                Age=registerVM.Age,
                Surname=registerVM.Surname,
                UserName = registerVM.UserName
            };
            if (registerVM.Age<18 && registerVM.Age > 0)
            {
                ModelState.AddModelError("Age", "Age must be 18+");
                return View(registerVM);
            }

            IdentityResult identityResult = await _userManager.CreateAsync(appUser, registerVM.Password);
            if (!identityResult.Succeeded)
            {
                foreach (var item in identityResult.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View(registerVM);
            }

            await _userManager.AddToRoleAsync(appUser, "Admin");

            return RedirectToAction("login");
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid)
            {
                return View(loginVM);
            }

            AppUser appUser = await _userManager.FindByEmailAsync(loginVM.Email);

            if (appUser == null)
            {
                ModelState.AddModelError("", "Daxil Etdiyniz Email ve ya Sifre Yanlisdir");
                return View(loginVM);
            }

            Microsoft.AspNetCore.Identity.SignInResult signInResult = await _signInManager.CheckPasswordSignInAsync(appUser, loginVM.Password, true);


    

            if (signInResult.IsLockedOut)
            {
                ModelState.AddModelError("", "");
                return View(loginVM);
            }

            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Daxil Etdiyniz Email ve ya Sifre Yanlisdir");
                return View(loginVM);
            }

            signInResult = await _signInManager.PasswordSignInAsync(appUser, loginVM.Password, loginVM.RemindMe, true);

            return RedirectToAction("Index", "Dashboard", new { area = "manage" });
        }


        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Profile()
        {
            AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);

            ProfileVM profileVM = new ProfileVM
            {
                Name = appUser.Name,
                UserName = appUser.UserName,
                Email = appUser.Email,
                Age=appUser.Age,
                Surname=appUser.Surname
            };

            return View(profileVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Profile(ProfileVM profileVM)
        {
            if (!ModelState.IsValid)
            {
                return View(profileVM);
            }

            bool check = false;

            AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);

            if (appUser.Name.ToLowerInvariant() != profileVM.Name.Trim().ToLowerInvariant())
            {
                check = true;
                appUser.Name = profileVM.Name.Trim();
            }

            if (appUser.Surname.ToLowerInvariant() != profileVM.Surname.Trim().ToLowerInvariant())
            {
                check = true;
                appUser.Surname = profileVM.Surname.Trim();
            }

            if (appUser.Age != profileVM.Age)
            {
                check = true;
                appUser.Age = profileVM.Age;
            }

            if (appUser.NormalizedEmail != profileVM.Email.Trim().ToUpperInvariant())
            {
                check = true;
                appUser.Email = profileVM.Email.Trim();

            }

            if (appUser.NormalizedUserName != profileVM.UserName.Trim().ToUpperInvariant())
            {
                check = true;
                appUser.UserName = profileVM.UserName.Trim();
            }

            if (check)
            {
                IdentityResult identityResult = await _userManager.UpdateAsync(appUser);

                if (!identityResult.Succeeded)
                {
                    foreach (var item in identityResult.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                    return View(profileVM);
                }
            }

            if (!string.IsNullOrWhiteSpace(profileVM.CurrentPassword))
            {
                if (!await _userManager.CheckPasswordAsync(appUser, profileVM.CurrentPassword))
                {
                    ModelState.AddModelError("CurrentPassword", "Please Enter Right Password");
                    return View(profileVM);
                }

                if (profileVM.NewPassword == profileVM.CurrentPassword)
                {
                    ModelState.AddModelError("NewPassword", "Passwords aren't equal ");
                    return View(profileVM);
                }

                string token = await _userManager.GeneratePasswordResetTokenAsync(appUser);

                IdentityResult identityResult = await _userManager.ResetPasswordAsync(appUser, token, profileVM.NewPassword);

                if (!identityResult.Succeeded)
                {
                    foreach (var item in identityResult.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                    return View(profileVM);
                }
            }

            return RedirectToAction("Index", "Dashboard", new { area = "manage" });
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Dashboard", new { area = "manage" });
        }

    }
}

#region CreateRoleandSuperAdmin
//public async Task<IActionResult> CreateRole()
//{
//    await _roleManager.CreateAsync(new IdentityRole { Name = "SuperAdmin" });
//    await _roleManager.CreateAsync(new IdentityRole { Name = "Admin" });

//    return Ok();
//}

//public async Task<IActionResult> CreateSuperAdmin()
//{
//    AppUser appUser = new AppUser
//    {
//        Email = "shahnigarek@code.edu.az",
//        Name = "Shahnigar",
//        Surname = "Kazimli",
//        Age = 19,
//        UserName = "Shahnigarek"
//    };

//    await _userManager.CreateAsync(appUser, "Shahnigar19@@@123");
//    await _userManager.AddToRoleAsync(appUser, "SuperAdmin");

//    return Ok();
//}
#endregion