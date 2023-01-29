using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Models
{
    public class WarrantyandService:BaseEntity
    {
        [StringLength(1000)]
        public string Title { get; set; }
     
        [StringLength(2500)]
        public string Description { get; set; }
       
       
    }
}
