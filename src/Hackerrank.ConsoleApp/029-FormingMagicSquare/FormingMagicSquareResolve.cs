using System;

namespace Hackerrank.ConsoleApp
{
    public static class FormingMagicSquareResolve
    {
        private static readonly int[,,] matrixCombination = new [,,] {
            { {8, 1, 6 }, { 3, 5, 7 }, { 4, 9, 2 } },
            { {6, 1, 8 }, { 7, 5, 3 }, { 2, 9, 4 } },
            { {4, 9, 2 }, { 3, 5, 7 }, { 8, 1, 6 } },
            { {2, 9, 4 }, { 7, 5, 3 }, { 6, 1, 8 } },
            { {8, 3, 4 }, { 1, 5, 9 }, { 6, 7, 2 } },
            { {4, 3, 8 }, { 9, 5, 1 }, { 2, 7, 6 } },
            { {6, 7, 2 }, { 1, 5, 9 }, { 8, 3, 4 } },
            { {2, 7, 6 }, { 9, 5, 1 }, { 4, 3, 8 } }
        };

        public static int FormingMagicSquare(int[][] matrix)
        {
            var minChanges = int.MaxValue;

            for (var i = 0; i < matrix.Length; ++i) //o
            {
                int changeCount = 0;
                for (var x = 0; x < matrix.Length; ++x)
                {
                    for (var y = 0; y < matrix.Length; ++y)
                    {
                        changeCount += Math.Abs(matrixCombination[i, y, x] - matrix[y][x]);
                    }
                }

                minChanges = Math.Min(minChanges, changeCount);
            }

            return minChanges;
        }
    }
}
