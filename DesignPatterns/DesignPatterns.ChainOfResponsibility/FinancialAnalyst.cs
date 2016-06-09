using System;

namespace DesignPatterns.ChainOfResponsibility
{
    internal class FinancialAnalyst : IWithdraw
    {
        private readonly IWithdraw _nextHandler;

        public FinancialAnalyst(IWithdraw nextHandler = null)
        {
            _nextHandler = nextHandler;
        }

        public bool Withdraw(int amount)
        {
            if (amount < 20000)
            {
                return true;
            }

            Console.WriteLine($"{GetType().Name} : I'm sorry, I must escalade this request to my superior.");
            return _nextHandler != null && _nextHandler.Withdraw(amount);
        }
    }
}