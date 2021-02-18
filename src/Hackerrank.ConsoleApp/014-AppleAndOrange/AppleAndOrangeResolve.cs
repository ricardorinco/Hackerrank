using System;
using System.Linq;

namespace Hackerrank.ConsoleApp
{
    public static class AppleAndOrangeResolve
    {
        public static void CountApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            var totalApples = CountFruit(s, t, a, apples);
            var totalOranges = CountFruit(s, t, b, oranges);

            Console.WriteLine(totalApples);
            Console.WriteLine(totalOranges);
        }

        public static int CountFruit(int s, int t, int x, int[] fruits)
        {
            return fruits
                .Select(fruit => fruit + x)
                .Count(
                    fruitPosition => fruitPosition >= s
                    && fruitPosition <= t
                );
        }
    }
}