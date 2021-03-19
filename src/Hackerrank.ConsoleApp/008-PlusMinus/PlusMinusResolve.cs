using System;
using System.Linq;
using Hackerrank.Common.Console.Interfaces;

namespace Hackerrank.ConsoleApp
{
    public static class PlusMinusResolve
    {
        public static void PlusMinus(IConsole console, int[] arr)
        {
            console.WriteLine($"{GetResult(arr, x => x > 0):0.000000}");
            console.WriteLine($"{GetResult(arr, x => x < 0):0.000000}");
            console.WriteLine($"{GetResult(arr, x => x == 0):0.000000}");
        }

        private static decimal GetResult(int[] arr, Func<int, bool> predicate)
        {
            var count = arr.Count(predicate);
            
            return Math.Round(decimal.Divide(count, arr.Length), 6);
        }
    }
}
