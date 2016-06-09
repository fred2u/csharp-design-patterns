using System;

namespace DesignPatterns.Template
{
    internal class Program
    {
        private static void Main()
        {
            var alice = new Person { FirstName = "Alice", Age = 19 };
            var bob = new Person { FirstName = "Bob", Age = 43 };

            new JsonFileSerializer().Save("people.json", alice, bob);
            new XmlFileSerialier().Save("people.xml", alice, bob);

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.Read();
        }
    }
}
