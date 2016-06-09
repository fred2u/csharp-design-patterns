using System;

namespace DesignPatterns.Mediator
{
    internal class Program
    {
        private static void Main()
        {
            var mediator = new Spokesperson();
            var alice = new Colleague("Alice", mediator);
            var bob = new Colleague("Bob", mediator);

            alice.Say("I want feature X ready for tomorrow !");
            bob.Say("Sorry, I'm on holidays for the next two weeks !");

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.Read();
        }
    }
}
