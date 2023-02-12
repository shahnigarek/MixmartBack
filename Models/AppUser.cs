using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Models
{
    public class AppUser :IdentityUser
    {
        [Required]
        [StringLength(maximumLength:255)]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 255)]
        public string Surname { get; set; }
        [Required]
        public byte Age { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsDeActive { get; set; }
        [NotMapped]
        public string Role { get; set; }
    }
}
