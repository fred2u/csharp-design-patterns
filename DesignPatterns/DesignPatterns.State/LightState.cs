using System;

namespace DesignPatterns.State
{
    internal class LightState : IState
    {
        private int _count;

        public void Add(IContext context, string item)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));
            if (item == null) throw new ArgumentNullException(nameof(item));

            Console.WriteLine($"Adding {item}...");

            if (++_count > 2)
            {
                context.SetState(new HeavyState());
            }
        }
    }
}