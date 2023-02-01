using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Models
{
    public class BlogCategory:BaseEntity
    {
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
        public int BCategoryId { get; set; }
        public BCategory BCategory { get; set; }
     

    }
}
