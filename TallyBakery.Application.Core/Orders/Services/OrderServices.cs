using System;
using System.Collections.Generic;
using System.Text;
using TallyBakery.Application.Core.Entities;
using TallyBakery.Application.Core.Interfaces;
using TallyBakery.Application.Core.Orders.Interfaces;

namespace TallyBakery.Application.Core.Orders.Services
{
    public class OrderServices : IOrderServices
    {
        private readonly IProductServices productServices;
        public OrderServices(IProductServices productServices)
        {
            this.productServices = productServices;
        }

        public ProductCart AddToCart(int qty, string code)
        {
            return this.productServices.GetCartProduct(code, qty);
        }

        public void DisplayCart(ProductCart cart)
        {
            Console.WriteLine($"{cart.Qty} {cart.Code} {cart.Total.ToString("C")}");

            if (cart.PriceBreaks.Count == 0)
            {
                Console.WriteLine("We don't have special price for the amount ordered");
            }
            else
            {
                cart.PriceBreaks.ForEach(f =>
                {
                    Console.WriteLine($"{f.multiply} x {f.qty} {f.price.ToString("C")}");
                });
            }
        }
    }
}
