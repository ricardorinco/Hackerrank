using System;
using System.Linq;

namespace Hackerrank.ConsoleApp
{
    public static class TheHurdleRaceResolve
    {
        public static int HurdleRace(int k, int[] heights)
        {
            int max = heights.Max();
            return Math.Max(max - k, 0);
        }
    }
}
