namespace DesignPatterns.AbstractFactory
{
    internal interface IComputer<out TBrand> : IDevice
        where TBrand : IBrand
    {
        TBrand Brand { get; }
    }
}