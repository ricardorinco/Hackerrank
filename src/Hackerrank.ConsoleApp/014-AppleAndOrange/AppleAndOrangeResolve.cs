using System.Linq;
using Hackerrank.Common.Console.Interfaces;

namespace Hackerrank.ConsoleApp
{
    public static class AppleAndOrangeResolve
    {
        public static void CountApplesAndOranges(IConsole console, int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            var totalApples = CountFruit(s, t, a, apples);
            var totalOranges = CountFruit(s, t, b, oranges);

            console.WriteLine(totalApples.ToString());
            console.WriteLine(totalOranges.ToString());
        }

        private static int CountFruit(int s, int t, int x, int[] fruits)
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