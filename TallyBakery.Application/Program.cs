using System;

namespace TallyBakery
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductRepository repo = new ProductRepository();
            repo.InitializeDatabase();

            Console.ReadLine("Please enter your order (10 VS5)");
        }
    }
}
