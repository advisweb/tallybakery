using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace TallyBakery.Application.Core.Entities
{
    public class Order
    {
        public decimal TotalOrder { get; set; }
        public List<OrderLine> OrderLines { get; set; }
    }
}