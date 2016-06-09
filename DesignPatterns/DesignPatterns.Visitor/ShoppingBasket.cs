using System;
using System.Collections.Generic;

namespace DesignPatterns.Visitor
{
    internal class ShoppingBasket : IVisitable
    {
        private readonly List<Product> _products = new List<Product>();

        public void Add(Product product)
        {
            if (product == null) throw new ArgumentNullException(nameof(product));

            _products.Add(product);
        }

        public void Accept(IVisitor visitor)
        {
            if (visitor == null) throw new ArgumentNullException(nameof(visitor));

            visitor.Visit(this);

            foreach (var product in _products)
            {
                visitor.Visit(product);
            }
        }
    }
}