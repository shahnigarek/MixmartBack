using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MixmartBackEnd.DAL;
using MixmartBackEnd.Models;
using MixmartBackEnd.ViewModels;
using MixmartBackEnd.ViewModels.BlogDetailVM;
using MixmartBackEnd.ViewModels.BlogVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Controllers
{
    public class BlogController : Controller
    {

        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        public BlogController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index(int pageIndex)
        {

            IQueryable<Blog> blogs = _context.Blogs.Where(b => b.IsDeleted == false).
              Include(b => b.BlogCategories).ThenInclude(b => b.BCategory);



            return View(PageNationList<Blog>.Create(blogs, pageIndex, 3));
        }
        public async Task<IActionResult> Detail(int id)
        {
            BlogDetailVM blogdetailVM = new BlogDetailVM()
            {
                Blog = await _context.Blogs.Where(b => b.IsDeleted == false && b.Id == id)
                .Include(b => b.Comments).ThenInclude(b => b.AppUser).
                Include(b => b.BlogCategories).ThenInclude(b => b.BCategory).FirstOrDefaultAsync(),
                Comments = await _context.Comments.Include(c => c.Blog).Include(c => c.AppUser).Where(c => c.BlogId == id).ToListAsync()
            };


            return View(blogdetailVM);
        }
        [Authorize]
        [AutoValidateAntiforgeryToken]
        [HttpPost]
        public async Task<IActionResult> AddComment(Comment comment, int id)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (!ModelState.IsValid) return RedirectToAction("detail", "Blog", new { id = id });
            if (!_context.Blogs.Any(f => f.Id != id)) return NotFound();
            Comment cmnt = new Comment
            {
                Message = comment.Message,
                BlogId = id,
                Date = DateTime.Now,
                AppUserId = user.Id,
                IsAccess = true,
            };
            _context.Comments.Add(cmnt);
            _context.SaveChanges();
            return RedirectToAction("detail", "Blog", new { id = id });
        }
        [Authorize]
        public async Task<IActionResult> DeleteComment(int id)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (!ModelState.IsValid) return RedirectToAction("Index", "Blog");
            if (!_context.Comments.Any(c => c.Id == id && c.IsAccess == true && c.AppUserId == user.Id)) return NotFound();
            Comment comment = _context.Comments.FirstOrDefault(c => c.Id == id && c.AppUserId == user.Id);
            _context.Comments.Remove(comment);
            _context.SaveChanges();
            return RedirectToAction("detail", "Blog", new { id = comment.BlogId });
        }
      


    }
}
