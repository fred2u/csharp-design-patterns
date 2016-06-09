using System;

namespace DesignPatterns.Iterator
{
    internal class Program
    {
        private static void Main()
        {
            var values = new [] { 1, 2, 3, 4, 5};

            foreach (var value in values)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.Read();
        }
    }
}
