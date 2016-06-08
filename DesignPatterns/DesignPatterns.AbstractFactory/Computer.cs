using System;

namespace DesignPatterns.AbstractFactory
{
    internal class Computer<TBrand> : IComputer<TBrand>
        where TBrand: IBrand
    {
        public TBrand Brand { get; }
        public string Model { get; set; }

        public Computer(TBrand brand, string model)
        {
            if (brand == null) throw new ArgumentNullException(nameof(brand));
            if (model == null) throw new ArgumentNullException(nameof(model));
            Brand = brand;
            Model = model;
        }

        public override string ToString()
        {
            return $"{Brand.Name} {Model}";
        }
    }
}