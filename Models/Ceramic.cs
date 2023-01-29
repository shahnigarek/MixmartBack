using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Models
{
    public class Ceramic:BaseEntity
    {
       [StringLength(255)]
        public string Image { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        [StringLength(255)]
        public string Author { get; set; }
        public double Price { get; set; }
        public double DiscountedPrice { get; set; }

    }
}
