using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Models
{
    public class Setting
    {
        public int Id { get; set; }
        [StringLength(2500)]
        public string Key { get; set; }
        [StringLength(2500)]
        public string Value { get; set; }

        [NotMapped]
        public IFormFile File { get; set; }
    }
}
