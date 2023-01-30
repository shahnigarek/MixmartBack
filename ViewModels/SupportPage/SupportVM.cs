using MixmartBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.ViewModels.SupportPage
{
    public class SupportVM
    {
        public IEnumerable<Support> Supports { get; set; }
        public IEnumerable<Featured> Featureds { get; set; }
        public Featured Featured { get; set; }
    }
}
