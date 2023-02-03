using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [NotMapped]
        public IFormFile File { get; set; }
    }
}
