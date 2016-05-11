using System;

namespace DesignPatterns.Singleton
{
    internal class Program
    {
        private static void Main()
        {
            DateTimeProvider.Setup(() => new DateTime(2016, 1, 1, 0, 0, 0));
            Console.WriteLine(DateTimeProvider.Current.Now);

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.Read();
        }
    }
}
