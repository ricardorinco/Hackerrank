using System;

namespace Hackerrank.ConsoleApp
{
    public static class StaircaseResolve
    {
        public static void Resolve(int staircaseSize)
        {
            for (int i = staircaseSize; i > 0; i--)
            {
                for (int j = 1; j <= staircaseSize; j++)
                {
                    Console.Write(j >= i ? "#" : " ");
                }
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
