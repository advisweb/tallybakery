using System;
using TallyBakery.Application.Core;

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

            ProductRepository repo = new ProductRepository();
            repo.Initialization();

            repo.GetMaxPriceBreakByProduct(code, qty);
            //display max price breaks
        }
    }
}
