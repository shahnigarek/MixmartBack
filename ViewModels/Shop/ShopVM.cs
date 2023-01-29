using MixmartBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.ViewModels.Shop
{
    public class ShopVM
    {
        public IEnumerable<Product> Products { get; set; }
        public Product Product { get; set; }

        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
    }
}
