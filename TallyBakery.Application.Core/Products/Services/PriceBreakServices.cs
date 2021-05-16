using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TallyBakery.Application.Core.Entities;
using TallyBakery.Application.Core.Products.Interfaces;

namespace TallyBakery.Application.Core.Products.Services
{
    public class PriceBreakServices : IPriceBreakServices
    {
        public List<PriceBreaks> PriceBreaks { get; set; }
        public List<ProductCartPriceBreaks> GetCheapestPriceBreaks(int cartQty, List<PriceBreaks> lists)
        {
            var cheapest = new List<ProductCartPriceBreaks>();
            var qtyBreak = lists.Select(x => x.qty).ToList();
            this.FindNextPriceBrake(cheapest, lists, cartQty, 0);
            return cheapest;
        }

        private void FindNextPriceBrake(List<ProductCartPriceBreaks> results, List<PriceBreaks> priceBreaks, int cartQty, int index)
        {
            if (index == priceBreaks.Count || cartQty == 0)
                return;

            var priceBreak = priceBreaks[index];
            var multiply = Convert.ToInt32(Math.Floor((decimal)(cartQty / priceBreak.qty)));
            var remaining = (cartQty - (priceBreak.qty * multiply));
            var isValid = priceBreaks.Any(x => remaining % x.qty == 0);

            if (isValid)//(cartQty % priceBreak.qty) < cartQty)
            {
                var cartPriceBreak = new Entities.ProductCartPriceBreaks
                {
                    multiply = Convert.ToInt32(Math.Floor((decimal)(cartQty / priceBreak.qty))),
                    qty = priceBreak.qty,
                    price = priceBreak.price
                };
                results.Add(cartPriceBreak);
                cartQty = cartQty - (cartPriceBreak.multiply * cartPriceBreak.qty);
            }
            this.FindNextPriceBrake(results, priceBreaks, cartQty, index + 1);
        }
    }
}
