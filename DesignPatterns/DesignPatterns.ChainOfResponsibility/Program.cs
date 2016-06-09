using System;

namespace DesignPatterns.ChainOfResponsibility
{
    internal class Program
    {
        private static void Main()
        {
            var bank = new Bank();

            for (var i = 1; i < 7; i++)
            {
                var amount = (int) Math.Pow(10, i);
                var success = bank.Withdraw(amount);
                Console.WriteLine($"Withdrawn {amount} was: {(success ? "accepted" : "denied")}");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.Read();
        }
    }
}
