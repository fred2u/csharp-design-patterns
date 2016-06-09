using System;

namespace DesignPatterns.Observer
{
    internal class Program
    {
        private static void Main()
        {
            var signal = new TrafficLight();
            var audi = new Car("Audi");
            var bmw = new Car("BMW");

            audi.Observe(signal);
            bmw.Observe(signal);

            signal.TurnGreen(2500);

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.Read();
        }
    }
}
