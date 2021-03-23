using System.Collections.Generic;

namespace Hackerrank.ConsoleApp
{
    public static class FindThePointResolve
    {
        public static int[] FindPoint(int px, int py, int qx, int qy)
        {
            return new List<int> { 2 * qx - px, 2 * qy - py }.ToArray();
        }
    }
}
