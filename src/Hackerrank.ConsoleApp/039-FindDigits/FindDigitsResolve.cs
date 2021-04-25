using System.Linq;

namespace Hackerrank.ConsoleApp
{
    public static class FindDigitsResolve
    {
        public static int FindDigits(int numbers)
        {
            var divisors = 0;

            var digits = numbers.ToString()
                .Select(d => int.Parse(d.ToString()))
                .ToList();

            foreach (var digit in digits.Where(d => d > 0))
            {
                if (numbers % digit == 0)
                    divisors++;
            }

            return divisors;
        }
    }
}
