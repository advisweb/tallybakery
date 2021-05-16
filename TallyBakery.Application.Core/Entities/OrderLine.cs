using System;
using System.Collections.Generic;
using System.Text;

namespace TallyBakery.Application.Core.Entities
{
    public class OrderLine
    {
        public string ProductCode { get; set; }
        public int Qty { get; set; }
        public List<OrderLinePriceBreaks> PriceBreak { get; set; }
    }
}
