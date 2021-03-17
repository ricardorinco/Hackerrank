using Hackerrank.Common;
using System.Collections.Generic;
using System.Linq;

namespace Hackerrank.ConsoleApp
{
    public static class BillDivisionResolve
    {
        public static void BonAppetit(
            IConsole console,
            List<int> bill,
            int k,
            int b
        )
        {
            var valueOfSharedItems = bill
                .Select((value, index) => new { value, index })
                .Where(x => x.index != k)
                .Sum(x => x.value) / 2;

            if (b == valueOfSharedItems)
                console.WriteLine("Bon Appetit");
            else
                console.WriteLine($"{b - valueOfSharedItems}");
        }
    }
}
