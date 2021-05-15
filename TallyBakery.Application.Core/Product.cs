using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace TallyBakery.Application.Core
{
    public class Product
    {
        public string code { get; set; }
        public string name { get; set; }
        public List<PriceBreaks> priceBreaks { get; set; }
    }

    public class PriceBreaks
    {
        public int qty { get; set; }
        public decimal price { get; set; }
    }
}
