using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Models
{
    public class Slider:BaseEntity
    {
        [StringLength(1000)]
        public string MainTitle { get; set; }
        [StringLength(1000)]
        public string SubTitle { get; set; }
        [StringLength(1000)]
        public string Image { get; set; }
       
    }
}
