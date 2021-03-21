using System.Collections.Generic;
using System.Linq;

namespace Hackerrank.ConsoleApp
{
    public static class DiagonalDifferenceResolve
    {
        public static int DiagonalDifference(int[][] matrix)
        {
            var result = (SumPrimaryDiagonal(matrix) - SumSecondaryDiagonal(matrix))
                .ToString()
                .Replace("-", "");

            return int.Parse(result);
        }

        private static int SumPrimaryDiagonal(IEnumerable<int[]> matrix)
        {
            return matrix.Select((t, i) => t[i]).Sum();
        }
        private static int SumSecondaryDiagonal(IReadOnlyCollection<int[]> matrix)
        {
            var sum = 0;
            var count = matrix.Count - 1;
            foreach (var m in matrix)
            {
                sum += m[count];
                count--;
            }

            return sum;
        }
    }
}
