using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Models
{
    public class Instagram:BaseEntity
    {
       [StringLength(255)]
        public string Image { get; set; }
    }
}
