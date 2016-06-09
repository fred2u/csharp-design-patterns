using System;

namespace DesignPatterns.Memento
{
    internal class Program
    {
        private static void Main()
        {
            var person = new Person("Alice");
            Console.WriteLine(person);

            var backup = person.Save();
            person.ChangeName("Bob");
            Console.WriteLine(person);

            person.Restore(backup);
            Console.WriteLine(person);

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.Read();
        }
    }
}
