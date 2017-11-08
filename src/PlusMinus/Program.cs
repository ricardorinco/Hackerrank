using System;
using System.Linq;

namespace PlusMinus
{
    public class Program
    {
        static void Main(string[] args)
        {
            var arraySize = Int32.Parse(Console.ReadLine());
            var inputs = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);

            Console.WriteLine(string.Format("{0:0.000000}", GetPositiveResult(arraySize, inputs)));
            Console.WriteLine(string.Format("{0:0.000000}", GetNegativeResult(arraySize, inputs)));
            Console.WriteLine(string.Format("{0:0.000000}", GetZeroResult(arraySize, inputs)));

            Console.ReadKey();
        }

        private static decimal GetPositiveResult(int arraySize, int[] inputs)
        {
            var count = 0;
            foreach (var input in inputs.Where(i => i > 0))
                count++;

            return Math.Round(Decimal.Divide(count, arraySize), 6);
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
