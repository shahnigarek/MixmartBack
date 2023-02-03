using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Models
{
    public class PaymentMethod:BaseEntity
    {
        [StringLength(2500)]
        public string Description1 { get; set; }
        [StringLength(2500)]
        public string Description2 { get; set; }
        [StringLength(2500)]
        public string Description3 { get; set; }
        [StringLength(2500)]
        public string Description4 { get; set; }
        [StringLength(2500)]
        public string Description5 { get; set; }
      
        [StringLength(1000)]
        public string Question1 { get; set; }
        [StringLength(1000)]
        public string Question2 { get; set; }
        [StringLength(1000)]
        public string Question3 { get; set; }
        [StringLength(255)]
        public string Image { get; set; }
        [StringLength(255)]
        public string PaymentOptions { get; set; }
        [NotMapped]
        public IFormFile File { get; set; }

    }
}
