using System.Collections.Generic;
using System.Linq;

namespace Hackerrank.ConsoleApp
{
    public static class JimAndTheOrdersResolve
    {
        public static int[] JimOrders(IEnumerable<int[]> orders)
        {
            return orders
                .Select((f, i) => new
                {
                    Id = i + 1,
                    Time = f[0],
                    OrderTake = f[1]
                })
                .OrderBy(f => f.Time + f.OrderTake)
                .Select(f => f.Id)
                .ToArray();
        }
    }
}