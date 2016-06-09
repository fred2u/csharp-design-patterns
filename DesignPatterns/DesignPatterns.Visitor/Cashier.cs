using System;

namespace DesignPatterns.Visitor
{
    internal class Cashier : IVisitor
    {
        public decimal Total { get; private set; }

        public void Visit(ShoppingBasket basket)
        {
            if (basket == null) throw new ArgumentNullException(nameof(basket));

            Console.WriteLine($"Visiting shopping basket ID '{basket.GetHashCode()}'...");
        }

        public void Visit(Product item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));

            Total += item.Price;
        }
    }
}