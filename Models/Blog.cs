using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Models
{
    public class Blog:BaseEntity
    {
        [StringLength(255)]
        public string Image { get; set; }
        [StringLength(255)]
        public string Author { get; set; }
        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(2500)]
        public string Description1 { get; set; }
        [StringLength(2500)]
        public string Description2 { get; set; }
     
        public DateTime Date { get; set; }
        [StringLength(255)]

        public string FacebookUrl { get; set; }
        [StringLength(255)]

        public string TwitterUrl { get; set; }
        [StringLength(255)]

        public string LinkedinUrl { get; set; }
        [StringLength(255)]

        public string TumblrUrl { get; set; }
  
        [StringLength(255)]

        public string GooglePlusUrl { get; set; }
        [StringLength(255)]

        public string PinterestUrl { get; set; }
        [StringLength(255)]

        public string EnvelopeUrl { get; set; }
        public IEnumerable<BlogCategory> BlogCategories { get; set; }

    }
}
