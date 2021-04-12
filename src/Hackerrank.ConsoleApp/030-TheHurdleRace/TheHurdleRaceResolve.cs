using System;
using System.Collections.Generic;
using System.Linq;

namespace Hackerrank.ConsoleApp
{
    public static class TheHurdleRaceResolve
    {
        public static int HurdleRace(int k, IEnumerable<int> heights)
        {
            var max = heights.Max();
            return Math.Max(max - k, 0);
        }
    }
}
