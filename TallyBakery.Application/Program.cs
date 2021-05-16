using System;
using TallyBakery.Application.Core.Products.Services;

namespace TallyBakery
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your order (10 VS5)");
            var input = Console.ReadLine();

            var parts = input.Split(new char[] { ' ' });
            var qty = int.Parse(parts[0]);
            var code = parts[1];

            ProductServices repo = new ProductServices();
            repo.Initialization();
            repo.GetCheapestPriceBreaks(code, qty);

            //display max price breaks
        }
    }
}
