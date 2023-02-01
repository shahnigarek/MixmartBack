using MixmartBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.ViewModels.BlogDetailVM
{
    public class BlogDetailVM
    {
        public Blog Blog { get; set; }
        public IEnumerable<BlogCategory> BlogCategories { get; set; }
    }
}
