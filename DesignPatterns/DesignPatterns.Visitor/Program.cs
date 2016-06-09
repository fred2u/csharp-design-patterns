using System;

namespace DesignPatterns.Visitor
{
    internal class Program
    {
        private static void Main()
        {
            var basket = new ShoppingBasket();
            basket.Add(new Product { Name = "Book", Price = 10 });
            basket.Add(new Product { Name = "CD", Price = 14.5m });
            basket.Add(new Product { Name = "Book", Price = 12 });

            var cashier = new Cashier();
            basket.Accept(cashier);

            Console.WriteLine($"Customer has to pay {cashier.Total}.");

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.Read();
        }
    }
}
