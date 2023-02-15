using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MixmartBackEnd.DAL;
using MixmartBackEnd.Models;
using MixmartBackEnd.ViewModels.Wishlist;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Controllers
{
    public class WishlistController : Controller
    {
        private readonly AppDbContext _context;

        public WishlistController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AddToWishlist(int? id)
        {
            if (id == null)
            {
                return BadRequest("Id can't be null");
            }


            if (!await _context.Products.AnyAsync(p => p.IsDeleted == false && p.Id == id))
            {
                return NotFound("Id is wrong");
            }

            string wishlist = HttpContext.Request.Cookies["wishlist"];
            List<WishlistVM> products = null;

            if (!string.IsNullOrWhiteSpace(wishlist))
            {
                products = JsonConvert.DeserializeObject<List<WishlistVM>>(wishlist);
                WishlistVM wishlistVM = products.Find(p => p.Id == id);
                if (wishlistVM != null)
                {
                    wishlistVM.Count += 1;
                }
                else
                {
                    wishlistVM = new WishlistVM
                    {
                        Id = (int)id,
                        Count = 1
                    };

                    products.Add(wishlistVM);
                }
            }
            else
            {
                products = new List<WishlistVM>();
                WishlistVM wishlistVM = new WishlistVM
                {
                    Id = (int)id,
                    Count = 1
                };
                products.Add(wishlistVM);
            }

            wishlist = JsonConvert.SerializeObject(products);
            HttpContext.Response.Cookies.Append("wishlist", wishlist);

            foreach (WishlistVM wishlistVM in products)
            {
                Product product = await _context.Products.FirstOrDefaultAsync(p => p.Id == wishlistVM.Id && p.IsDeleted == false);

                wishlistVM.Title = product.Title;
                wishlistVM.Image = product.Image;
                wishlistVM.Price = product.DiscountedPrice > 0 ? product.DiscountedPrice : product.Price;
            }

            return PartialView("_BasketCartPartial", products);
        }
    }
}
