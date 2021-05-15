using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace TallyBakery.Application.Core
{
    public class Order
    {
        public decimal TotalOrder { get; set; }
        public List<OrderLine> OrderLines { get; set; }
    }

    public class OrderLine{
        public string ProductCode { get; set; }
        public int Qty { get; set; }
        public List<OrderLinePriceBreaks> PriceBreak { get; set; }
    }

    public class OrderLinePriceBreaks{
        public int Multiply { get; set; }
        public int Qty { get; set; }
        public decimal Cost { get; set; }
    }
}