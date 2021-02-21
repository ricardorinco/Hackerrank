using System.Collections.Generic;
using System.Linq;

namespace Hackerrank.ConsoleApp
{
    public static class JimAndTheOrdersResolve
    {
        public static int[] JimOrders(int[][] orders)
        {
            var fansList = new List<Fan>();
            for (int i = 0; i < orders.Length; i++)
            {
                fansList.Add(new Fan {
                    Id = i + 1,
                    Time = orders[i][0],
                    OrderTake = orders[i][1]
                });
            }

            return fansList
                .OrderBy(f => f.Time + f.OrderTake)
                .Select(f => f.Id)
                .ToArray();
        }
    }
}
