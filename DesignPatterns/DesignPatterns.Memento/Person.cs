using System;

namespace DesignPatterns.Memento
{
    internal class Person
    {
        private string _name;

        public Person(string name)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));
            _name = name;
        }

        public override string ToString()
        {
            return _name;
        }

        public void ChangeName(string name)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));
            _name = name;
        }

        public Memento Save()
        {
            return new Memento(_name);
        }

        public void Restore(Memento memento)
        {
            if (memento == null) throw new ArgumentNullException(nameof(memento));

            _name = memento.State;
        }
    }
}