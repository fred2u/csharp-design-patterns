using System;

namespace DesignPatterns.Command
{
    internal class GetPizza : ICommand
    {
        private readonly IPizzaReceiver _receiver;

        public string[] Address { get; set; }

        public GetPizza(IPizzaReceiver receiver)
        {
            if (receiver == null) throw new ArgumentNullException(nameof(receiver));
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.Deliver(Address);
        }
    }
}