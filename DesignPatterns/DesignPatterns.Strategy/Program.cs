using System;

namespace DesignPatterns.Strategy
{
    internal class Program
    {
        private static void Main()
        {
            var data = new [] { 3, 7, 9, 4, 2, 6, 3, 0, 8, 2, 4 };
            var sorter = new Sorter<int>();
            var aSorted = sorter.Sort(data, new AscendingSort());
            var dSorted = sorter.Sort(data, new DescendingSort());

            Console.WriteLine(String.Join(", ", aSorted));
            Console.WriteLine(String.Join(", ", dSorted));

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.Read();
        }
    }
}
