using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MixmartBackEnd.DAL;
using MixmartBackEnd.Models;
using MixmartBackEnd.ViewModels.Account;
using MixmartBackEnd.ViewModels.Basket;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Controllers
{
    public class AccountController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;


        public AccountController(RoleManager<IdentityRole> roleManager, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, AppDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid) return View();

            AppUser appUser = new AppUser
            {
                Name = registerVM.Name,
                Surname = registerVM.Surname,
                Age = registerVM.Age,
                Email = registerVM.Email,
                UserName = registerVM.UserName
            };
            if (registerVM.Age < 18 && registerVM.Age > 0)
            {
                ModelState.AddModelError("Age", "Back when you will turn 18 :))");
                return View(registerVM);
            }
            IdentityResult identityResult = await _userManager.CreateAsync(appUser, registerVM.Password);

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
            if (!ModelState.IsValid) return View();
            var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
            AppUser appUser = await _userManager.Users.Include(u => u.Baskets).FirstOrDefaultAsync(u => u.NormalizedEmail == loginVM.Email.Trim().ToUpperInvariant() && !u.IsAdmin);

                if (appUser == null)
                {
                    ModelState.AddModelError("", "Email Or Password Is InCorrect ");
                    return View(loginVM);
                }

            if (!appUser.IsDeActive  )
            {


                if (!await _userManager.CheckPasswordAsync(appUser, loginVM.Password))
                {
                    ModelState.AddModelError("", "Email Or Password Is InCorrect");
                    return View(loginVM);
                }

                await _signInManager.SignInAsync(appUser, loginVM.RemindMe);

                string basketCoockie = HttpContext.Request.Cookies["basket"];

                if (!string.IsNullOrWhiteSpace(basketCoockie))
                {
                    List<BasketVM> basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(basketCoockie);

                    List<Basket> baskets = new List<Basket>();

                    foreach (BasketVM basketVM in basketVMs)
                    {
                        if (appUser.Baskets != null && appUser.Baskets.Count() > 0)
                        {
                            Basket exsitedBasket = appUser.Baskets.FirstOrDefault(b => b.ProductId != basketVM.ProductId);

                            if (exsitedBasket == null)
                            {
                                Basket basket = new Basket
                                {
                                    AppUserId = appUser.Id,
                                    ProductId = basketVM.ProductId,
                                    Count = basketVM.Count
                                };

                                baskets.Add(basket);
                            }
                            else
                            {
                                exsitedBasket.Count += basketVM.Count;
                                basketVM.Count = exsitedBasket.Count;
                            }
                        }
                        else
                        {
                            Basket basket = new Basket
                            {
                                AppUserId = appUser.Id,
                                ProductId = basketVM.ProductId,
                                Count = basketVM.Count
                            };

                            baskets.Add(basket);
                        }
                    }

                    basketCoockie = JsonConvert.SerializeObject(basketVMs);

                    HttpContext.Response.Cookies.Append("basket", basketCoockie);

                    await _context.Baskets.AddRangeAsync(baskets);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    if (appUser.Baskets != null && appUser.Baskets.Count() > 0)
                    {
                        List<BasketVM> basketVMs = new List<BasketVM>();

                        foreach (Basket basket in appUser.Baskets)
                        {
                            BasketVM basketVM = new BasketVM
                            {
                                ProductId = basket.ProductId,
                                Count = basket.Count
                            };

                            basketVMs.Add(basketVM);
                        }

                        basketCoockie = JsonConvert.SerializeObject(basketVMs);

                        HttpContext.Response.Cookies.Append("basket", basketCoockie);
                    }
                }

            }
            else
            {
                ModelState.AddModelError("", "You cannot login because you have been deactivated by the superadmin.");
                return View(loginVM);

            }
            return RedirectToAction("index", "home");

        }
        public async Task<IActionResult> Profile()
        {
            var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
            AppUser appUser = await _userManager.Users.Include(u => u.Baskets).FirstOrDefaultAsync(u => u.UserName == user.UserName);

            if (appUser == null) return NotFound();

            ProfileVM profileVM = new ProfileVM
            {
                Name = appUser.Name,
                Surname = appUser.Surname,
                Email = appUser.Email,
                UserName = appUser.UserName,
                Age = appUser.Age
            };

            return View(profileVM);
        }

        [HttpPost]
        public async Task<IActionResult> Profile(ProfileVM profileVM)
        {
            if (!ModelState.IsValid) return View("Profile", profileVM);
            var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
            AppUser dbAppUser = await _userManager.Users.Include(u => u.Baskets).FirstOrDefaultAsync(u => u.UserName == user.UserName);

            if (dbAppUser.NormalizedUserName != profileVM.UserName.Trim().ToUpperInvariant() ||
                dbAppUser.Name.ToUpperInvariant() != profileVM.Name.Trim().ToUpperInvariant() ||
                dbAppUser.Surname.ToUpperInvariant() != profileVM.Surname.Trim().ToUpperInvariant() ||
                dbAppUser.NormalizedEmail != profileVM.Email.Trim().ToUpperInvariant() ||
                dbAppUser.Age != profileVM.Age)
            {
                dbAppUser.Name = profileVM.Name;
                dbAppUser.Surname = profileVM.Surname;
                dbAppUser.Email = profileVM.Email;
                dbAppUser.UserName = profileVM.UserName;
                dbAppUser.Age = profileVM.Age;

                IdentityResult identityResult = await _userManager.UpdateAsync(dbAppUser);

                if (!identityResult.Succeeded)
                {
                    foreach (var item in identityResult.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }

                    return View("Profile", profileVM);
                }

                TempData["success"] = "Pr0fil Ugurla Yenilendi";
            }

            if (profileVM.CurrentPassword != null && profileVM.NewPassword != null)
            {
                if (await _userManager.CheckPasswordAsync(dbAppUser, profileVM.CurrentPassword) && profileVM.CurrentPassword == profileVM.NewPassword)
                {
                    ModelState.AddModelError("", "New Password Is The Same Current Password");
                    return View("Profile", profileVM);
                }

                IdentityResult identityResult = await _userManager.ChangePasswordAsync(dbAppUser, profileVM.CurrentPassword, profileVM.NewPassword);

                if (!identityResult.Succeeded)
                {
                    foreach (var item in identityResult.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }

                    return View("Profile", profileVM);
                }

                TempData["successPassword"] = "Sifre Ugurla Yenilendi";
            }

            return RedirectToAction("Profile");
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("index", "home");
        }

        #region Create Role
        //public async Task<IActionResult> CreateRole()
        //{
        //    await _roleManager.CreateAsync(new IdentityRole { Name = "SuperAdmin" });
        //    await _roleManager.CreateAsync(new IdentityRole { Name = "Admin" });
        //    await _roleManager.CreateAsync(new IdentityRole { Name = "Member" });

        //    return Content("Roles Successfuly Created");
        //}
        #endregion

    }
}
