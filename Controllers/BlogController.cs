using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MixmartBackEnd.DAL;
using MixmartBackEnd.Models;
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
        public async Task<IActionResult> Index()
        {
            BlogVM blogVM = new BlogVM()
            {
                Blogs = await _context.Blogs.Where(b => b.IsDeleted == false).Include(b => b.BlogCategories).ThenInclude(b => b.BCategory).ToListAsync(),      
            };


            return View(blogVM);
        }
        public async Task<IActionResult> Detail(int id)
        {
            BlogDetailVM blogdetailVM = new BlogDetailVM()
            {
                Blog = await _context.Blogs.Where(b => b.IsDeleted == false && b.Id == id)
                .Include(b=>b.Comments).ThenInclude(b=>b.AppUser)
                .Include(b => b.BlogCategories).ThenInclude(b => b.BCategory).FirstOrDefaultAsync(),
                Comments = await _context.Comments.Include(c => c.Blog).Include(c => c.AppUser).Where(c => c.BlogId == id).ToListAsync()
            };


            return View(blogdetailVM);
        }
        [Authorize]
        [AutoValidateAntiforgeryToken]
        [HttpPost]
        public async Task<IActionResult> AddComment(Comment comment,int id)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (!ModelState.IsValid) return RedirectToAction("detail", "Blog",new { id = id });
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
            return RedirectToAction("detail", "Blog",new { id=id});
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
            return RedirectToAction("detail", "Blog",new { id = comment.BlogId });
        }
        //public IActionResult PreviousPost(int id)
        //{
        //    var posts = _context.Blogs.OrderBy(p => p.Date).ToList();
        //    var index = posts.FindIndex(p => p.Id == id);
        //    if (index == -1)
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    var previousPost = index > 0 ? posts[index - 1] : null;
        //    return previousPost != null ? RedirectToAction("Details", new { id = previousPost.Id }) : RedirectToAction("Index");
        //}

        //public IActionResult NextPost(int id)
        //{
        //    var posts = _context.Blogs.OrderBy(p => p.Date).ToList();
        //    var index = posts.FindIndex(p => p.Id == id);
        //    if (index == -1)
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    var nextPost = index < posts.Count - 1 ? posts[index + 1] : null;
        //    return nextPost != null ? RedirectToAction("Details", new { id = nextPost.Id }) : RedirectToAction("Index");
        //}

    }
}
