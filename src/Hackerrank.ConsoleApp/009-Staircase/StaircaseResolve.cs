using Hackerrank.Common.Console.Interfaces;

namespace Hackerrank.ConsoleApp
{
    public static class StaircaseResolve
    {
        public static void Resolve(IConsole console, int staircaseSize)
        {
            var starLine = string.Empty;

            for (var i = staircaseSize; i > 0; i--)
            {
                for (var j = 1; j <= staircaseSize; j++)
                    starLine += j >= i ? "#" : " ";

                console.WriteLine(starLine);
                starLine = string.Empty;
            }
        }
    }
}
