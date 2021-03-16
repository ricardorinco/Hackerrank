using System.Collections.Generic;
using System.Linq;

namespace Hackerrank.ConsoleApp
{
    public static class MigratoryBirdsResolve
    {
        public static int MigratoryBirds(List<int> arr)
        {
            var result = arr.GroupBy(x => x).OrderByDescending(x => x.Count());

            return result.FirstOrDefault() == null ? 0 : result.FirstOrDefault().Key;
        }
    }
}
