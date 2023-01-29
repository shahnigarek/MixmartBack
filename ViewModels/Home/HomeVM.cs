using MixmartBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.ViewModels.Home
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Product> IsBestSeller { get; set; }
        public IEnumerable<Product> IsNewArrival { get; set; }
        public Crafted Crafted { get; set; }
        public IEnumerable<Movement> Movements { get; set; }
        public Ceramic Ceramics  { get; set; }

        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<BlogCategory> BlogCategories { get; set; }


        public IEnumerable<Blog> Blogs  { get; set; }
        public Blog Blog { get; set; }

        public IEnumerable<Instagram> Instagrams  { get; set; }
        
    }
}
