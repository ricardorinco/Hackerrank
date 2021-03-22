using System;

namespace Hackerrank.ConsoleApp
{
    public static class DrawingBookResolve
    {
        public static int PageCount(int n, int p)
        {
            var totalPageTurnCountFromFront = n / 2;
            var targetPageTurnCountFromFront = p / 2;
            var targetPageTurnCountFromBack = totalPageTurnCountFromFront - targetPageTurnCountFromFront;

            return Math.Min(targetPageTurnCountFromFront, targetPageTurnCountFromBack);
        }

    }
}
