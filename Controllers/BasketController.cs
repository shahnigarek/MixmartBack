using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MixmartBackEnd.DAL;
using MixmartBackEnd.Models;
using MixmartBackEnd.ViewModels.Basket;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Controllers
{

    public class BasketController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public BasketController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            string basket = HttpContext.Request.Cookies["basket"];

            List<BasketVM> basketVMs = null;

            if (!string.IsNullOrWhiteSpace(basket))
            {
                basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
            }
            else
            {
                basketVMs = new List<BasketVM>();
            }

            return View(await _getBasketItemAsync(basketVMs));
        }

        public async Task<IActionResult> AddToBasket(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            Product product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            string basket = HttpContext.Request.Cookies["basket"];

            List<BasketVM> basketVMs = null;

            if (!string.IsNullOrWhiteSpace(basket))
            {
                basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
            }
            else
            {
                basketVMs = new List<BasketVM>();
            }

            if (basketVMs.Exists(b => b.ProductId == id))
            {
                basketVMs.Find(b => b.ProductId == id).Count++;
            }
            else
            {
                BasketVM basketVM = new BasketVM
                {
                    ProductId = product.Id,
                    Count = 1
                };

                basketVMs.Add(basketVM);
            }

            if (User.Identity.IsAuthenticated)
            {
                AppUser appUser = await _userManager.Users.Include(u => u.Baskets).FirstOrDefaultAsync(u => u.UserName == User.Identity.Name);

                if (appUser.Baskets != null && appUser.Baskets.Count() > 0)
                {
                    Basket dbBasket = appUser.Baskets.FirstOrDefault(b => b.ProductId == id);

                    if (dbBasket != null)
                    {
                        dbBasket.Count += 1;
                    }
                    else
                    {
                        Basket newBasket = new Basket
                        {
                            ProductId = (int)id,
                            Count = 1
                        };

                        appUser.Baskets.Add(newBasket);
                    }
                }
                else
                {
                    List<Basket> baskets = new List<Basket>
                    {
                        new Basket{ProductId = (int)id, Count = 1}
                    };

                    appUser.Baskets = baskets;
                }

                await _context.SaveChangesAsync();
            }

            basket = JsonConvert.SerializeObject(basketVMs);

            HttpContext.Response.Cookies.Append("basket", basket);

            return PartialView("_BasketPartial", await _getBasketItemAsync(basketVMs));
        }

        public async Task<IActionResult> GetBasket()
        {
            string basket = Request.Cookies["basket"];

            List<BasketVM> basketVMs = null;

            if (!string.IsNullOrWhiteSpace(basket))
            {
                basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
            }
            else
            {
                basketVMs = new List<BasketVM>();
            }

            if (User.Identity.IsAuthenticated)
            {
                AppUser appUser = await _userManager.Users.Include(u => u.Baskets).FirstOrDefaultAsync(u => u.UserName == User.Identity.Name);

                if (appUser.Baskets != null && appUser.Baskets.Count() > 0)
                {
                    foreach (var item in appUser.Baskets)
                    {
                        if (!basketVMs.Any(b => b.ProductId == item.ProductId))
                        {
                            BasketVM basketVM = new BasketVM
                            {
                                ProductId = item.ProductId,
                                Count = item.Count
                            };

                            basketVMs.Add(basketVM);
                        }
                    }

                    basket = JsonConvert.SerializeObject(basketVMs);

                    Response.Cookies.Append("basket", basket);
                }
            }

            return PartialView("_BasketPartial", await _getBasketItemAsync(basketVMs));
        }

        public async Task<IActionResult> DeleteFromBasket(int? id)
        {
            if (id == null) return BadRequest();

            if (!await _context.Products.AnyAsync(p => p.Id == id)) return NotFound();

            string basket = HttpContext.Request.Cookies["basket"];

            if (string.IsNullOrWhiteSpace(basket)) return BadRequest();

            List<BasketVM> basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(basket);

            BasketVM basketVM = basketVMs.Find(b => b.ProductId == id);

            if (basketVM == null) return NotFound();

            basketVMs.Remove(basketVM);

            basket = JsonConvert.SerializeObject(basketVMs);
            HttpContext.Response.Cookies.Append("basket", basket);

            return PartialView("_BasketPartial", await _getBasketItemAsync(basketVMs));
        }

        public async Task<IActionResult> UpdateCount(int? id, int count)
        {
            if (id == null) return BadRequest();

            if (!await _context.Products.AnyAsync(p => p.Id == id)) return NotFound();

            string basket = HttpContext.Request.Cookies["basket"];

            List<BasketVM> basketVMs = null;

            if (!string.IsNullOrWhiteSpace(basket))
            {
                basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(basket);

                BasketVM basketVM = basketVMs.FirstOrDefault(b => b.ProductId == id);

                if (basketVM == null) return NotFound();

                basketVM.Count = count <= 0 ? 1 : count;

                basket = JsonConvert.SerializeObject(basketVMs);

                HttpContext.Response.Cookies.Append("basket", basket);
            }
            else
            {
                return BadRequest();
            }

            return PartialView("_BasketIndexPartial", await _getBasketItemAsync(basketVMs));
        }
        public async Task<IActionResult> DeleteFromCart(int? id)
        {
            if (id == null) return BadRequest();

            if (!await _context.Products.AnyAsync(p => p.Id == id)) return NotFound();

            string basket = HttpContext.Request.Cookies["basket"];

            if (string.IsNullOrWhiteSpace(basket)) return BadRequest();

            List<BasketVM> basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(basket);

            BasketVM basketVM = basketVMs.Find(b => b.ProductId == id);

            if (basketVM == null) return NotFound();

            basketVMs.Remove(basketVM);

            basket = JsonConvert.SerializeObject(basketVMs);
            HttpContext.Response.Cookies.Append("basket", basket);

            return PartialView("_BasketIndexPartial", await _getBasketItemAsync(basketVMs));
        }
        private async Task<List<BasketVM>> _getBasketItemAsync(List<BasketVM> basketVMs)
        {
            if (User.Identity.IsAuthenticated)
            {
                AppUser appUser = await _userManager.Users.Include(u => u.Baskets).FirstOrDefaultAsync(u => u.UserName == User.Identity.Name);


            }


            foreach (BasketVM item in basketVMs)
            {
                Product dbProduct = await _context.Products.FirstOrDefaultAsync(p => p.Id == item.ProductId);

                item.Title = dbProduct.Title;
                item.Price = dbProduct.DiscountedPrice > 0 ? dbProduct.DiscountedPrice : dbProduct.Price;
                item.Image = dbProduct.Image;
            }

            return basketVMs;
        }
    }
}
