using System.Linq;

namespace Hackerrank.ConsoleApp
{
    public static class SalesByMatchResolve
    {
        public static int SockMerchant(int n, int[] ar)
        {
            return ar
                .GroupBy(x => x)
                .Select(x => new { pairs = x.Count() / 2 })
                .Sum(x => x.pairs);
        }
    }
}
