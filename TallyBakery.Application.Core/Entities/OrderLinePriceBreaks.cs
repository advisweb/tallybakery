using System;
using System.Collections.Generic;
using System.Text;
using TallyBakery.Application.Core.Interfaces;

namespace TallyBakery.Application.Core.Entities
{
    public class OrderLinePriceBreaks : IOrderLinePriceBreaks
    {
        public int Multiply { get; set; }
        public int Qty { get; set; }
        public decimal Cost { get; set; }
    }
}
