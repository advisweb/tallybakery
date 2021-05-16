using System;
using System.Collections.Generic;
using System.Text;
using TallyBakery.Application.Core.Interfaces;

namespace TallyBakery.Application.Core.Entities
{
    public class PriceBreaks : IPriceBreaks
    {
        public int qty { get; set; }
        public decimal price { get; set; }
    }
}
