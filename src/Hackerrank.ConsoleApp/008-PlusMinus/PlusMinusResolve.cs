using System;
using System.Linq;

namespace Hackerrank.ConsoleApp
{
    public static class PlusMinusResolve
    {
        public static void PlusMinus(int[] arr)
        {
            Console.WriteLine(string.Format("{0:0.000000}", GetPositiveResult(arr.Length, arr)));
            Console.WriteLine(string.Format("{0:0.000000}", GetNegativeResult(arr.Length, arr)));
            Console.WriteLine(string.Format("{0:0.000000}", GetZeroResult(arr.Length, arr)));
        }

        private static decimal GetPositiveResult(int arraySize, int[] inputs)
        {
            var count = 0;
            foreach (var input in inputs.Where(i => i > 0))
                count++;

            return Math.Round(decimal.Divide(count, arraySize), 6);
        }
        private static decimal GetNegativeResult(int arraySize, int[] inputs)
        {
            var count = 0;
            foreach (var input in inputs.Where(i => i < 0))
                count++;

            return Math.Round(Decimal.Divide(count, arraySize), 6);
        }
        private static decimal GetZeroResult(int arraySize, int[] inputs)
        {
            var count = 0;
            foreach (var input in inputs.Where(i => i == 0))
                count++;

            return Math.Round(Decimal.Divide(count, arraySize), 6);
        }
    }
}
