using MixmartBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.ViewModels.BlogVM
{
    public class BlogVM
    {
        public Blog Blog { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<BlogCategory> BlogCategories { get; set; }




    }
}
