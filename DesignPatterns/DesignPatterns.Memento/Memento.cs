using System;

namespace DesignPatterns.Memento
{
    internal class Memento
    {
        public string State { get; }

        public Memento(string state)
        {
            if (state == null) throw new ArgumentNullException(nameof(state));
            State = state;
        }
    }
}