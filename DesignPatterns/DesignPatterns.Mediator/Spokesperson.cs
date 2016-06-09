using System;

namespace DesignPatterns.Mediator
{
    internal class Spokesperson
    {
        public delegate void Callback(string from, string message);

        private Callback _callbacks;

        public void Send(string from, string message)
        {
            if (from == null) throw new ArgumentNullException(nameof(from));
            if (message == null) throw new ArgumentNullException(nameof(message));

            _callbacks(from, message);
        }

        public void Register(Callback callback)
        {
            _callbacks += callback;
        }
    }
}