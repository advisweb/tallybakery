using System;
using System.Collections.Generic;
using System.Text;
using TallyBakery.Application.Core.Interfaces;

namespace TallyBakery.Application.Core.Entities
{
    public class OrderLine : IOrderLine
    {
        public string ProductCode { get; set; }
        public int Qty { get; set; }
        public List<OrderLinePriceBreaks> PriceBreak { get; set; }
    }
}
