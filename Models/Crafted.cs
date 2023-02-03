using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Models
{
    public class Crafted:BaseEntity
    {
        [StringLength(255)]
        public string Image1 { get; set; }
        [StringLength(255)]
        public string Image2 { get; set; }
        [StringLength(255)]
        public string Image3 { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        public int ProductCount { get; set; }
        [StringLength(255)]
        public string Title2 { get; set; }
        public int ProductCount2 { get; set; }
        [StringLength(255)]
        public string Title3 { get; set; }
        public int ProductCount3 { get; set; }
        [NotMapped]
        public IFormFile File { get; set; }
    }
}
