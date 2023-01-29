using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Models
{
    public class Story:BaseEntity
    {
            [StringLength(255)]
            public string Image { get; set; }
            [StringLength(1000)]
            public string Title { get; set; }
      
            [StringLength(2500)]
            public string Description { get; set; }
        [StringLength(255)]
        public string VideoUrl { get; set; }
    }
}
