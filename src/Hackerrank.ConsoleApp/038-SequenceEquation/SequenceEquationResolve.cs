using System;

namespace Hackerrank.ConsoleApp
{
    public static class SequenceEquationResolve
    {
        public static int[] PermutationEquation(int[] values)
        {
            int[] result = new int[values.Length];

            for (int i = 1; i <= values.Length; i++)
                result[i - 1] = Array.IndexOf(values, Array.IndexOf(values, i) + 1) + 1;

            return result;
        }
    }
}
