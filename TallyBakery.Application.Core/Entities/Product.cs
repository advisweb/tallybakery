using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace TallyBakery.Application.Core.Entities
{
    public class Product
    {
        public string code { get; set; }
        public string name { get; set; }
        public List<PriceBreaks> priceBreaks { get; set; }
    }
}
