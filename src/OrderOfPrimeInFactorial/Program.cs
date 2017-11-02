using System;
using System.Collections.Generic;

namespace OrderOfPrimeInFactorial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var factorials = new List<Factorial>();
            var testCases = long.Parse(Console.ReadLine());

            for (long i = 0; i < testCases; i++)
            {
                var arrayTemp = Console.ReadLine().Split(' ');
                var input = Array.ConvertAll(arrayTemp, long.Parse);

                var factorial = new Factorial { p = input[0], L = input[1] };

                factorials.Add(factorial);
            }

            foreach (var factorial in factorials)
            {
                long divisibleByP = 0;
                long auxiliary = 0;

                var resultA = (factorial.L / factorial.p) / factorial.p;
                var resultB = (factorial.L / factorial.p) % factorial.p;
                var resultC = factorial.L % factorial.p;

                if (resultA > 0)
                    divisibleByP += resultA * factorial.p;

                while (resultA > 0)
                {
                    auxiliary += resultA;
                    resultA /= factorial.p;
                }

                auxiliary %= factorial.p;

                if (auxiliary > 0)
                    auxiliary = factorial.p - auxiliary;

                if (auxiliary < resultB)
                    divisibleByP += factorial.p;
                else if (auxiliary == resultB)
                    divisibleByP += resultC + 1;

                Console.WriteLine(divisibleByP - 1);
            }

            Console.ReadKey();
        }
    }

    public class Factorial
    {
        public long p { get; set; }
        public long L { get; set; }
    }
}
