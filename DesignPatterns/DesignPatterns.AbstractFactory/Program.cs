using System;

namespace DesignPatterns.AbstractFactory
{
    internal class Program
    {
        private static void Main()
        {
            var appleFactory = new Factory<Apple>();
            var macbook = appleFactory.CreateComputer("MacBook");
            var iphone = appleFactory.CreateSmartPhone("iPhone");

            Console.WriteLine(macbook);
            Console.WriteLine(iphone);

            var microsoftFactory = new Factory<Microsoft>();
            var surface = microsoftFactory.CreateComputer("Surface");
            var lumia = microsoftFactory.CreateSmartPhone("Lumia");

            Console.WriteLine(surface);
            Console.WriteLine(lumia);

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.Read();
        }
    }
}
