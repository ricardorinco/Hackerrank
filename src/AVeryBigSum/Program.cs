using System;
using System.Linq;

namespace AVeryBigSum
{
    public class Program
    {
        static void Main(string[] args)
        {
            var elementsSize = Int32.Parse(Console.ReadLine());
            var inputElements = Console.ReadLine().Split(' ');

            var elements = Array.ConvertAll(inputElements, Int64.Parse);

            Console.WriteLine(elements.Sum());

            Console.ReadKey();
        }
    }
}
