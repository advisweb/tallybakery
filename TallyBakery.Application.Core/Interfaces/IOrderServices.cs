using TallyBakery.Application.Core.Entities;

namespace TallyBakery.Application.Core.Orders.Interfaces
{
    public interface IOrderServices
    {
        ProductCart AddToCart(int qty, string code);
        void DisplayCart(ProductCart mycart);
    }
}