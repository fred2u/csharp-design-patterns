using System;

namespace DesignPatterns.Factory
{
    internal static class FruitCreator
    {
        public static IFruit CreateFruitForSeason()
        {
            return CreateFruitForSeason(DateTime.Now);
        }

        public static IFruit CreateFruitForSeason(DateTime moment)
        {
            if (moment.Month <= 3)
            {
                return new Pineapple();
            }

            if (moment.Month <= 6)
            {
                return new Banana();
            }

            if (moment.Month <= 9)
            {
                return new Strawberry();
            }

            return new Apple();
        }
    }
}