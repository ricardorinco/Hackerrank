using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCakeCandles
{
    public class Program
    {
        public static int birthdayCakeCandles(List<int> candles)
        {
            return candles.GroupBy(c => c)
                .Where(c => c.Count() > 1)
                .Select(c => c.Count())
                .FirstOrDefault();
        }

        public static void Main(string[] args)
        {
            int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

            int result = birthdayCakeCandles(candles);

            Console.Write(result);
            Console.ReadKey();
        }
    }
}
