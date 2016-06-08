using System;

namespace DesignPatterns.Builder
{
    internal class Program
    {
        private static void Main()
        {
            var chef = new Chef();
            var sandwichRecipe = new SandwichRecipe();
            var pizzaRecipe = new PizzaRecipe();

            chef.Make(sandwichRecipe);
            chef.Make(pizzaRecipe);

            Console.WriteLine(sandwichRecipe.Serve());
            Console.WriteLine(pizzaRecipe.Serve());

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.Read();
        }
    }
}
