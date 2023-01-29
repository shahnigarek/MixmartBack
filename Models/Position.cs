using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Models
{
    public class Position:BaseEntity
    {
        [StringLength(255)]
        public string Name { get; set; }
        public IEnumerable<Team> Teams { get; set; }
    }
}
