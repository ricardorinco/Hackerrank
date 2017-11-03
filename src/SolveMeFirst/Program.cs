using System;

namespace SolveMeFirst
{
    public class Program
    {
        static void Main(String[] args)
        {
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum = SolveMeFirst(val1, val2);

            Console.WriteLine(sum);

            Console.ReadKey();
        }

        private static int SolveMeFirst(int a, int b)
        {
            return a + b;
        }
    }
}
