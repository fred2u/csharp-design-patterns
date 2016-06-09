namespace DesignPatterns.ChainOfResponsibility
{
    internal class Bank : IWithdraw
    {
        private readonly IWithdraw _handlerChain = BuildHandlerChain();

        public bool Withdraw(int amount)
        {
            return _handlerChain.Withdraw(amount);
        }

        private static IWithdraw BuildHandlerChain()
        {
            return new FrontDesk(
                new Accountant(
                    new FinancialAnalyst(
                        new BranchManager()
                        )
                    )
                );
        }
    }
}