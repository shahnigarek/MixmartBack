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

        public async Task< IActionResult> Index()
        {

            string wishlist = Request.Cookies["wishlist"];

            List<WishlistVM> wishlistVMs = null;

            if (!string.IsNullOrWhiteSpace(wishlist))
            {
                wishlistVMs = JsonConvert.DeserializeObject<List<WishlistVM>>(wishlist);
            }
            else
            {
                wishlistVMs = new List<WishlistVM>();
            }

            return View(await _getWishlistAsync(wishlist));
        }
        public async Task<IActionResult> GetWishlist()
        {
            string wishlist = Request.Cookies["wishlist"];

            if (string.IsNullOrWhiteSpace(wishlist))
            {
                return BadRequest();
            }

            return PartialView("_WishlistIndexPartial", await _getWishlistAsync(wishlist));
        }

        public async Task<IActionResult> AddToWishlist(int? id)
        {
            if (id == null) return BadRequest();

            Product product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);

            if (product == null) return NotFound();

            List<WishlistVM> wishlistVMs = null;

            string coockie = HttpContext.Request.Cookies["wishlist"];

            if (!string.IsNullOrWhiteSpace(coockie))
            {
                wishlistVMs = JsonConvert.DeserializeObject<List<WishlistVM>>(coockie);

                if (wishlistVMs.Exists(b => b.Id == id))
                {
                    wishlistVMs.Find(b => b.Id == id).Count++;
                }
                else
                {
                    WishlistVM wishlistVM = new WishlistVM
                    {
                        Id = (int)id,
                        Count = 1
                    };

                    wishlistVMs.Add(wishlistVM);
                }
            }
            else
            {
                wishlistVMs = new List<WishlistVM>();

                WishlistVM wishlistVM = new WishlistVM
                {
                    Id = (int)id,
                    Count = 1
                };

                wishlistVMs.Add(wishlistVM);
            }

            string item = JsonConvert.SerializeObject(wishlistVMs);

            HttpContext.Response.Cookies.Append("wishlist", item);

            return PartialView("_WishlistIndexPartial", await _getWishlistAsync(item));
        }
        public async Task<IActionResult> DeleteFromWishlist(int? id)
        {
            if (id == null) return BadRequest();

            if (!await _context.Products.AnyAsync(p => p.Id == id)) return NotFound();

            string coockie = HttpContext.Request.Cookies["wishlist"];

            if (!string.IsNullOrWhiteSpace(coockie))
            {
                List<WishlistVM> wishlistVMs = JsonConvert.DeserializeObject<List<WishlistVM>>(coockie);

                WishlistVM   wishlistVM = wishlistVMs.FirstOrDefault(b => b.Id == id);

                if (wishlistVM == null) return NotFound();

                wishlistVMs.Remove(wishlistVM);

                coockie = JsonConvert.SerializeObject(wishlistVMs);

                HttpContext.Response.Cookies.Append("wishlist", coockie);

                return PartialView("_WishlistIndexPartial", await _getWishlistAsync(coockie));
            }
            else
            {
                return BadRequest();
            }
        }
        private async Task<List<WishlistVM>> _getWishlistAsync(string coockie)
        {
            List<WishlistVM> wishlistVMs = null;

            if (!string.IsNullOrWhiteSpace(coockie))
            {
                wishlistVMs = JsonConvert.DeserializeObject<List<WishlistVM>>(coockie);
            }
            else
            {
                wishlistVMs = new List<WishlistVM>();
            }

            foreach (WishlistVM wishlistVM in wishlistVMs)
            {
                Product product = await _context.Products.FirstOrDefaultAsync(p => p.Id == wishlistVM.Id);

                wishlistVM.Image = product.Image;
                wishlistVM.Price = product.DiscountedPrice > 0 ? product.DiscountedPrice : product.Price;
                wishlistVM.Title = product.Title;
            }

            return wishlistVMs;
        }

    }
}
