﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MixmartBackEnd.DAL;
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
        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            BlogVM blogVM = new BlogVM()
            {
                Blogs = await _context.Blogs.Where(b => b.IsDeleted == false).ToListAsync(),
                Blog = await _context.Blogs.Where(b => b.IsDeleted == false).Include(b => b.BlogCategories).ThenInclude(b => b.Category).FirstOrDefaultAsync()
                
            };


            return View(blogVM);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            BlogVM blogVM = new BlogVM()
            {
                Blogs = await _context.Blogs.Where(b => b.IsDeleted == false && b.Id== id).ToListAsync(),
                Blog = await _context.Blogs.Where(b => b.IsDeleted == false && b.Id==id).Include(b => b.BlogCategories).ThenInclude(b => b.Category).FirstOrDefaultAsync()


            };


            return View(blogVM);
        }
    }
}
