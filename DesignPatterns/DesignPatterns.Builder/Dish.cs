using System;

namespace DesignPatterns.Builder
{
    internal class Dish
    {
        private readonly string _content;

        public Dish(string content)
        {
            _content = content;
            if (content == null) throw new ArgumentNullException(nameof(content));
        }

        public override string ToString()
        {
            return $"Un plat avec: {_content}.";
        }
    }
}