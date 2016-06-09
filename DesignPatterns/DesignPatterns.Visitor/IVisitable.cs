namespace DesignPatterns.Visitor
{
    internal interface IVisitable
    {
        void Accept(IVisitor visitor);
    }
}