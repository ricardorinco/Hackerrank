using System;
using System.Linq;

namespace MinMaxSum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            
            miniMaxSum(arr);
        }

        private static void miniMaxSum(int[] numbers)
        {
            Array.Sort(numbers);
            long min = numbers.Take(4).Sum(item => (long)item);
            long max = numbers.Skip(1).Sum(item => (long)item);

            Console.WriteLine($"{min} {max}");
            Console.ReadKey();
        }
    }
}
