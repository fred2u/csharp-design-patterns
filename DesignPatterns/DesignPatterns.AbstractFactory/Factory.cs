using System;

namespace DesignPatterns.AbstractFactory
{
    internal class Factory<TBrand> : IFactory<TBrand>
        where TBrand : IBrand, new()
    {
        public IComputer<TBrand> CreateComputer(string model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            return new Computer<TBrand>(new TBrand(), model);
        }

        public ISmartPhone<TBrand> CreateSmartPhone(string model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            return new SmartPhone<TBrand>(new TBrand(), model);
        }
    }
}
