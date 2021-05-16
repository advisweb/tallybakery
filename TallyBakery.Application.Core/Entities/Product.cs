using System.Collections;
using System.Linq;
using System.Collections.Generic;
using TallyBakery.Application.Core.Interfaces;

namespace TallyBakery.Application.Core.Entities
{
    public class Product : IProduct
    {
        public string code { get; set; }
        public string name { get; set; }
        public List<PriceBreaks> priceBreaks { get; set; }
    }
}
