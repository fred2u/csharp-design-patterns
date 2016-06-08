namespace DesignPatterns.AbstractFactory
{
    internal interface ISmartPhone<out TBrand> : IDevice
        where TBrand : IBrand
    {
        TBrand Brand { get; }
    }
}