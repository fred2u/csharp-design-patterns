using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Strategy
{
    internal class AscendingSort : ISortingStrategy<int>
    {
        public IEnumerable<int> Sort(IEnumerable<int> source)
        {
            return source.OrderBy(x => x);
        }
    }
}