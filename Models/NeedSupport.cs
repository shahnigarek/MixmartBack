using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Models
{
    public class NeedSupport:BaseEntity
    {
        [StringLength(255)]
        public string Icon { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
    }

}
