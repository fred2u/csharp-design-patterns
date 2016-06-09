namespace DesignPatterns.Visitor
{
    internal interface IVisitor
    {
        void Visit(ShoppingBasket basket);
        void Visit(Product item);
    }
}