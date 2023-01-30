using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MixmartBackEnd.DAL;
using MixmartBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.ViewComponents
{
    public class NeedSupportViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;
        public NeedSupportViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            IEnumerable<NeedSupport> needSupports = await _context.NeedSupports.Where(ns => ns.IsDeleted == false).ToListAsync();
            return View(await Task.FromResult(needSupports));
        }
    }
}
