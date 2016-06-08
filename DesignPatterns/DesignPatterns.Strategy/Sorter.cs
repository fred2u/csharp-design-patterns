using System.Collections.Generic;

namespace DesignPatterns.Strategy
{
    internal class Sorter<T>
    {
        public IEnumerable<T> Sort(IEnumerable<T> source, ISortingStrategy<T> strategy)
        {
            return strategy.Sort(source);
        }
    }
}