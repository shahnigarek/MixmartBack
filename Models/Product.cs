﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Models
{
    public class Product:BaseEntity
    {
        [StringLength(255)]
        public string Image { get; set; }
        
        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(2500)]
        public string Description1 { get; set; }
        [StringLength(2500)]
        public string Description2 { get; set; }
        [StringLength(2500)]
        public string Description3 { get; set; }
        public int Count { get; set; }

        public double Price { get; set; }
        public double DiscountedPrice { get; set; }
        public bool IsNewArrival { get; set; }
        public bool IsBestSeller { get; set; }

     
        public IEnumerable<ProductTag> ProductTags { get; set; }
        public IEnumerable<ProductCategory> ProductCategories { get; set; }
        public IEnumerable<Basket> Baskets { get; set; }

        [NotMapped]
        public IFormFile File { get; set; }
        [NotMapped]
        [MaxLength(3)]
        public IEnumerable<int> TagIds { get; set; }
        [NotMapped]
        [MaxLength(3)]
        public IEnumerable<int> CategoryIds { get; set; }
    }
}
