using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Models
{
    public class Team:BaseEntity
    {
        [StringLength(255)]

        public string FullName { get; set; }
        [StringLength(255)]

        public string Image { get; set; }
     
        [StringLength(255)]

        public string FacebookUrl { get; set; }
        [StringLength(255)]

        public string GooglePlusUrl { get; set; }
        [StringLength(255)]

        public string YoutubeUrl { get; set; }
        [StringLength(255)]

        public string TwitterUrl { get; set; }

        public int PositionId { get; set; }
        public Position Position { get; set; }
        [NotMapped]
        public IFormFile File { get; set; }


    }
}
