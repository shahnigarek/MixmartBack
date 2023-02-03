using MixmartBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.ViewModels.Shop
{
    public class ShopDetailVM
    {
        public Product Product { get; set; }

        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<ProductCategory> ProductCategories { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public Category Category { get; set; }
    }
}
