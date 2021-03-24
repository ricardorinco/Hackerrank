using System.Collections.Generic;
using System.Linq;

namespace Hackerrank.ConsoleApp
{
    public static class MigratoryBirdsResolve
    {
        public static int MigratoryBirds(IEnumerable<int> arr)
        {
            var grouped = arr.GroupBy(x => x).OrderByDescending(x => x.Count());
            var result = grouped.FirstOrDefault();

            return result?.Key ?? 0;
        }
    }
}
