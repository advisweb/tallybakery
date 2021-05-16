using System.Collections;
using System.Linq;
using System.Collections.Generic;
using TallyBakery.Application.Core.Interfaces;

namespace TallyBakery.Application.Core.Entities
{
    public class Order : IOrder
    {
        public decimal TotalOrder { get; set; }
        public List<OrderLine> OrderLines { get; set; }
    }
}