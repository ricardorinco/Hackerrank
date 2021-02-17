using System;

namespace Hackerrank.ConsoleApp._009_Staircase
{
    public class StaircaseResolve
    {
        public static void Resolve(int staircaseSize)
        {
            for (int i = staircaseSize; i > 0; i--)
            {
                for (int j = 1; j <= staircaseSize; j++)
                {
                    if (j >= i)
                        Console.Write("#");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
