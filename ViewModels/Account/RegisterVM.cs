using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.ViewModels.Account
{
    public class RegisterVM
    {
        [Required]
        [StringLength(maximumLength: 255)]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 255)]
        public string Surname { get; set; }  
        [Required]
        public byte Age { get; set; }
        [Required]
        [StringLength(maximumLength: 255)]
        [EmailAddress]
        public string Email { get; set; } 
        [Required]
        [StringLength(maximumLength: 255)]
        public string UserName { get; set; } 
        [Required]
        [StringLength(maximumLength: 255,MinimumLength =9)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [StringLength(maximumLength: 255,MinimumLength =9)]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

    }
}
