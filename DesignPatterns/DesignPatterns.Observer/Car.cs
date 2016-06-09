using System;

namespace DesignPatterns.Observer
{
    internal class Car
    {
        private readonly string _brand;

        public Car(string brand)
        {
            if (brand == null) throw new ArgumentNullException(nameof(brand));
            _brand = brand;
        }

        public void Observe(TrafficLight signal)
        {
            if (signal == null) throw new ArgumentNullException(nameof(signal));

            Console.WriteLine($"{_brand} waits for the signal...");
            signal.Notify += Signal_Notify;
        }

        private void Signal_Notify()
        {
            Console.WriteLine($"{_brand} get the green light and start the race!");
        }
    }
}