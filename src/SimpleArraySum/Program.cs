using System;

namespace SimpleArraySum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Int32.Parse(Console.ReadLine());

            string[] inputElements = Console.ReadLine().Split(' ');
            int[] arrayElements = Array.ConvertAll(inputElements, Int32.Parse);

            Console.WriteLine(SimpleArraySum(arrayElements));

            Console.ReadKey();
        }

        private static int SimpleArraySum(int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
                sum += number;

            return sum;
        }
    }
}
