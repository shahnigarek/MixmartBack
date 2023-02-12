using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 255)]
        public string Message { get; set; }
        [Required]
        public DateTime Date { get; set; }

        public int? BlogId { get; set; }
        public Blog Blog { get; set; }
        public bool IsAccess { get; set; }

        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
