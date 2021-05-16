using System;
using System.Collections.Generic;
using System.Text;

namespace TallyBakery.Application.Core.Entities
{

    public class OrderLinePriceBreaks
    {
        public int Multiply { get; set; }
        public int Qty { get; set; }
        public decimal Cost { get; set; }
    }
}
