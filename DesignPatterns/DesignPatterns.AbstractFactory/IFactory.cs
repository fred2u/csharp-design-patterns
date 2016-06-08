namespace DesignPatterns.AbstractFactory
{
    internal interface IFactory<out TBrand>
        where TBrand : IBrand
    {
        IComputer<TBrand> CreateComputer(string model);
        ISmartPhone<TBrand> CreateSmartPhone(string model);
    }
}