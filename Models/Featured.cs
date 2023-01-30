using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Models
{
    public class Featured:BaseEntity
    {
        [StringLength(255)]
        public string Question { get; set; }
  
        [StringLength(2500)]
        public string Answer { get; set; }
    }
}
