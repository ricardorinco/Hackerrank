using System;
using System.Linq;

namespace Hackerrank.ConsoleApp
{
    public static class MiniMaxSumResolve
    {
        public static void MiniMaxSum(int[] numbers)
        {
            Array.Sort(numbers);
            long min = numbers.Take(4).Sum(item => (long)item);
            long max = numbers.Skip(1).Sum(item => (long)item);

            Console.WriteLine($"{min} {max}");
            Console.ReadKey();
        }
    }
}
