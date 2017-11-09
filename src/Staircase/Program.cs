using System;

namespace Staircase
{
    public class Program
    {
        static void Main(string[] args)
        {
            var staircaseSize = Int32.Parse(Console.ReadLine());

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
