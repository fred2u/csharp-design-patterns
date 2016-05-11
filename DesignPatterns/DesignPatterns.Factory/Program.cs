using System;

namespace DesignPatterns.Factory
{
    internal class Program
    {
        private static void Main()
        {
            var fruit = FruitCreator.CreateFruitForSeason();
            Console.WriteLine($"The best fruit for current season is {fruit}.");

            var winterFruit = FruitCreator.CreateFruitForSeason(new DateTime(2016, 2, 1));
            Console.WriteLine($"The best fruit for winter season is {winterFruit}.");

            var springFruit = FruitCreator.CreateFruitForSeason(new DateTime(2016, 5, 1));
            Console.WriteLine($"The best fruit for spring season is {springFruit}.");

            var summerFruit = FruitCreator.CreateFruitForSeason(new DateTime(2016, 8, 1));
            Console.WriteLine($"The best fruit for summer season is {summerFruit}.");

            var autumnFruit = FruitCreator.CreateFruitForSeason(new DateTime(2016, 11, 1));
            Console.WriteLine($"The best fruit for autumn season is {autumnFruit}.");

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.Read();
        }
    }
}
