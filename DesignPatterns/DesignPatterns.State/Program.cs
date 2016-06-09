using System;

namespace DesignPatterns.State
{
    internal class Program
    {
        private static void Main()
        {
            var basket = new BasketContext();
            basket.Add("Item #1");
            basket.Add("Item #2");
            basket.Add("Item #3");
            basket.Add("Item #4");
            basket.Add("Item #5");

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.Read();
        }
    }
}
