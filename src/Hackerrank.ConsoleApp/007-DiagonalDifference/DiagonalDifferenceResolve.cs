namespace Hackerrank.ConsoleApp
{
    public static class DiagonalDifferenceResolve
    {
        public static int DiagonalDifference(int[][] matrix)
        {
            var result = (SumPrimaryDiagonal(matrix) - SumSecondaryDiagonal(matrix)).ToString().Replace("-", "");

            return int.Parse(result);
        }

        private static int SumPrimaryDiagonal(int[][] matrix)
        {
            var sum = 0;
            for (int i = 0; i < matrix.Length; i++)
                sum += matrix[i][i];

            return sum;
        }
        private static int SumSecondaryDiagonal(int[][] matrix)
        {
            var sum = 0;
            var count = matrix.Length - 1;
            for (int i = 0; i < matrix.Length; i++)
            {
                sum += matrix[i][count];

                count--;
            }

            return sum;
        }
    }
}
