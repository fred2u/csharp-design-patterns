using System;

namespace DesignPatterns.Command
{
    internal class Program
    {
        private static void Main()
        {
            var dominos = new DominosPizza();
            var command = new GetPizza(dominos)
            {
                Address = new []
                {
                    "Chaussée de Nivelles, 81",
                    "1420 Braine-l’Alleud",
                    "Belgium"
                }
            };

            command.Execute();

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.Read();
        }
    }
}
