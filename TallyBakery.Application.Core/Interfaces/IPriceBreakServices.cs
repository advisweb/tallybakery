using System.Collections.Generic;
using TallyBakery.Application.Core.Entities;

namespace TallyBakery.Application.Core.Products.Interfaces
{
    public interface IPriceBreakServices
    {
        List<ProductCartPriceBreaks> GetCheapestPriceBreaks(int qty, List<PriceBreaks> lists);
    }
}