using System;

namespace DesignPatterns.ChainOfResponsibility
{
    internal class FrontDesk : IWithdraw
    {
        private readonly IWithdraw _nextHandler;

        public FrontDesk(IWithdraw nextHandler = null)
        {
            _nextHandler = nextHandler;
        }

        public bool Withdraw(int amount)
        {
            if (amount < 200)
            {
                return true;
            }

            Console.WriteLine($"{GetType().Name} : I'm sorry, I must escalade this request to my superior.");
            return _nextHandler != null && _nextHandler.Withdraw(amount);
        }
    }
}