using System;

namespace DesignPatterns.ChainOfResponsibility
{
    internal class BranchManager : IWithdraw
    {
        public bool Withdraw(int amount)
        {
            if (amount < 200000)
            {
                return true;
            }

            Console.WriteLine($"{GetType().Name} : I'm sorry, I can't accept this request.");
            return false;
        }
    }
}