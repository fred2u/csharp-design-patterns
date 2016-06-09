using System;

namespace DesignPatterns.Visitor
{
    internal class Product : IVisitable
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public void Accept(IVisitor visitor)
        {
            if (visitor == null) throw new ArgumentNullException(nameof(visitor));

            visitor.Visit(this);
        }
    }
}