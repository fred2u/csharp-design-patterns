using System;

namespace DesignPatterns.Mediator
{
    internal class Colleague
    {
        private readonly string _name;
        private readonly Spokesperson _mediator;

        public Colleague(string name, Spokesperson mediator)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));
            if (mediator == null) throw new ArgumentNullException(nameof(mediator));
            _name = name;
            _mediator = mediator;

            mediator.Register(Receive);
        }

        public void Say(string something)
        {
            if (something == null) throw new ArgumentNullException(nameof(something));

            Console.WriteLine($"{_name} says: \"{something}\".");
            _mediator.Send(_name, something);
        }

        private void Receive(string from, string message)
        {
            if (from == null) throw new ArgumentNullException(nameof(from));
            if (message == null) throw new ArgumentNullException(nameof(message));

            if (from != _name)
            {
                Console.WriteLine($"{_name} received a message from {from}: \"{message}\".");
            }
        }
    }
}