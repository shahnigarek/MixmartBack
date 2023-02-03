using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Models
{
    public class Movement:BaseEntity
    {
        [StringLength(255)]
        public string  Image { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        public int ProductCount { get; set; }
        [NotMapped]
        public IFormFile File { get; set; }

    }
}
