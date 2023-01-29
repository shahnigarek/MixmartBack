using MixmartBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.ViewModels.AboutVM
{
    public class AboutVM
    {
        public Story Story { get; set; }
        public IEnumerable<Brand> Brands { get; set; }
        public About About { get; set; }
        public IEnumerable<Service> Services { get; set; }
        public IEnumerable<Team> Teams { get; set; }
        public IEnumerable<Position> Positions { get; set; }
    }
}
