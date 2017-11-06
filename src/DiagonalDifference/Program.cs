using System;

namespace DiagonalDifference
{
    public class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = Int32.Parse(Console.ReadLine());

            int[][] matrix = new int[matrixSize][];
            for (int i = 0; i < matrixSize; i++)
            {
                var inputNumbers = Console.ReadLine().Split(' ');
                matrix[i] = Array.ConvertAll(inputNumbers, Int32.Parse);
            }

            var result = (SumPrimaryDiagonal(matrix) - SumSecondaryDiagonal(matrix)).ToString().Replace("-", "");

            Console.WriteLine(result);

            Console.ReadKey();
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
