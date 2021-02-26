using System.Collections.Generic;

namespace Hackerrank.ConsoleApp
{
    public static class SubarrayDivisionResolve
    {
        public static int Birthday(List<int> squares, int d, int m)
        {
            var ways = 0;
            var sum = 0;

            if (m <= squares.Count)
                for (var i = 0; i < m; i++) sum += squares[i];
            
            if (sum == d) ways++;
            
            for (var i = 0; i < squares.Count - m; i++)
            {
                sum = sum - squares[i] + squares[i + m];
                if (sum == d) ways++;
            }
            
            return ways;
        }
    }
}