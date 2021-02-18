using System.Collections.Generic;
using System.Linq;

namespace Hackerrank.ConsoleApp
{
    public static class BirthdayCakeCandlesResolve
    {
        public static int BirthdayCakeCandles(List<int> candles)
        {
            return candles.GroupBy(c => c)
                .Where(c => c.Count() > 1)
                .Select(c => c.Count())
                .FirstOrDefault();
        }
    }
}
