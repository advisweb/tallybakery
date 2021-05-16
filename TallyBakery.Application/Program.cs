using Microsoft.Extensions.DependencyInjection;
using System;
using System.Configuration;
using TallyBakery.Application.Core.Interfaces;
using TallyBakery.Application.Core.Orders.Interfaces;
using TallyBakery.Application.Core.Products.Services;

namespace TallyBakery
{
    class Program
    {
        static void Main(string[] args)
        {

            IServiceCollection service = new ServiceCollection();
            Startup startup = new Startup();
            startup.ConfigureServices(service);

            var serviceProvider = service.BuildServiceProvider();
           
            do
            {
                Console.WriteLine("Please enter your order (10 VS5)");
                var input = Console.ReadLine();

                var parts = input.Split(new char[] { ' ' });
                var qty = int.Parse(parts[0]);
                var code = parts[1];

                var orderService = serviceProvider.GetService<IOrderServices>();
                var mycart = orderService.AddToCart(qty, code);
                orderService.DisplayCart(mycart);

            } while (true);          
        }
    }
}
