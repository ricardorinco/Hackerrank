﻿namespace Hackerrank.ConsoleApp
{
    public static class DivisibleSumPairsResolve
    {
        public static int DivisibleSumPairs(int length, int divisor, int[] numbers)
        {
            var pairs = 0;

            for (var i = 0; i < numbers.Length; i++)
            {
                for (var j = i + 1; j < numbers.Length; j++)
                {
                    if ((numbers[i] + numbers[j]) % divisor == 0)
                        pairs++;
                }
            }

            return pairs;
        }
    }
}
