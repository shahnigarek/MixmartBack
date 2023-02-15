using MixmartBackEnd.ViewModels.Basket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.ViewModels.Header
{
    public class HeaderVM
    {
        public IDictionary<string, string> Settings { get; set; }
        public List<BasketVM> BasketVMs { get; set; }


    }
}
