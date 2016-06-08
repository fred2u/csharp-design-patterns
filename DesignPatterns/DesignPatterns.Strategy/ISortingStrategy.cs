using System.Collections.Generic;

namespace DesignPatterns.Strategy
{
    internal interface ISortingStrategy<T>
    {
        IEnumerable<T> Sort(IEnumerable<T> source);
    }
}