using System;

namespace DesignPatterns.Builder
{
    internal class Fridge
    {
        public string Get(int quantity, string item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));

            return $"{quantity} {item}";
        }
    }
}