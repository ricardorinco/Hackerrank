using System;
using System.Collections.Generic;
using System.Linq;

namespace Hackerrank.ConsoleApp
{
    public static class FormingMagicSquareResolve
    {
        private static readonly List<List<int>> Squares = new List<List<int>>
        {
            new List<int> {8, 1, 6, 3, 5, 7, 4, 9, 2},
            new List<int> {6, 1, 8, 7, 5, 3, 2, 9, 4},
            new List<int> {4, 9, 2, 3, 5, 7, 8, 1, 6},
            new List<int> {2, 9, 4, 7, 5, 3, 6, 1, 8},
            new List<int> {8, 3, 4, 1, 5, 9, 6, 7, 2},
            new List<int> {4, 3, 8, 9, 5, 1, 2, 7, 6},
            new List<int> {6, 7, 2, 1, 5, 9, 8, 3, 4},
            new List<int> {2, 7, 6, 9, 5, 1, 4, 3, 8}
        };

        public static int FormingMagicSquare(IEnumerable<int> s)
        {
            return Squares
                .Select(square => square.Zip(s, (m, t) => Math.Abs(m - t)).Sum())
                .Min();
        }
    }
}