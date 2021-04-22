using System.Collections.Generic;
using System.Linq;

namespace Hackerrank.ConsoleApp
{
    public static class PickingNumbersResolve
    {
        public static int PickingNumbers(List<int> numbers)
        {
            var result = 0;

            var d = numbers.GroupBy(g => g).ToDictionary(k => k.Key, g => g.Count());
            d.TryGetValue(0, out var q);
            
            for (var i = 1; i < 100; ++i)
            {
                d.TryGetValue(i, out var w);
                if (q + w > result)
                {
                    result = q + w;
                }
                    
                q = w;
            }

            return result;
        }
    }
}