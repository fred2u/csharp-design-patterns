using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Strategy
{
    internal class DescendingSort : ISortingStrategy<int>
    {
        public IEnumerable<int> Sort(IEnumerable<int> source)
        {
            return source.OrderByDescending(x => x);
        }
    }
}