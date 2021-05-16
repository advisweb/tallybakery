using System;
using System.Collections.Generic;
using System.Text;

namespace TallyBakery.Application.Core.Entities
{
    public class ProductCart
    {
        public string Code { get; internal set; }
        public int Qty { get; internal set; }
        public decimal Total { get; internal set; }
        public List<ProductCartPriceBreaks> PriceBreaks { get; set; }
    }
}
