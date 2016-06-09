using System;

namespace DesignPatterns.State
{
    internal class BasketContext : IContext
    {
        private IState _state = new LightState();

        public void Add(string item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));

            _state.Add(this, item);
        }

        public void SetState(IState state)
        {
            if (state == null) throw new ArgumentNullException(nameof(state));
            _state = state;
        }
    }
}