using System;
using System.Linq;
using Hackerrank.Common.Console.Interfaces;

namespace Hackerrank.ConsoleApp
{
    public static class MiniMaxSumResolve
    {
        public static void MiniMaxSum(IConsole console, int[] numbers)
        {
            Array.Sort(numbers);
            var min = numbers.Take(4).Sum(item => (long)item);
            var max = numbers.Skip(1).Sum(item => (long)item);

            console.WriteLine($"{min} {max}");
        }
    }
}
