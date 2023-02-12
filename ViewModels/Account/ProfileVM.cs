using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.ViewModels.Account
{
    public class ProfileVM
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
        public string UserName { get; set; }
        [Required]
        [StringLength(maximumLength: 255)]
        [EmailAddress]
        public string Email { get; set; }
        [StringLength(maximumLength: 255, MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; }
        [StringLength(maximumLength: 255, MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
        [StringLength(maximumLength: 255, MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Compare(nameof(NewPassword))]
        public string ConfirmPassword { get; set; }
    }
}
