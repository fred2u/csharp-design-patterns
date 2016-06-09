using System;

namespace DesignPatterns.Command
{
    internal class DominosPizza : IPizzaReceiver
    {
        public void Deliver(string[] address)
        {
            Console.WriteLine("Delivering a hot and tasty pizza!");
            Console.WriteLine("Address:");
            foreach (var line in address)
            {
                Console.WriteLine(line);
            }
        }
    }
}