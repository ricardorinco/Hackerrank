using Hackerrank.Common;
using System;

namespace Hackerrank.ConsoleApp
{
    public static class StaircaseResolve
    {
        public static void Resolve(IConsole console, int staircaseSize)
        {
            string starLine = string.Empty;

            for (int i = staircaseSize; i > 0; i--)
            {
                for (int j = 1; j <= staircaseSize; j++)
                    starLine += j >= i ? "#" : " ";

                console.WriteLine(starLine);
                starLine = string.Empty;
            }
        }
    }
}
