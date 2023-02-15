using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MixmartBackEnd.DAL;
using MixmartBackEnd.Models;
using MixmartBackEnd.ViewModels.Basket;
using MixmartBackEnd.ViewModels.Header;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public HeaderViewComponent(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync(IDictionary<string, string> settings)
        {

            List<BasketVM> basketVMs = null;

            string basket = HttpContext.Request.Cookies["basket"];

            if (!string.IsNullOrWhiteSpace(basket))
            {
                basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(basket);

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

                        HttpContext.Response.Cookies.Append("basket", basket);
                    }
                }

                foreach (BasketVM basketVM in basketVMs)
                {
                    Product product = await _context.Products.FirstOrDefaultAsync(p => p.Id == basketVM.ProductId);

                    basketVM.Image = product.Image;
                    basketVM.Title = product.Title;
                    basketVM.Price = product.DiscountedPrice > 0 ? product.DiscountedPrice : product.Price;
                }
            }
            else
            {
                basketVMs = new List<BasketVM>();
            }

            HeaderVM headerVM = new HeaderVM
            {
                Settings = settings,
                BasketVMs = basketVMs
            };
            return View(await Task.FromResult(headerVM));
        }
    }
}

