using System;

namespace DesignPatterns.State
{
    internal class HeavyState : IState
    {
        public void Add(IContext context, string item)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));
            if (item == null) throw new ArgumentNullException(nameof(item));

            Console.WriteLine($"Adding {item}... WARNING ! Basket is heavy.");
        }
    }
}